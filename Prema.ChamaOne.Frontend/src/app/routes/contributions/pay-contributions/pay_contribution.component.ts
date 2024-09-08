import { Component, Inject, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ContributionDetails, ContributionsService } from '../contributions.service';

@Component({
  selector: 'app-pay-modal',
  templateUrl: './pay_contribution.component.html',
  styleUrl: './pay_contribution.component.scss',  
  providers: [ContributionsService],
})
export class PayModalComponent {

  paymentForm!: FormGroup;
  balanceValue: number;
  
  private readonly contributionsService = inject(ContributionsService);

  constructor(
    private fb: FormBuilder,
    public dialogRef: MatDialogRef<PayModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.balanceValue = data.contribution.balance;
  }


  ngOnInit(): void {
    // Initialize the form group in ngOnInit
    this.paymentForm = this.fb.group({
      memberId: [{ value: this.data.contribution.fk_member_id, disabled: true }, Validators.required],
      amount: [this.data.contribution.balance, [Validators.required, Validators.max(this.data.contribution.balance)]],
      contributionPeriod: [{ value: this.data.contribution.contribution_period, disabled: true }, Validators.required],
      originalAmount: [{ value: this.data.contribution.amount, disabled: true }, Validators.required],
      penalty: [{ value: this.data.contribution.penalty, disabled: true }, Validators.required],  
      reference: ['', Validators.required],
      dateOfPayment: [new Date(), Validators.required] 
    });
  }


  onCancel(): void {
    this.dialogRef.close();
  }

  onPay(): void {
    if (this.paymentForm.valid) {
      // Create the ContributionDetails object
      const contributionDetails: ContributionDetails = {
        amount_paid: this.paymentForm.get('amount')?.value,
        reference: this.paymentForm.get('reference')?.value,
        date_of_payment: this.paymentForm.get('dateOfPayment')?.value,
        contribution_period: this.data.contribution.contribution_period,
        member_id: this.data.contribution.fk_member_id
      };

      // Call the makeContribution method in the service
      this.contributionsService.makeContribution(contributionDetails).subscribe(
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
