import { Component } from '@angular/core';
import { ForecastsClient, GetAllForecastQueryDto } from '../../../web-api-client';
import { SpinnerServiceService } from '../../../Services/Shared/spinner-service.service';
declare var $: any;

@Component({
  selector: 'app-recent-forecast',
  templateUrl: './recent-forecast.component.html',
  styleUrls: ['./recent-forecast.component.css']
})


export class RecentForecastComponent {

  public forcastDto : GetAllForecastQueryDto[] = [];

  constructor(
    private forecastClient: ForecastsClient,
    private loader: SpinnerServiceService
  ) { }

  ngOnInit(){
    this.getForecastByCityRecent();
  }

  getForecastList(): void {
    this.forecastClient.getAllForcast().subscribe({
      next: result => {
        this.forcastDto = result
        console.log(result);
      },
      error: error => console.error(error)
    });
  }

  getForecastByCityRecent(): void {
    this.loader.ShowLoader();
    var today = new Date();
    var formattedDate = today.toISOString().split('T')[0];
    var city = $('#txtSearch').val();
    var _date = formattedDate;
    this.forecastClient.getForecastByCityRecent(city).subscribe({
      next: result => {
        this.forcastDto = result
        console.log(result);
      },
      error: error => console.error(error)
    });
  }

  onEnter(): void {
    this.getForecastByCityRecent();
  }

  getForecastColor(main: string): string {
  switch (main) {
    case 'Clear': return '#FDB813';        // Sunny yellow
    case 'Clouds': return '#B0BEC5';       // Gray
    case 'Drizzle': return '#4FC3F7';      // Light blue
    case 'Rain': return '#0288D1';         // Blue
    case 'Fog': return '#90A4AE';          // Foggy gray
    case 'Hot': return '#FF5722';          // Hot orange/red
    case 'Storm': return '#512DA8';        // Deep purple
    case 'Wind': return '#26C6DA';         // Turquoise wind
    default: return '#757575';             // Neutral gray
  }
}

}
