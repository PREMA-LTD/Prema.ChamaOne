import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContributionsContributionsComponent } from './contributions/contributions.component';

const routes: Routes = [{ path: 'contributions', component: ContributionsContributionsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContributionsRoutingModule { }
