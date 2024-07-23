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
import { Member, MembersService } from './../members.service';


@Component({
  selector: 'app-members-members',
  templateUrl: './members.component.html',
  styleUrl: './members.component.scss',
  providers: [MembersService],
})
export class MembersMembersComponent implements OnInit {

  private readonly remoteSrv = inject(MembersService);

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

    this.remoteSrv
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
}
