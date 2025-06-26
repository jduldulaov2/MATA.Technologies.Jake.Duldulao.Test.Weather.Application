import { Component } from '@angular/core';
import { ForecastsClient, GetAllForecastQueryDto } from '../../../web-api-client';
import { SpinnerServiceService } from '../../../Services/Shared/spinner-service.service';
declare var $: any;


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent {

  public forcastDto : GetAllForecastQueryDto[] = [];

  constructor(
    private forecastClient: ForecastsClient,
    private loader: SpinnerServiceService
  ) { }

  ngOnInit(){
    this.loader.ShowLoader();
    this.getForecastList();
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

}
