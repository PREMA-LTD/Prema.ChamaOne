import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoansLoansComponent } from './loans/loans.component';

const routes: Routes = [{ path: 'loans', component: LoansLoansComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoansRoutingModule { }
