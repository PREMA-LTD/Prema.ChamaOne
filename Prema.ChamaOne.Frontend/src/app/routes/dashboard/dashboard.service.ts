import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { lastValueFrom } from 'rxjs';
import { ApexOptions } from 'apexcharts';
import { ContributionsService } from '../contributions/contributions.service';

@Injectable()
export class DashboardService {
  private readonly contributionsService = inject(ContributionsService);
  private readonly http = inject(HttpClient);

  stats = [
    {
      title: 'Members',
      amount: '180,200',
      progress: {
        value: 50,
      },
      color: 'bg-azure-50',
    },
    {
      title: 'Contributions',
      amount: '70,205',
      progress: {
        value: 70,
      },
      color: 'bg-blue-50',
    }
  ];

  charts: ApexOptions[] = [
    {
      chart: {
        height: 350,
        type: 'bar',
        toolbar: {
          show: false,
        },
      },
      dataLabels: {
        enabled: false,
      },
      stroke: {
        curve: 'smooth',
      },
      series: [
        {
          name: 'Contribution Payment',
          data: [],
        }
      ],
      xaxis: {
        type: 'datetime',
        categories: [],
      },
      tooltip: {
        x: {
          format: 'dd/MM/yy HH:mm',
        },
      },
      legend: {
        position: 'top',
        horizontalAlign: 'right',
      },
    }
  ];

  getStats() {
    return this.stats;
  }

  async getCharts() {
    const contributions = await lastValueFrom(await this.contributionsService.getMemberContributions());
    const groupedTotals = contributions.reduce((acc, contribution) => {
      const period = contribution.contribution_period;
      const total = Number(contribution.amount) + Number(contribution.penalty);
    
      if (!acc[period]) {
        acc[period] = total;
      } else {
        acc[period] += total;
      }
    
      return acc;
    }, {} as Record<string, number>);

    this.charts[0].series = [{
      name: "Contribution Payment",
      data: Object.values(groupedTotals)
    }];

    this.charts[0].xaxis = {
      type: 'datetime',
      categories: Object.keys(groupedTotals)
    };

    console.log(JSON.stringify(this.charts));

    return this.charts;
  }
}