import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HighchartsChartModule } from 'highcharts-angular';
import { LoginComponent } from './Pages/Auth/login/login.component'
import { PreLoaderComponent } from './Shared/pre-loader/pre-loader.component';
import { SidebarComponent } from './Shared/sidebar/sidebar.component';
import { HeaderComponent } from './Shared/header/header.component';
import { FooterComponent } from './Shared/footer/footer.component';
import { AdminAppRoutingModule } from './MasterPage/admin-portal/admin-app-routing.module';
import { AdminPortalComponent } from './MasterPage/admin-portal/admin-portal.component';
import { DefaultPortalComponent } from './MasterPage/default-portal/default-portal.component';
import { DefaultAppRoutingModule } from './MasterPage/default-portal/default-app-routing.module';
import { UserListComponent } from './Pages/WeatherPortal/user-list/user-list.component';
import { BlankPageComponent } from './Pages/WeatherPortal/blank-page/blank-page.component';
import { UserDetailsComponent } from './Pages/WeatherPortal/user-details/user-details.component';
import { UserDetailItemComponent } from './Pages/WeatherPortal/user-detail-item/user-detail-item.component';
import { SpinnerComponent } from './Shared/spinner/spinner.component';
import { DashboardComponent } from './Pages/WeatherPortal/dashboard/dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LoginComponent,
    PreLoaderComponent,
    SidebarComponent,
    HeaderComponent,
    FooterComponent,
    AdminPortalComponent,
    DefaultPortalComponent,
    UserListComponent,
    BlankPageComponent,
    UserDetailsComponent,
    UserDetailItemComponent,
    SpinnerComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    HighchartsChartModule,
    BrowserAnimationsModule,
    ModalModule.forRoot(),
    AdminAppRoutingModule,
    DefaultAppRoutingModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
