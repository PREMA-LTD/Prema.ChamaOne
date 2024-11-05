import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

export interface Member {
  id: number;
  surname: string;
  other_names: string;
  date_of_birth: string; // TypeScript does not have a DateOnly type, so use string
  national_id_number: number;
  contact: string;
  fk_residence_location_id: number;
  fk_gender_id: number;
  fk_member_type_id: number;
  fk_occupation_id: number;
  fk_user_id: string | null;
}


  
@Injectable()
export class MembersService {
  constructor(private http: HttpClient) {}
  private apiUrl = environment.apiUrl;

  getMembers(): Observable<Member[]> {
    return this.http.get<Member[]>(`${this.apiUrl}/Member`);
  }

  getMembersById(memberId: number): Observable<Member> {
    return this.http.get<Member>(`${this.apiUrl}/Member/${memberId}`);
  }
  
  createMember(memberDetails: Member): Observable<Member> {
    return this.http.post<Member>(`${this.apiUrl}/Member`, memberDetails);
  }
  
  updateMember(memberDetails: Member): Observable<Member> {
    return this.http.put<Member>(`${this.apiUrl}/Member/${memberDetails.id}`, memberDetails);
  }

}
