import { ChangeDetectionStrategy, ChangeDetectorRef, Component, inject, NgZone, OnInit, OnDestroy } from '@angular/core';
import { DashboardService } from './dashboard.service';
import { MembersService } from '../members/members.service';
import { ContributionAndMember, ContributionAndMemberPagination, ContributionsService, ContributionTotalsDto } from '../contributions/contributions.service';
import ApexCharts from 'apexcharts';
import { finalize, map, Subscription } from 'rxjs';
import { AppSettings, SettingsService } from '@core';
import { MtxGridColumn, MtxGridModule } from '@ng-matero/extensions/grid';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
  providers: [DashboardService, MembersService],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DashboardComponent implements OnInit, OnDestroy {
  private readonly dashboardSrv = inject(DashboardService);
  private readonly membersService = inject(MembersService);
  private readonly contributionsService = inject(ContributionsService);
  private readonly settings = inject(SettingsService);
  private readonly ngZone = inject(NgZone);
  private readonly cdr = inject(ChangeDetectorRef);

  memberCount: number = 0;  
  contributionTotals: ContributionTotalsDto = {
    balance: 0,
    penalty: 0,
    amount: 0,
    totalPaid: 0
  };
  stats: any[] = [];
  
  notifySubscription = new Subscription();

  charts?: ApexCharts.ApexOptions[];
  chart1?: ApexCharts;
  chart2?: ApexCharts;

  
  columns: MtxGridColumn[] = [
    // { header: 'ID', field: 'id' },
    { header: 'Amount', field: 'amount' },
    { header: 'Penalty', field: 'penalty' },
    { header: 'Balance', field: 'balance' },
    {
      header: 'Status',
      field: 'fk_transaction_status_id',
      type: 'tag',
      tag: {
        1: { text: 'Paid', color: 'green-50' },
        2: { text: 'Pending', color: 'orange-50' },
        3: { text: 'Overdue', color: 'red-10' },
      },        
    },
    {
      header: 'Member',
      field: 'member',
      formatter: (record: any) => `${record.member.other_names} ${record.member.surname}`
    },
    {
      header: 'Period',
      field: 'contribution_period',
      formatter: (record: any) => {
        const date = new Date(record.contribution_period); // Convert to JavaScript Date object
        return date.toLocaleString('default', { month: 'long', year: 'numeric' }); // Format to "Month Year"
      }
    },
    // {
    //   header: 'Action',
    //   field: 'action',
    //   type: 'button',
    //   buttons: [
    //     {
    //       text: 'Pay',
    //       color: 'primary',
    //       iif: (record: any) => record.fk_transaction_status_id !== 1 && (this.keycloakService.isUserInRole("admin") || this.keycloakService.isUserInRole("super-admin")),
    //       click: (record: any) => this.openPayModal(record)
    //     }
    //   ]
    // }
  ];
  list: ContributionAndMember[] = [];
  total = 0;
  isLoading = true;
  query = {
    q: 'user:nzbin',
    sort: 'stars',
    order: 'desc',
    page: 0,
    per_page: 10,
  };

  get params() {
    const p = Object.assign({}, this.query);
    p.page += 1;
    return p;
  }

  async ngOnInit() {
    this.updateStats();
    
    const contributionTotals$ = await this.contributionsService.getContributionTotals();
    contributionTotals$.subscribe(contributionTotals => {
      this.contributionTotals = contributionTotals;
      this.updateStats();
      this.cdr.markForCheck();
    });

    try {
      this.charts = await this.dashboardSrv.getCharts();
    } catch (error) {
      console.error('Error fetching charts', error);
    }

    this.notifySubscription.add(
      this.settings.notify.subscribe(opts => {
        console.log(opts);
        this.updateCharts(opts);
      })
    );

    await this.initCharts();
    await this.getList();
  }

  async getList() {
    this.isLoading = true;
  
    (await this.contributionsService
      .getContributions(this.query.page, this.query.per_page, 0, 0, 0, 0))
      .pipe(
        map((res: ContributionAndMemberPagination) => {
          // Filter contributions where balance > 0
          const filteredContributions = res.contributions.filter(contribution => 
            parseFloat(contribution.balance) > 0
          );
          
          return {
            total: filteredContributions.length,
            contributions: filteredContributions
          };
        }),
        finalize(() => {
          this.isLoading = false;
        })
      )
      .subscribe(filteredRes => {
        this.list = filteredRes.contributions;
        this.total = filteredRes.total;
        this.isLoading = false;
        // Mark for change detection after data is set
        this.cdr.markForCheck();
      });
  }

  getNextPage(e: PageEvent) {
    this.query.page = e.pageIndex;
    this.query.per_page = e.pageSize;
    this.getList();
  }

  search() {
    this.query.page = 0;
    this.getList();
  }

  reset() {
    this.query.page = 0;
    this.query.per_page = 10;
    this.getList();
  }

  ngOnDestroy() {
    this.notifySubscription.unsubscribe();
  }

  ngAfterViewInit() {
    this.ngZone.runOutsideAngular(() => this.initCharts());
  }

  private updateStats() {
    this.stats = [
      {
        title: 'Expected Contributions',
        amount: this.contributionTotals.amount,
        progress: {
          value: 100,
        },
        color: 'bg-blue-50',
        period: 'Total'
      },
      {
        title: 'Paid Contributions',
        amount: this.contributionTotals.totalPaid,
        progress: {
          value: (this.contributionTotals.totalPaid / this.contributionTotals.amount) * 100,
        },
        color: 'bg-green-50',
        period: 'Total'
      },
      {
        title: 'Paid Penalties',
        amount: this.contributionTotals.penalty,
        progress: {
          value: (this.contributionTotals.penalty / this.contributionTotals.amount) * 100,
        },
        color: 'bg-red-50',
        period: 'Total'
      },
      {
        title: 'Pending Contributions',
        amount: this.contributionTotals.balance,
        progress: {
          value: (this.contributionTotals.balance / this.contributionTotals.amount) * 100,
        },
        color: 'bg-orange-50',
        period: 'Total'
      }
    ];
  }

  async initCharts() {
    const chartOptions = await this.dashboardSrv.getCharts();

    if (chartOptions && chartOptions.length > 0) {
      this.chart1 = new ApexCharts(document.querySelector('#chart1'), chartOptions[0]);
      this.chart1?.render();
    }
    this.updateCharts(this.settings.options);
  }

  updateCharts(opts: Partial<AppSettings>) {
    const chartOptions = {
      chart: {
        foreColor: opts.theme === 'dark' ? '#ccc' : '#333',
      },
      tooltip: {
        theme: opts.theme === 'dark' ? 'dark' : 'light',
      },
      grid: {
        borderColor: opts.theme === 'dark' ? '#5a5a5a' : '#e9e9e9',
      },
    };

    this.chart1?.updateOptions(chartOptions);

    this.chart2?.updateOptions({
      ...chartOptions,
      plotOptions: {
        radar: {
          polygons: {
            strokeColors: opts.theme === 'dark' ? '#5a5a5a' : '#e9e9e9',
            connectorColors: opts.theme === 'dark' ? '#5a5a5a' : '#e9e9e9',
            fill: {
              colors: opts.theme === 'dark' ? ['#2c2c2c', '#222'] : ['#f8f8f8', '#fff'],
            },
          },
        },
      },
    });
  }
}