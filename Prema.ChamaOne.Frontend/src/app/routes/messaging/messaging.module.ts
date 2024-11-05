import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { MessagingRoutingModule } from './messaging-routing.module';
import { MessagingMessagesComponent } from './messages/messages.component';
import { SendSmsDialogComponent } from './modals/semd-sms/send-sms.component';
import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';
import { UserService } from '@core/authentication/user.service';

const COMPONENTS: any[] = [MessagingMessagesComponent, SendSmsDialogComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    MessagingRoutingModule,
    MatChipsModule,
    MatIconModule,
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ],
})
export class MessagingModule { }
