import { Component, Inject, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Member, MembersService } from '../members.service';
interface Location {
  id: number;
  name: string;
}

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
    counties = [
      { id: 1, name: 'County A' },
      { id: 2, name: 'County B' },
      { id: 3, name: 'County C' }
    ];    
    subcounties = [
      { id: 1, name: 'Male' },
      { id: 2, name: 'Female' }
    ];
    wards = [
      { id: 1, name: 'Male' },
      { id: 2, name: 'Female' }
    ];
  
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

  
  private readonly membersService = inject(MembersService);

  constructor(
    private fb: FormBuilder,
    public dialogRef: MatDialogRef<MemberFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    // this.balanceValue = data.contribution.balance;
  }


  ngOnInit(): void {
    // Initialize the form group in ngOnInit
    this.memberForm = this.fb.group({
            id: ['', Validators.required],
            surname: ['', Validators.required],
            other_names: ['', Validators.required],
            date_of_birth: ['', Validators.required],
            national_id_number: ['', Validators.required],
            contact: ['', Validators.required],
            fk_residence_location_id: ['', Validators.required],
            fk_gender_id: ['', Validators.required],
            fk_member_type_id: ['', Validators.required],
            fk_occupation_id: ['', Validators.required]
        });
    }


  onCancel(): void {
    this.dialogRef.close();
  }

  onPay(): void {
    if (this.memberForm?.valid) {
      // Create the ContributionDetails object
      const memberDetails: Member = {
        id: this.memberForm.get('id')?.value,
        surname: this.memberForm.get('surname')?.value,
        other_names: this.memberForm.get('other_names')?.value,
        date_of_birth: this.memberForm.get('date_of_birth')?.value,
        national_id_number: this.memberForm.get('national_id_number')?.value,
        contact: this.memberForm.get('contact')?.value,
        fk_residence_location_id: this.memberForm.get('fk_residence_location_id')?.value,
        fk_gender_id: this.memberForm.get('fk_gender_id')?.value,
        fk_member_type_id: this.memberForm.get('fk_member_type_id')?.value,
        fk_occupation_id: this.memberForm.get('fk_occupation_id')?.value
      };
      

      // Call the makeContribution method in the service
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
    }
  }

  onCountyChange() {
    this.isSubcountyDisabled = false;
    const countyId = this.memberForm?.get('county')?.value;
    console.log("county change id: " + countyId)
    this.subcounties = this.subcounties;
    this.memberForm?.patchValue({ subcounty: '', ward: '' });
    this.wards = [];
  }

  onSubcountyChange() {
    this.isWardDisabled = false;
    const countyId = this.memberForm?.get('county')?.value;
    const subcountyId = this.memberForm?.get('subcounty')?.value;
    this.wards = this.wards;
    this.memberForm?.patchValue({ ward: '' });
  }

  onSubmit() {}
}
