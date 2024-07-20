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

import { PageHeaderComponent } from '@shared';
import { Contribution, ContributionsService } from './contributions.service';

@Component({
  selector: 'app-contributions-contributions',
  templateUrl: './contributions.component.html',
  styleUrl: './contributions.component.scss',  
  providers: [ContributionsService],
})
export class ContributionsContributionsComponent implements OnInit {
  private readonly remoteSrv = inject(ContributionsService);

  columns: MtxGridColumn[] = [
    { header: 'ID', field: 'id' },
    { header: 'Amount', field: 'amount' },
    { header: 'Penalty', field: 'penalty' },
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
    { header: 'Member ID', field: 'fk_member_id' },
  ];
  list: Contribution[] = [];
  total = 0;
  isLoading = true;

  query = {
    q: 'user:nzbin',
    sort: 'stars',
    order: 'desc',
    page: 0,
    per_page: 10,
  };

  get params() {
    const p = Object.assign({}, this.query);
    p.page += 1;
    return p;
  }

  ngOnInit() {
    this.getList();
  }

  getList() {
    this.isLoading = true;

    this.remoteSrv
      .getContributions()
      .pipe(
        finalize(() => {
          this.isLoading = false;
        })
      )
      .subscribe(res => {
        this.list = res;
        this.total = res.length;
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
  }

  reset() {
    this.query.page = 0;
    this.query.per_page = 10;
    this.getList();
  }
}
