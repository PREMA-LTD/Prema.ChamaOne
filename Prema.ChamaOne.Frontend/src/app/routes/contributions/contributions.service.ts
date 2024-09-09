import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Member } from '../members/members.service';

export interface Contribution {
  id: number;
  amount: string;
  penalty: string;
  balance: string;
  contribution_period: string;
  fk_transaction_status_id: number;
  fk_member_id: number;
}

export interface ContributionDetails {
    amount_paid: number;
    reference: string;
    date_of_payment: Date;
    contribution_period: Date;
    member_id: number;
}

export interface ContributionAndMember {
  id: number;
  amount: string;
  penalty: string;
  balance: string;
  contribution_period: Date;
  fk_transaction_status_id: number;
  member: Member;
}

export interface ContributionAndMemberPagination {
  total: number;
  contributions: ContributionAndMember[];
}

@Injectable({
  providedIn: 'root'
})
export class ContributionsService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getContributions(page: number, perPage: number): Observable<ContributionAndMemberPagination> {
    return this.http.get<ContributionAndMemberPagination>(`${this.apiUrl}/Contribution?pageNumber=${page}&pageSize=${perPage}`);
  }


  makeContribution(contributionDetails: ContributionDetails): Observable<Contribution> {
    return this.http.post<Contribution>(`${this.apiUrl}/Contribution/MakeContribution`, contributionDetails);
  }

}
