import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { MembersRoutingModule } from './members-routing.module';

const COMPONENTS: any[] = [];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    MembersRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ]
})
export class MembersModule { }
