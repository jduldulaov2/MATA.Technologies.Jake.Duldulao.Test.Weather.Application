import { Component } from '@angular/core';
import { ForecastsClient, GetAllForecastQueryDto } from '../../../web-api-client';
import { SpinnerServiceService } from '../../../Services/Shared/spinner-service.service';
import { AuthClient } from '../../../web-api-client';

declare var $: any;


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent {

  public forcastDto : GetAllForecastQueryDto[] = [];
  date_today: Date = new Date();

  constructor(
    private forecastClient: ForecastsClient,
    private loader: SpinnerServiceService,
    private authClient: AuthClient
  ) { }

  ngOnInit(){
    this.getForecastByCityAndDate();
    this.checkIfLoggedIn();
  }

  ExternalSignOut(){
    localStorage.removeItem("github_token");
    localStorage.clear();
    location.href = '/login';
  }
  
  checkIfLoggedIn(){
    const storedResult = JSON.parse(localStorage.getItem('github_token') || '{}');
    if (typeof storedResult.login === 'undefined') {
      location.href = '/login';
    }
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

  getForecastByCityAndDate(): void {
    this.loader.ShowLoader();
    var today = new Date();
    var formattedDate = today.toISOString().split('T')[0];
    var city = $('#txtSearch').val();
    var _date = formattedDate;
    this.forecastClient.getForecastByCityAndDate(city, _date).subscribe({
      next: result => {
        this.forcastDto = result
        console.log(result);
      },
      error: error => console.error(error)
    });
  }

  onEnter(): void {
    this.getForecastByCityAndDate();
  }

  SignOut(){
    this.authClient.geLoggedIn().subscribe({
      next: result => {
        if(result.resultType == 1){
          var loggedInId = result.data?.loggedInId;
          this.ProceedSignOut(loggedInId);
        }else{
          location.href = '/login';
        }
      },
      error: error => console.error(error)
    });
  }

  ProceedSignOut(id: any){
    this.authClient.logOut(id).subscribe({
      next: result => {
        if(result.resultType == 1){
          location.href = '/login';
        }
      },
      error: error => console.error(error)
    });
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
