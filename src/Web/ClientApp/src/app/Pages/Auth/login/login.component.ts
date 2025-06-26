import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SpinnerServiceService } from '../../../Services/Shared/spinner-service.service';
import { AuthClient } from '../../../web-api-client';
declare var $: any;

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  constructor(private loader: SpinnerServiceService, private authClient: AuthClient, private router: Router, private route: ActivatedRoute) {}

  txtUserName: string = "";
  txtPassword: string = "";

  ngOnInit(){
    this.checkIfLoggedIn();
  }
  
  //Need to put to service
  checkIfLoggedIn(){
    const storedResult = JSON.parse(localStorage.getItem('github_token') || '{}');
    if (typeof storedResult.login === 'undefined') {
    }else{
      if(storedResult.login != ''){
      location.href = '/portal/my-dashboard';
    }
    }
  }

  Authorize(username: string, password: string){
    $('#alertmobile').css('display', 'none');
    this.authClient.login(username, password, false, false).subscribe({
      next: result => {
        if(result.resultType == 1){
          location.href = '/portal/my-dashboard';
        }else{
          $("#alert").show();
          $('#alertmobile').css('display', 'block');
        }
      },
      error: error => console.error(error)
    });
  }

  AuthorizeTemp(username: string, password: string){
    $("#alert").show();
    $('#alertmobile').css('display', 'block');
  }

  RedirectToGitHub(){
    const clientId = 'Ov23liaWF3wQPaLy03zB';
    const redirectUri = encodeURIComponent('https://localhost:44447/auth/callback');
    const scope = 'read:user user:email';

    window.location.href = 
  `https://github.com/login/oauth/authorize?client_id=${clientId}&redirect_uri=${redirectUri}&scope=${scope}&allow_signup=true`;

  }

  DetectLoggedIn(){
    this.authClient.geLoggedIn().subscribe({
      next: result => {
        if(result.message == 'Logged in user detected'){
          location.href = '/portal/my-dashboard';
        }
      },
      error: error => console.error(error)
    });
  }

}
