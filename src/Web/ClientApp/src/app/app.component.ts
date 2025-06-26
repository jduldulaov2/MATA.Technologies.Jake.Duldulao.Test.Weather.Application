import { Component } from '@angular/core';
import { SpinnerServiceService } from './Services/Shared/spinner-service.service';
import { AuthClient } from './web-api-client';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  public getLoggedInQueryDto: any;

  constructor(private loader: SpinnerServiceService, private authClient: AuthClient, private router: Router, private route: ActivatedRoute) {}

  title = 'app';

  IsLoggedIn: any;

  ngOnInit(){
    this.checkIfLoggedIn();
  }

  checkIfLoggedIn(){
    this.IsLoggedIn = false;
    const storedResult = JSON.parse(localStorage.getItem('github_token') || '{}');
    if(storedResult.login != ''){
      this.IsLoggedIn = true;
    }
    console.log("checkIfLoggedIn", storedResult.login);
  }
}
