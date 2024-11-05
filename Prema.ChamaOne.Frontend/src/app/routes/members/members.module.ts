import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { MembersRoutingModule } from './members-routing.module';
import { MembersMembersComponent } from './members/members.component';
import { MemberFormComponent } from './member-form/member-form.component';
import { UserService } from '@core/authentication/user.service';
import { MessagingService } from '../messaging/messaging.service';

const COMPONENTS: any[] = [MembersMembersComponent, MemberFormComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    MembersRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ],
  providers: [
    UserService,
    MessagingService
  ]
})
export class MembersModule { }
