import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Member } from '../members/members.service';
import { KeycloakService } from 'keycloak-angular';
import { KeycloakProfile } from 'keycloak-js';

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

export interface ContributionTotalsDto {
  balance: number;    // Represents the balance amount
  penalty: number;    // Represents the penalty amount
  amount: number;     // Represents the contribution amount
  totalPaid: number;  // Calculated as balance - (penalty + amount)
}


@Injectable({
  providedIn: 'root'
})
export class ContributionsService {
  private readonly keycloakService = inject(KeycloakService);
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  async getContributions(page: number, perPage: number): Promise<Observable<ContributionAndMemberPagination>> {
    if(this.keycloakService.isUserInRole("super-admin") || this.keycloakService.isUserInRole("admin")){
      return this.http.get<ContributionAndMemberPagination>(`${this.apiUrl}/Contribution?pageNumber=${page}&pageSize=${perPage}`);
    } else {      
      const keycloakProfile: KeycloakProfile | undefined = await this.keycloakService.loadUserProfile();
      const memberId: any | null = keycloakProfile?.attributes?.['memberId'] ? keycloakProfile.attributes['memberId'] : null;    
  
      console.log("memberId: " + memberId); 
      return this.http.get<ContributionAndMemberPagination>(`${this.apiUrl}/Contribution?pageNumber=${page}&pageSize=${perPage}&memberId=${memberId}`);
    }
  }

  async getContributionTotals(): Promise<Observable<ContributionTotalsDto>> {
    if(this.keycloakService.isUserInRole("super-admin") || this.keycloakService.isUserInRole("admin")){
      return this.http.get<ContributionTotalsDto>(`${this.apiUrl}/Contribution/Totals/0`);
    } else {      
      const keycloakProfile: KeycloakProfile | undefined = await this.keycloakService.loadUserProfile();
      const memberId: any | null = keycloakProfile?.attributes?.['memberId'] ? keycloakProfile.attributes['memberId'] : null;    
  
      console.log("memberId: " + memberId); 
      return this.http.get<ContributionTotalsDto>(`${this.apiUrl}/Contribution/Totals/${memberId}`);
    }
  }

  makeContribution(contributionDetails: ContributionDetails): Observable<Contribution> {
    return this.http.post<Contribution>(`${this.apiUrl}/Contribution/MakeContribution`, contributionDetails);
  }

}
