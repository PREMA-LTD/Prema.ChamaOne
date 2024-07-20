import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface SMSRecord {
  id: number;
  message: string;
  recipient_name: string;
  recipient_contact: string;
  date_time_sent: Date;
  failure_count: number;
  status: SmsStatus;
  smsFailures: SMSFailure[];
}

export enum SmsStatus {
  Sent = 1,
  Pending = 2,
  Failed = 3
}

export interface SMSFailure {
  id: number;
  error: string;
  date_time: Date;
  fk_sms_record_id: number;
}

export interface SMS {
  message: string;
  recipient_name: string;
  recipient_contact: string;
  sender: string;
}

@Injectable()
export class MessagingService {
  constructor(private http: HttpClient) {}

  getSmsRecords(): Observable<SMSRecord[]> {
    return this.http.get<SMSRecord[]>('http://localhost:5047/api/SMSRecord');
  }
  
  sendSms(sms: SMS) {
    return this.http.post('http://localhost:5047/api/Messaging/SendSingleSms', sms);
  }
}
