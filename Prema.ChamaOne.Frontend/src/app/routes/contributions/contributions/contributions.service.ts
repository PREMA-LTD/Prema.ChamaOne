import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Contribution {
    id: number;
    amount: string;
    penalty: string;
    contribution_period: string;
    fk_transaction_status_id: number;
    fk_member_id: number;
  }
  

@Injectable()
export class ContributionsService {
  constructor(private http: HttpClient) {}

  getContributions(): Observable<Contribution[]> {
    return this.http.get<Contribution[]>('http://chamaone.prema.co.ke/api/Contribution');
  }
}
