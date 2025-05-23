import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ContributionsRoutingModule } from './contributions-routing.module';
import { ContributionsContributionsComponent } from './contributions/contributions.component';
import { PayModalComponent } from './pay-contributions/pay_contribution.component';
import { ContributionsManageContributionsComponent } from './manage-contributions/manage-contributions.component';
import { RecordModalComponent } from './record-contribution/record_contribution.component';

const COMPONENTS: any[] = [ContributionsContributionsComponent, PayModalComponent, RecordModalComponent, ContributionsManageContributionsComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    ContributionsRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ]
})
export class ContributionsModule { }
