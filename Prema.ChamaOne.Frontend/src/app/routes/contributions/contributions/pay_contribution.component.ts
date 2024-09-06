import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-pay-modal',
  template: `
<h1 mat-dialog-title>Make Payment</h1>
<form [formGroup]="paymentForm" (ngSubmit)="onPay()">
  <div mat-dialog-content>
    <mat-form-field appearance="fill">
      <mat-label>Name</mat-label>
      <input matInput formControlName="memberId" disabled>
    </mat-form-field>

    <mat-form-field appearance="fill">
      <mat-label>Amount</mat-label>
      <input matInput formControlName="amount" type="number" [max]="balanceValue">
      <mat-hint align="end">Max: {{balanceValue}}</mat-hint>
    </mat-form-field>

    <mat-form-field appearance="fill">
      <mat-label>Contribution Period</mat-label>
      <input matInput formControlName="contributionPeriod" disabled>
    </mat-form-field>

    <mat-form-field appearance="fill">
      <mat-label>Original Amount</mat-label>
      <input matInput formControlName="originalAmount" disabled>
    </mat-form-field>

    <mat-form-field appearance="fill">
      <mat-label>Penalty</mat-label>
      <input matInput formControlName="penalty" disabled>
    </mat-form-field>
  </div>

  <div mat-dialog-actions>
    <button mat-button type="button" (click)="onCancel()">Cancel</button>
    <button mat-button type="submit" [disabled]="paymentForm.invalid">Pay</button>
  </div>
</form>

  `
})
export class PayModalComponent {
  constructor(
    public dialogRef: MatDialogRef<PayModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  onCancel(): void {
    this.dialogRef.close();
  }

  onPay(): void {
    // Handle the payment logic here
    this.dialogRef.close({ success: true });
  }
}
