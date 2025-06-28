import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { AuthClient } from '../../web-api-client';

@Component({
  selector: 'app-auth-callback',
  templateUrl: './auth-callback.component.html',
  styleUrls: ['./auth-callback.component.css']
})

export class AuthCallbackComponent {

    constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router,
    private authClient: AuthClient
  ) {}

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
    const code = params['code'];
    const error = params['error'];
    const errorDescription = params['error_description'];

    if (error) {
      // GitHub returned an error (e.g., user denied access)
      console.warn('GitHub Auth Error:', error, errorDescription);
      alert("GitHub login failed: " + decodeURIComponent(errorDescription || error));
      location.href = '/login'; // Redirect to login page
      return;
    }
    
    if (code) {

      this.authClient.getGitTokens(code).subscribe({
      next: result => {
        if(result.resultType == 1){
          console.log(result);
          localStorage.setItem('github_token', JSON.stringify(result.data));
          location.href = '/portal/my-dashboard';
        }else{
          alert("Something went wrong");
           location.href = '/login'; // Optional: redirect on token error
        }
      },
      error: error => {
          console.error(error);
          alert("An error occurred during token exchange.");
          location.href = '/login'; // Optional: redirect on API error
        }
    });

      // // Exchange code for token with backend
      // this.http.post<{ access_token: string }>('https://localhost:5001/auth/github/exchange', {
      //   code,
      //   redirectUri: 'https://localhost:44447/auth/callback'
      // }).subscribe({
      //   next: res => {
      //     localStorage.setItem('github_token', res.access_token);
      //     this.router.navigate(['/dashboard']);
      //   },
      //   error: err => {
      //     console.error('Token exchange failed', err);
      //   }
      // });
    }
  });
  }

}
