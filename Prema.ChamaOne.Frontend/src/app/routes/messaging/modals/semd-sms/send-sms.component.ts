import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MessagingService, SMS } from '../../messaging.service';
import { Member, MembersService } from '../../../members/members.service';
import { map, mergeMap, Observable, of, startWith } from 'rxjs';

@Component({
  selector: 'app-send-sms',
  templateUrl: './send-sms.component.html',
  styleUrls: ['./send-sms.component.scss'],
  providers: [MembersService, MessagingService],
})
export class SendSmsDialogComponent implements OnInit {
  sendMessageForm: FormGroup;
  members: Member[] = [];
  filteredMembers: Observable<Member[]> = of([]); 
  

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<SendSmsDialogComponent>,
    private messagingService: MessagingService,
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
      this.filteredMembers = of(members);
    });

    // this.filteredMembers = this.sendMessageForm.get('contact')!.valueChanges.pipe(
    //   startWith(''),
    //   mergeMap(() => this.members ? of(this.members) : of([])),
    //   map(members => this._filter(value || ''))
    // );
  }

  onSend(): void {
    if (this.sendMessageForm.valid) {
      const { contact, message } = this.sendMessageForm.value;
      let sms: SMS = {
        message: message,
        recipient_name: '',
        recipient_contact: contact,
        sender: 'webapp'
      }
      this.messagingService.sendSms(sms).subscribe(
        response => {
          this.dialogRef.close(true);
        },
        error => {
          console.error('Error sending message:', error);
        }
      );
    }
  }

  onCancel(): void {
    this.dialogRef.close(false);
  }

  private _filter(value: string): any[] {
    const filterValue = value.toLowerCase();
    return this.members.filter(member => member.other_names.toLowerCase().includes(filterValue) || member.surname.toLowerCase().includes(filterValue));
  }

  onRecipientSelected(value: any) {
    this.sendMessageForm.get('contact')!.setValue(value);
  }
}
