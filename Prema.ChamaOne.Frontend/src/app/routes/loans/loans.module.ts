import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { LoansRoutingModule } from './loans-routing.module';
import { LoansLoansComponent } from './loans/loans.component';

const COMPONENTS: any[] = [LoansLoansComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    LoansRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ]
})
export class LoansModule { }
