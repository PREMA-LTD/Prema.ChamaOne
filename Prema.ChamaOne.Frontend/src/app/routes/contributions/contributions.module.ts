import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ContributionsRoutingModule } from './contributions-routing.module';
import { ContributionsContributionsComponent } from './contributions/contributions.component';

const COMPONENTS: any[] = [ContributionsContributionsComponent];
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
