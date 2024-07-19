import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { MessagingRoutingModule } from './messaging-routing.module';
import { MessagingMessagesComponent } from './messages/messages.component';
import { SendSmsDialogComponent } from './modals/semd-sms/send-sms.component';

const COMPONENTS: any[] = [MessagingMessagesComponent, SendSmsDialogComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    MessagingRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ]
})
export class MessagingModule { }
