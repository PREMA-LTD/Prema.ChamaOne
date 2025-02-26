import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatOptionModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { PageEvent } from '@angular/material/paginator';
import { MatSelectModule } from '@angular/material/select';
import { MtxGridColumn, MtxGridModule } from '@ng-matero/extensions/grid';
import { finalize } from 'rxjs';
import { MatDialog } from '@angular/material/dialog';

import { PageHeaderComponent } from '@shared';
import { Contribution, ContributionAndMember, ContributionsService } from '../contributions.service';
import { PayModalComponent } from '../pay-contributions/pay_contribution.component'; 
import { KeycloakService } from 'keycloak-angular';
import { Member, MembersService } from 'app/routes/members/members.service';
import { JsonPipe } from '@angular/common';
import { RecordModalComponent } from '../record-contribution/record_contribution.component';

@Component({
  selector: 'app-contributions-ManageContributions',
  templateUrl: './manage-contributions.component.html',
  styleUrl: './manage-contributions.component.scss', 
  providers: [ContributionsService],
})
export class ContributionsManageContributionsComponent implements OnInit {

  constructor(public dialog: MatDialog) {}
  
  private readonly remoteSrv = inject(ContributionsService);
  private readonly keycloakService = inject(KeycloakService);
  private readonly membersService = inject(MembersService)

  columns: MtxGridColumn[] = [
    { header: 'ID', field: 'id' },
    { header: 'Amount', field: 'amount' },
    { header: 'Penalty', field: 'penalty' },
    { header: 'Balance', field: 'balance' },
    {
      header: 'Status',
      field: 'fk_transaction_status_id',
      type: 'tag',
      tag: {
        1: { text: 'Paid', color: 'green-50' },
        2: { text: 'Pending', color: 'orange-50' },
        3: { text: 'Overdue', color: 'red-10' },
      },        
    },
    {
      header: 'Member',
      field: 'member',
      formatter: (record: any) => `${record.member.other_names} ${record.member.surname}`
    },
    {
      header: 'Period',
      field: 'contribution_period',
      formatter: (record: any) => {
        const date = new Date(record.contribution_period); // Convert to JavaScript Date object
        return date.toLocaleString('default', { month: 'long', year: 'numeric' }); // Format to "Month Year"
      }
    },
    {
      header: 'Action',
      field: 'action',
      type: 'button',
      buttons: [
        {
          text: 'Pay',
          color: 'primary',
          iif: (record: any) => record.fk_transaction_status_id !== 1 && (this.keycloakService.isUserInRole("admin") || this.keycloakService.isUserInRole("super-admin")),
          click: (record: any) => this.openPayModal(record)
        }
      ]
    }
  ];

  members: Member[] = [];
  hideMemberSelect: boolean = true; 

  list: ContributionAndMember[] = [];
  total = 0;
  isLoading = true;

  query = {
    q: '',
    sort: 'stars',
    order: 'desc',
    page: 0,
    per_page: 10,
    memberId: 0,
    month: 0,
    year: 0,
    status: 0
  };

  get params() {
    const p = Object.assign({}, this.query);
    p.page += 1;
    return p;
  }

  ngOnInit() {
    this.hideMemberSelect = !(this.keycloakService.isUserInRole("admin") || this.keycloakService.isUserInRole("super-admin") || this.keycloakService.isUserInRole("finance"));
    this.membersService.getMembers().subscribe((members: Member[]) => {
      this.members = members;
    });
    this.getList();
  }

  async getList() {
    this.isLoading = true;

    (await this.remoteSrv
      .getContributions(this.query.page, this.query.per_page, this.query.month, this.query.year, this.query. status, this.query.memberId))
      .pipe(
        finalize(() => {
          this.isLoading = false;
        })
      )
      .subscribe(res => {
        this.list = res.contributions;
        this.total = res.total;
        this.isLoading = false;
      });
  }

  getNextPage(e: PageEvent) {
    this.query.page = e.pageIndex;
    this.query.per_page = e.pageSize;
    this.getList();
  }

  search() {
    this.query.page = 0;
    this.getList();
    console.log("query", JSON.stringify(this.query))
  }

  reset() {
    this.query.page = 0;
    this.query.per_page = 10;
    this.query.memberId = 0;
    this.query.month = 0;
    this.query.status = 0;
    this.query.year = 0;
    this.getList();
  }

  openPayModal(contribution: Contribution): void {
    const dialogRef = this.dialog.open(PayModalComponent, {
      width: '400px',
      data: { contribution }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result.success === true) {
        // Refresh the table after a successful payment

        this.getList();
      }
    });
  }  

  openEditModal(contribution: Contribution): void {
    const dialogRef = this.dialog.open(PayModalComponent, {
      width: '400px',
      data: { contribution }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result.success === true) {
        // Refresh the table after a successful payment
        this.getList();
      }
    });
  }

  recordContribution(): void {
    const dialogRef = this.dialog.open(RecordModalComponent, {
      width: '400px',
      // data: { contribution }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result.success === true) {
        // Refresh the table after a successful payment

        this.getList();
      }
    });
  }  
}
