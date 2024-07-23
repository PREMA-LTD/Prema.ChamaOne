import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MembersMembersComponent } from './members/members.component';

const routes: Routes = [{ path: 'members', component: MembersMembersComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MembersRoutingModule { }
