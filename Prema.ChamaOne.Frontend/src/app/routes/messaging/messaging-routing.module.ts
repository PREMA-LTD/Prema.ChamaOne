import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MessagingMessagesComponent } from './messages/messages.component';

const routes: Routes = [{ path: 'messaging', component: MessagingMessagesComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MessagingRoutingModule { }
