import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { AdminPortalComponent } from '../../MasterPage/admin-portal/admin-portal.component';
import { BlankPageComponent } from '../../Pages/WeatherPortal/blank-page/blank-page.component';
import { UserListComponent } from '../../Pages/WeatherPortal/user-list/user-list.component';
import { UserDetailsComponent } from '../../Pages/WeatherPortal/user-details/user-details.component';
import { UserDetailItemComponent } from '../../Pages/WeatherPortal/user-detail-item/user-detail-item.component';
import { DashboardComponent } from '../../Pages/WeatherPortal/dashboard/dashboard.component';

const routes: Routes = [
  {
    path: 'portal/my-dashboard',
    component: DashboardComponent
  },
  {
    path: 'portal/blank-page',
    component: BlankPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AdminAppRoutingModule { }
