import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { KeycloakService } from 'keycloak-angular';
// import { Member } from 'app/routes/members/members.service';
import { MessagingService, SMS } from 'app/routes/messaging/messaging.service';
import { MatSnackBar } from '@angular/material/snack-bar';
  
@Injectable()
export class UserService {
  constructor(
    private http: HttpClient,
    private _snackBar: MatSnackBar
    ) {}
  private apiUrl = environment.apiUrl;

  
  private readonly keycloakService = inject(KeycloakService);
  private readonly messagingService = inject(MessagingService);

  async createUser(member: any) {
    try {
      const accessToken = await this.keycloakService.getToken();
  
      // Define new user data with metadata for `memberId`
      const username = `${member.surname}_${member.other_names.split(" ")[0]}`;
      const newUser = {
        username: username,
        firstName: member.other_names.split(" ")[0],
        lastName: member.surname,
        enabled: true,
        attributes: {
          memberId: member.id // Set the `memberId` metadata
        }
      };
  
      const url = `${environment.keycloakUrl}/admin/realms/${environment.keycloakRealm}/users`;
  
      // Step 1: Create User
      const createUserResponse = await fetch(url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          "Authorization": `Bearer ${accessToken}`
        },
        body: JSON.stringify(newUser)
      });
  
      if (!createUserResponse.ok) {
        const errorData = await createUserResponse.json();
        console.error("Error creating user:", errorData);
        return;
      }
  
      console.log("User created successfully.");
  
      // Step 2: Retrieve the created user's ID
      const userIdResponse = await fetch(`${url}?username=${username}`, {
        headers: {
          "Authorization": `Bearer ${accessToken}`
        }
      });
  
      const [createdUser] = await userIdResponse.json();
      const userId = createdUser.id;
  
      // Step 3: Set Password for User
      const password = await this.resetPassword(userId, accessToken);
  
      // Step 4: Assign Role to User
      const roleName = "member"; // Replace with the actual role name
      const rolesUrl = `${environment.keycloakUrl}/admin/realms/${environment.keycloakRealm}/roles/${roleName}`;
      
      // Retrieve the role details
      const roleResponse = await fetch(rolesUrl, {
        headers: {
          "Authorization": `Bearer ${accessToken}`
        }
      });
  
      if (!roleResponse.ok) {
        const errorData = await roleResponse.json();
        console.error("Error retrieving role:", errorData);
        return;
      }
  
      const role = await roleResponse.json();
      const assignRoleUrl = `${environment.keycloakUrl}/admin/realms/${environment.keycloakRealm}/users/${userId}/role-mappings/realm`;
  
      // Assign the role to the user
      const assignRoleResponse = await fetch(assignRoleUrl, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          "Authorization": `Bearer ${accessToken}`
        },
        body: JSON.stringify([role])
      });
  
      if (!assignRoleResponse.ok) {
        const errorData = await assignRoleResponse.json();
        console.error("Error assigning role:", errorData);
        return;
      }
  
      console.log("Role assigned successfully.");

      //send sms to user
      const name = `${member.other_names} ${member.surname}`;
      const message = `Hello ${name},\nWelcome to Shangilia Fintrack! \nYour login details are:\nUsername: ${username}\nPassword: ${password}\nLog in at: ${environment.websiteUrl}\nFor any issues, contact us at: ${environment.contactNumber}`;

      let sms: SMS = {
        message: message,
        recipient_name: name,
        recipient_contact: member.contact,
        sender: 'webapp'
      }

      this.messagingService.sendSms(sms).subscribe(
        response => {
            console.log("Login details sent to user."); 
        },
        error => {
            console.error('Error sending message:', error);
        }
      ); 


      this._snackBar.open('User created and member notified successfully.', 'Ok', {
        horizontalPosition: 'right',
        verticalPosition: 'top',
        duration: 5 * 1000,
        });
  
    } catch (error) {
      console.error("Failed to create user:", error);
    }
  }
  
  generateRandomPassword(length: number = 12): string {
    const chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+[]{}|;:,.<>?";
    let password = "";
    for (let i = 0; i < length; i++) {
      password += chars.charAt(Math.floor(Math.random() * chars.length));
    }
    return password;
  }

  async resetPassword(userId: number, accessToken: string): Promise<string>{
    const setPasswordUrl = `${environment.keycloakUrl}/admin/realms/${environment.keycloakRealm}/users/${userId}/reset-password`;
    const password = this.generateRandomPassword(8);
    const passwordData = {
      type: "password",
      value: password,
      temporary: true
    };

    const setPasswordResponse = await fetch(setPasswordUrl, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
        "Authorization": `Bearer ${accessToken}`
      },
      body: JSON.stringify(passwordData)
    });

    if (!setPasswordResponse.ok) {
      const errorData = await setPasswordResponse.json();
      console.error("Error setting password:", errorData);
      return '';
    }

    console.log("Password set successfully.");

    return password;
  }

//   notifyUser(memberDetails: any): Observable<Member> {
//     return this.http.post<Member>(`${this.apiUrl}/Member`, memberDetails);
//   }
}
