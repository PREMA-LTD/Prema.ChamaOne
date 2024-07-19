import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MessagingService } from '../../messaging.service';
import { Member, MembersService } from '../../../members/members.service';

@Component({
  selector: 'app-send-sms',
  templateUrl: './send-sms.component.html',
  styleUrls: ['./send-sms.component.scss'],
  providers: [MembersService],
})
export class SendSmsDialogComponent implements OnInit {
  sendMessageForm: FormGroup;
  members: Member[] = [];

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<SendSmsDialogComponent>,
    // private messagingService: MessagingService,
    private membersService: MembersService,
    @Inject(MAT_DIALOG_DATA) public data: any
    ) {
        this.sendMessageForm = this.fb.group({
        contact: ['', Validators.required],
        message: ['', Validators.required]
        });
  }

  ngOnInit(): void {
    this.membersService.getMembers().subscribe((members: Member[]) => {
      this.members = members;
    });
  }

  onSend(): void {
    // if (this.sendMessageForm.valid) {
    //   const { contact, message } = this.sendMessageForm.value;
    //   this.messagingService.sendMessage(contact, message).subscribe(
    //     response => {
    //       this.dialogRef.close(true);
    //     },
    //     error => {
    //       console.error('Error sending message:', error);
    //     }
    //   );
    // }
  }

  onCancel(): void {
    this.dialogRef.close(false);
  }
}
