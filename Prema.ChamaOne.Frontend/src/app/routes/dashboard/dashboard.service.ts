import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


  
@Injectable()
export class DashboardService {
  
    
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
    
      constructor(private http: HttpClient) {}

    //   getData() {
    //     return ELEMENT_DATA;
    //   }
    
    //   getMessages() {
    //     return MESSAGES;
    //   }
    
    //   getCharts() {
    //     return this.charts;
    //   }
    
      getStats() {
        return this.stats;
      }

}
