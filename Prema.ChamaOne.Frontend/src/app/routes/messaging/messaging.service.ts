import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

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
  private apiUrl = environment.apiUrl;
  constructor(private http: HttpClient) {}

  getSmsRecords(): Observable<SMSRecord[]> {
    return this.http.get<SMSRecord[]>(`${this.apiUrl}/SMSRecord`);
  }
  
  sendSms(sms: SMS) {
    console.log("sending sms")
    return this.http.post(`${this.apiUrl}/Messaging/SendSingleSms`, sms);
  }
  
  resendMessage(id: number) {
    return this.http.post(`${this.apiUrl}/Messaging/ResendSingleSms`, { id });
  }
}
