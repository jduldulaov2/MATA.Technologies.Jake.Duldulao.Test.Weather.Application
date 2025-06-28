import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SpinnerServiceService } from '../../Services/Shared/spinner-service.service';
import { AuthClient } from '../../web-api-client';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {

  local_url!: any;

  constructor(private loader: SpinnerServiceService, private authClient: AuthClient) {}

  ExternalSignOut(){

    const storedResult = JSON.parse(localStorage.getItem('github_token') || '{}');

    this.authClient.gitHubLogout(storedResult.access_token).subscribe({
      next: result => {
        localStorage.removeItem("github_token");
        localStorage.clear();
        location.href = '/login';
      },
      error: error => console.error(error)
    });
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
    localStorage.removeItem("github_token");
    this.authClient.logOut(id).subscribe({
      next: result => {
        if(result.resultType == 1){
          location.href = '/login';
        }
      },
      error: error => console.error(error)
    });
  }

}
