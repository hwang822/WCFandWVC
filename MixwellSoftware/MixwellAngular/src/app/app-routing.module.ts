import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DashboardComponent }   from './dashboard/dashboard.component';
import { EmployeesComponent }   from './employees/employees.component';
import { EmployeeDetailComponent }  from './employee-detail/employee-detail.component';
import { ServicesComponent }   from './services/services.component';
import { ServiceDetailComponent }  from './service-detail/service-detail.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: '', redirectTo: '/employees', pathMatch: 'full' },
  { path: '', redirectTo: '/services', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'detail/:id', component: EmployeeDetailComponent },
  //{ path: 'detail/:id', component: ServiceDetailComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'services', component: ServicesComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
