import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContributionsContributionsComponent } from './contributions/contributions.component';
import { ContributionsManageContributionsComponent } from './manage-contributions/manage-contributions.component';

const routes: Routes = [
  { path: 'ViewContributions', component: ContributionsContributionsComponent },
  { path: 'ManageContributions', component: ContributionsManageContributionsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContributionsRoutingModule { }
