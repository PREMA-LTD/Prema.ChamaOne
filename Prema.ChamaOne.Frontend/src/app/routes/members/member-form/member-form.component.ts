import { Component, Inject, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Member, MembersService } from '../members.service';
import { LocationService } from 'app/services/location.service';
import { County, LocationData, Subcounty, Ward } from 'app/models/location.model';
import { KeycloakService } from 'keycloak-angular';

@Component({
  selector: 'app-pay-modal',
  templateUrl: './member-form.component.html',
  styleUrl: './member-form.component.scss',
  providers: [MembersService],
})

export class MemberFormComponent {

  memberForm!: FormGroup;
  isSubcountyDisabled: boolean = true;
  isWardDisabled: boolean = true;
  counties: County[] = [];
  subcounties: Subcounty[] = [];
  wards: Ward[] = [];

  buttonText: string = '';

  genders = [
    { id: 1, name: 'Male' },
    { id: 2, name: 'Female' }
  ];

  memberTypes = [
    { id: 1, name: 'Member' },
    { id: 2, name: 'Director' },
    { id: 3, name: 'Deputy Director' },
    { id: 4, name: 'Secretary' },
    { id: 5, name: 'Deputy Secretary' },
    { id: 6, name: 'Treasurer' }
  ];

  occupations = [
    { id: 1, name: 'Student' },
    { id: 2, name: 'Employee' },
    { id: 3, name: 'Self-employed' }
  ];

  memberData?: Member;
  selectedCountyId: number | null = null; // Variable to store the selected county ID
  selectedSubcountyId: number | null = null; // Variable to store the selected county ID

  private readonly membersService = inject(MembersService);
  private readonly locationService = inject(LocationService);
  private readonly keycloakService = inject(KeycloakService);

  constructor(
    private fb: FormBuilder,
    public dialogRef: MatDialogRef<MemberFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.memberData = data.memberData;
  }

  async ngOnInit(): Promise<void> {
    const isAdminOrSuperAdmin = this.keycloakService.isUserInRole("super-admin") || this.keycloakService.isUserInRole("admin");
    // Initialize the form group in ngOnInit
    if (this.memberData == null) {
      this.buttonText = 'Create User';
      this.memberForm = this.fb.group({
        surname: ['', Validators.required],
        other_names: ['', Validators.required],
        date_of_birth: ['', Validators.required],
        national_id_number: ['', Validators.required],
        contact: [
          '',
          [
            Validators.required,
            Validators.pattern(/^254\d{9}$/)  // must start with '254' and have exactly 12 digits
          ]
        ],
        county: ['', Validators.required],
        subcounty: ['', Validators.required],
        ward: ['', Validators.required],
        fk_gender_id: ['', Validators.required],
        fk_member_type_id: ['', Validators.required],
        fk_occupation_id: ['', Validators.required]
      });
      this.memberForm.get('subcounty')?.disable();
      this.memberForm.get('ward')?.disable();

      await this.getCounties();

    } else {

      this.buttonText = 'Update User';
      console.log(JSON.stringify(this.memberData))
      this.memberForm = this.fb.group({
        surname: [this.memberData.surname, Validators.required],
        other_names: [this.memberData.other_names, Validators.required],
        date_of_birth: [this.memberData.date_of_birth, Validators.required],
        national_id_number: [this.memberData.national_id_number, Validators.required],
        contact: [
          this.memberData.contact,
          [
            Validators.required,
            Validators.pattern(/^254\d{9}$/)  // must start with '254' and have exactly 12 digits
          ]
        ],
        county: ['', Validators.required],
        subcounty: ['', Validators.required],
        ward: [this.memberData.fk_residence_location_id, Validators.required],
        fk_gender_id: [this.memberData.fk_gender_id, Validators.required],
        fk_member_type_id: [this.memberData.fk_member_type_id, Validators.required],
        fk_occupation_id: [this.memberData.fk_occupation_id, Validators.required]
      });

      const locationData = await this.getLocation(this.memberData.fk_residence_location_id);
      if (locationData != undefined) {
        await this.getSubcounties(locationData.countyId)
      }
      await this.getWards(locationData?.subcountyId);

      this.memberForm.get('county')?.setValue(locationData?.countyId);
      this.memberForm.get('subcounty')?.setValue(locationData?.subcountyId);
      this.memberForm.get('ward')?.setValue(this.memberData.fk_residence_location_id);

      await this.getCounties();

      if (!isAdminOrSuperAdmin) {
        this.memberForm.get('fk_member_type_id')?.disable();
      } else {
        this.memberForm.get('fk_member_type_id')?.enable();
      }

    }

    this.memberForm.get('county')?.setValidators([Validators.required]);
    this.memberForm.get('county')?.updateValueAndValidity();
  }

  async getLocation(wardId: number): Promise<LocationData | undefined> {
    this.isSubcountyDisabled = false;
    try {
      const location = await (await this.locationService.getLocation(wardId)).toPromise();
      return location;
    } catch (error) {
      console.error('Error fetching location', error);
      return undefined;
    }
  }

  async getCounties() {
    (await this.locationService.getCounties()).subscribe(
      (data: County[]) => {
        this.counties = data;  // Assign the data to the counties array
      },
      (error) => {
        console.error('Error fetching counties', error);
      }
    );
    this.memberForm.get('county')?.setValidators([Validators.required]);
    this.memberForm.get('county')?.updateValueAndValidity();
  }

  async getSubcounties(countyId: number) {
    (await this.locationService.getSubcounties(countyId)).subscribe(
      (data: Subcounty[]) => {
        this.subcounties = data;  // Assign the data to the counties array
      },
      (error) => {
        console.error('Error fetching subcounties', error);
      }
    );

  }

  async getWards(subcountyId?: number) {
    (await this.locationService.getWards(subcountyId)).subscribe(
      (data: Ward[]) => {
        this.wards = data;  // Assign the data to the counties array
      },
      (error) => {
        console.error('Error fetching wards', error);
      }
    );
    this.memberForm.get('ward')?.enable();
  }

  onCancel(): void {
    this.dialogRef.close();
  }

  onCountyChange(countyId: number) {
    this.isSubcountyDisabled = false;
    this.getSubcounties(countyId);
    this.memberForm.get('subcounty')?.setValidators([Validators.required]);
    this.memberForm.get('ward')?.setValidators([Validators.required]);
    this.memberForm.get('subcounty')?.updateValueAndValidity();
    this.memberForm.get('ward')?.updateValueAndValidity();
    this.memberForm.get('subcounty')?.enable();
    this.memberForm.get('ward')?.disable();
  }

  onSubcountyChange(subcountyId: number) {
    this.getWards(subcountyId);
    this.memberForm.get('ward')?.enable();
    this.memberForm.get('ward')?.setValidators([Validators.required]);
    this.memberForm.get('ward')?.updateValueAndValidity();
  }

  onSubmit() {
    if (this.memberForm.valid) {
      const dateOfBirth = new Date(this.memberForm.get('date_of_birth')?.value);
      const dateOnly = dateOfBirth.toISOString().split('T')[0];
      const memberDetails: Member = {
        id: 0,
        surname: this.memberForm.get('surname')?.value,
        other_names: this.memberForm.get('other_names')?.value,
        date_of_birth: dateOnly,
        national_id_number: this.memberForm.get('national_id_number')?.value,
        contact: this.memberForm.get('contact')?.value,
        fk_residence_location_id: this.memberForm.get('ward')?.value,
        fk_gender_id: this.memberForm.get('fk_gender_id')?.value,
        fk_member_type_id: this.memberForm.get('fk_member_type_id')?.value,
        fk_occupation_id: this.memberForm.get('fk_occupation_id')?.value,
        fk_user_id: null
      };

      // Call the makeContribution method in the service

      if (this.memberData == null) {
        this.membersService.createMember(memberDetails).subscribe(
          (response) => {
            // Handle success, e.g., close the dialog and refresh data
            this.dialogRef.close({ success: true, data: response });
          },
          (error) => {
            // Handle error, e.g., display error message
            console.error('Create member failed', error);
          }
        );
      } else {
        memberDetails.id = this.memberData.id;
        this.membersService.updateMember(memberDetails).subscribe(
          (response) => {
            // Handle success, e.g., close the dialog and refresh data
            this.dialogRef.close({ success: true, data: response });
          },
          (error) => {
            // Handle error, e.g., display error message
            console.error('Create member failed', error);
          }
        );
      }
    } else {
      console.error('memberForm is not valid. Here are the errors:');

      Object.keys(this.memberForm.controls).forEach(controlName => {
        const control = this.memberForm.get(controlName);
        if (control && control.invalid) {
          const errors = control.errors;
          console.error(`Control: ${controlName}, Errors: `, errors);
        }
      });
      this.markFormGroupTouched(this.memberForm);
    }
  }

  markFormGroupTouched(formGroup: FormGroup) {
    Object.values(formGroup.controls).forEach(control => {
      control.markAsTouched();

      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      }
    });
  }
}
