import { ChangeDetectionStrategy, Component, inject, OnInit } from '@angular/core';
import { DashboardService } from './dashboard.service';
import { MembersService } from '../members/members.service';
import { finalize } from 'rxjs/operators';

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

  memberCount: number = 0;
  stats = [
    {
      title: 'Members',
      amount: 0,  // Initialize with 0 or any default value
      progress: {
        value: 50,
      },
      color: 'bg-azure-50',
      period: ''
    },
    {
      title: 'Contributions',
      amount: '70,205',
      progress: {
        value: 70,
      },
      color: 'bg-blue-50',
      period: 'Total'
    }
  ];

  ngOnInit() {
    this.membersService
      .getMembers()
      .pipe(
        finalize(() => {
          // this.isLoading = false; // Uncomment if you have isLoading variable
        })
      )
      .subscribe(res => {
        this.memberCount = res.length;
        this.updateStats();
        // this.isLoading = false; // Uncomment if you have isLoading variable
      });
  }

  private updateStats() {
    this.stats[0].amount = this.memberCount;
  }
}
