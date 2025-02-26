import { Component, Injectable, OnInit, inject } from '@angular/core';
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
import { Member, MembersService } from './../members.service';
import { MatDialog } from '@angular/material/dialog';
import { MemberFormComponent } from '../member-form/member-form.component';
import { KeycloakService } from 'keycloak-angular';
import { UserService } from '@core/authentication/user.service';
import { MatSnackBar } from '@angular/material/snack-bar';


@Component({
  selector: 'app-members-members',
  templateUrl: './members.component.html',
  styleUrl: './members.component.scss',
  providers: [MembersService],
})

@Injectable({
  providedIn: 'root', // This makes the service globally available without adding it to providers
})


export class MembersMembersComponent implements OnInit {
  
  constructor(
    public dialog: MatDialog,  
    private _snackBar: MatSnackBar
  ) {}

  private readonly memberService = inject(MembersService);
  private readonly keycloakService = inject(KeycloakService);
  private readonly userService = inject(UserService);

  columns: MtxGridColumn[] = [
    { header: 'Member ID', field: 'id' },
    { header: 'Surname', field: 'surname' },
    { header: 'Penalty', field: 'other_names' },
    { header: 'DOB', field: 'date_of_birth' },    
    { header: 'National ID', field: 'national_id_number' },
    { header: 'Contact', field: 'contact' },
    {
      header: 'Gender',
      field: 'fk_gender_id',
      type: 'tag',
      tag: {
        1: { text: 'Male' },
        2: { text: 'Female' },
      },        
    },
    {
      header: 'Member Type',
      field: 'fk_member_type_id',
      type: 'tag',
      tag: {
        1: { text: 'Member' },
        2: { text: 'Director' },
        3: { text: 'Deputy Director' },
        4: { text: 'Secratary' },
        5: { text: 'Deputy Secratary' },
        6: { text: 'Treasurer' },
      },        
    },
    {
      header: 'Occupation',
      field: 'fk_occupation_id',
      type: 'tag',
      tag: {
        1: { text: 'Student' },
        2: { text: 'Employed' },
        3: { text: 'Self Employed' },
      },        
    },
    {
      header: 'Actions',
      field: 'action',
      type: 'button',
      buttons: [
        {
          text: 'Edit',
          color: 'primary',
          iif: (record: Member) => this.keycloakService.isUserInRole("admin") || this.keycloakService.isUserInRole("super-admin"),
          click: (record: Member) => this.openCreateMemberDialog(record)
        },        
        {
          text: 'Create User',
          color: 'primary',
          iif: (record: Member) => (this.keycloakService.isUserInRole("admin") || this.keycloakService.isUserInRole("super-admin")) && record.fk_user_id == null,
          click: (record: Member) => this.createUser(record)
        }
      ]
    }    
  ];
  list: Member[] = [];
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

    this.memberService
      .getMembers()
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

  openCreateMemberDialog(memberData?: Member): void {
    console.log("openCreateMemberDialog")
    const dialogRef = this.dialog.open(MemberFormComponent, {
      maxWidth: '90vw',
      width: '500px',
      maxHeight: '90vh',
      height: 'auto',
      panelClass: './members.component.scss',
      disableClose: true,
      autoFocus: true,
      data: { memberData }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result.success === true) {
        // Refresh the table after a successful payment
        this.getList();
      }
    });
  }

  async createUser(member: Member) {    
    await this.userService.createUser(member)
    .then(response => {
      console.log("User created.");

      if(response){
      this._snackBar.open('User created and member notified successfully.', 'Ok', {
        horizontalPosition: 'right',
        verticalPosition: 'top',
        duration: 5 * 1000,
        });
      } else {
        this._snackBar.open('Error creating user.', 'Ok', {
          panelClass: ['error-snackbar'],  // Add a custom CSS class
          horizontalPosition: 'right',
          verticalPosition: 'top',
          duration: 5 * 1000,
          });
      }

    })
    .catch(error => {
      console.error('Error sending message:', error);

      
      this._snackBar.open('Error creating user.', 'Ok', {
        panelClass: ['error-snackbar'],  // Add a custom CSS class
        horizontalPosition: 'right',
        verticalPosition: 'top',
        duration: 5 * 1000,
        });
    });

    
    this.getList();
  
  }
}
