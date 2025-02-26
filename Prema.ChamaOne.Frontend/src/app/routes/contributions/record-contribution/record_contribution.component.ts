import { Component, Inject, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ContributionDetails, ContributionsService, FutureContributionDetails } from '../contributions.service';
import { Member, MembersService } from 'app/routes/members/members.service';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-record-modal',
  templateUrl: './record_contribution.component.html',
  styleUrl: './record_contribution.component.scss',  
  providers: [ContributionsService],
})
export class RecordModalComponent {

  paymentForm!: FormGroup;
  
  private readonly contributionsService = inject(ContributionsService);
  private readonly memberService = inject(MembersService);
  
  membersList: Member[] = [];

  constructor(
    private fb: FormBuilder,
    public dialogRef: MatDialogRef<RecordModalComponent>
  ) {
  }


  ngOnInit(): void {
    // Initialize the form group in ngOnInit
    this.paymentForm = this.fb.group({
      memberId: ['', Validators.required],
      reference: ['', Validators.required],
      amount: ['', Validators.required],
      dateOfPayment: [new Date(), Validators.required] 
    });



    this.memberService
    .getMembers()
    .pipe(
      finalize(() => {
        // this.isLoading = false;
      })
    )
    .subscribe(res => {
      this.membersList = res;
    });
  }


  onCancel(): void {
    this.dialogRef.close();
  }

  onPay(): void {
    if (this.paymentForm.valid) {
      // Create the ContributionDetails object
      const contributionDetails: FutureContributionDetails = {
        amountPaid: this.paymentForm.get('amount')?.value,
        reference: this.paymentForm.get('reference')?.value,
        dateOfPayment: this.paymentForm.get('dateOfPayment')?.value,
        memberId: this.paymentForm.get('memberId')?.value
      };

      // Call the makeContribution method in the service
      this.contributionsService.makeFutureContribution(contributionDetails).subscribe(
        (response) => {
          // Handle success, e.g., close the dialog and refresh data
          this.dialogRef.close({ success: true, data: response });
        },
        (error) => {
          // Handle error, e.g., display error message
          console.error('Payment failed', error);
        }
      );
    }
  }
}
