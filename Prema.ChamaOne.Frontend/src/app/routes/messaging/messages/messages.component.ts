import { Component } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { MatTableDataSource } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { SMSRecord, MessagingService, SMS } from '../messaging.service';
import { MatDialog } from '@angular/material/dialog';
import { SendSmsDialogComponent } from '../modals/semd-sms/send-sms.component';
import { MatChipsModule } from '@angular/material/chips';

@Component({
  selector: 'app-messaging-messages',
  templateUrl: './messages.component.html',
  styleUrl: './messages.component.scss',
  providers: [
      MessagingService
  ],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class MessagingMessagesComponent {
  dataSource = new MatTableDataSource<SMSRecord>([]);
  columnsToDisplay = ['id', 'message', 'recipient_name', 'recipient_contact', 'date_time_sent', 'failure_count', 'status', 'expand', 'action'];
  columnsToDisplayWithExpand = [...this.columnsToDisplay];
  expandedElement!: SMSRecord | null;

  constructor(
    private messagingService: MessagingService,
    public dialog: MatDialog) {
    this.fetchData();
  }

  fetchData() {
    this.messagingService.getSmsRecords().subscribe((data: SMSRecord[]) => {
      this.dataSource.data = data;
    });
  }

  toggleExpandRow(element: SMSRecord): void {
    this.expandedElement = this.expandedElement === element ? null : element;
  }

  getStatusClass(status: number): string {
    switch (status) {
      case 1: return 'primary';
      case 2: return 'accent';
      case 3: return 'warn';
      default: return '';
    }
  }

  getStatusText(status: number): string {
    switch (status) {
      case 1: return 'Sent';
      case 2: return 'Pending';
      case 3: return 'Failed';
      default: return '';
    }
  }

  resendMessage(message: SMSRecord) {
    let sms: SMS = {
      message: message.message,
      recipient_name: message.recipient_name,
      recipient_contact: this.formatPhoneNumber(message.recipient_contact),
      sender: 'webapp'
    }
    this.messagingService.resendMessage(message.id).subscribe(
      response => {
        this.fetchData();
      },
      error => {
        console.error('Error sending message:', error);
      }
    );
  }

  formatPhoneNumber(number: string) {
    // Remove leading zero and add country code
    return number.replace(/^0/, '254');
  }

  openSendMessageDialog(): void {
    console.log("opening dialog box")
    const dialogRef = this.dialog.open(SendSmsDialogComponent, {
      width: '400px',
      data: {}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        console.log('Message sent successfully');        
        this.fetchData();
      } else {
        console.log('Message sending canceled');
      }
    });
  }
  
}
