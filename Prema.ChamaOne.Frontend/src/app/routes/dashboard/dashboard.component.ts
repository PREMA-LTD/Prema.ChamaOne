import { ChangeDetectionStrategy, ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { DashboardService } from './dashboard.service';
import { MembersService } from '../members/members.service';
import { finalize } from 'rxjs/operators';
import { ContributionsService, ContributionTotalsDto } from '../contributions/contributions.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
  providers: [DashboardService, MembersService],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DashboardComponent implements OnInit {
  private readonly dashboardSrv = inject(DashboardService);
  private readonly membersService = inject(MembersService);
  private readonly contributionsService = inject(ContributionsService);

  private readonly cdr = inject(ChangeDetectorRef); // Inject ChangeDetectorRef
  memberCount: number = 0;  
  contributionTotals: ContributionTotalsDto = {
    balance: 0,
    penalty: 0,
    amount: 0,
    totalPaid: 0
  };
  stats = [
    // {
    //   title: 'Members',
    //   amount: this.memberCount,  // Initialize with 0 or any default value
    //   progress: {
    //     value: 100,
    //   },
    //   color: 'bg-azure-50',
    //   period: 'Current'
    // },
    {
      title: 'Expected Contributions',
      amount: this.contributionTotals.amount,
      progress: {
        value: this.contributionTotals.amount,
      },
      color: 'bg-blue-50',
      period: 'Total'
    },
    {
      title: 'Paid Contributions',
      amount: this.contributionTotals.totalPaid,
      progress: {
        value: this.contributionTotals.totalPaid / this.contributionTotals.amount,
      },
      color: 'bg-blue-50',
      period: 'Total'
    },
    {
      title: 'Penalties',
      amount: this.contributionTotals.penalty,
      progress: {
        value: this.contributionTotals.penalty / this.contributionTotals.amount,
      },
      color: 'bg-red-50',
      period: 'Total'
    },
    {
      title: 'Pending Contributions',
      amount: this.contributionTotals.balance,
      progress: {
        value: this.contributionTotals.balance / this.contributionTotals.amount,
      },
      color: 'bg-orange-50',
      period: 'Total'
    }
  ];

  async ngOnInit() {
    // this.membersService
    //   .getMembers()
    //   .subscribe(res => {
    //     this.memberCount = res.length; 
    
    //     this.updateStats();
    //     this.cdr.markForCheck();// Manually trigger change detection
    //     // this.isLoading = false; // Uncomment if you have isLoading variable
    //   });

      (await this.contributionsService.getContributionTotals())
      .subscribe(contributionTotals => {
        this.contributionTotals = contributionTotals;
    
        this.updateStats();
        this.cdr.markForCheck();
        // Update your UI or do something with contributionTotals here
      });
  }

  private updateStats() {
    this.stats = [
      // {
      //   title: 'Members',
      //   amount: this.memberCount,  // Initialize with 0 or any default value
      //   progress: {
      //     value: 100,
      //   },
      //   color: 'bg-azure-50',
      //   period: 'Current'
      // },
      {
        title: 'Expected Contributions',
        amount: this.contributionTotals.amount,
        progress: {
          value: this.contributionTotals.amount,
        },
        color: 'bg-blue-50',
        period: 'Total'
      },
      {
        title: 'Paid Contributions',
        amount: this.contributionTotals.totalPaid,
        progress: {
          value: this.contributionTotals.totalPaid / this.contributionTotals.amount,
        },
        color: 'bg-blue-50',
        period: 'Total'
      },
      {
        title: 'Penalties',
        amount: this.contributionTotals.penalty,
        progress: {
          value: this.contributionTotals.penalty / this.contributionTotals.amount,
        },
        color: 'bg-red-50',
        period: 'Total'
      },
      {
        title: 'Pending Contributions',
        amount: this.contributionTotals.balance,
        progress: {
          value: this.contributionTotals.balance / this.contributionTotals.amount,
        },
        color: 'bg-orange-50',
        period: 'Total'
      }
    ];
  }
}
