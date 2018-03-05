import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';

import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService }  from './in-memory-data.service';

import { AppRoutingModule }     from './app-routing.module';

import { AppComponent }         from './app.component';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { EmployeeDetailComponent }  from './employee-detail/employee-detail.component';
import { EmployeesComponent }      from './employees/employees.component';
import { EmployeeSearchComponent }  from './employee-search/employee-search.component';
import { EmployeeService }          from './employee.service';
import { MessageService }       from './message.service';
import { MessagesComponent }    from './messages/messages.component';
import { ServicesComponent } from './services/services.component';
import { ServiceDetailComponent }  from './service-detail/service-detail.component';
import { ServiceService }          from './service.service';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,

    // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
    // and returns simulated server responses.
    // Remove it when a real server is ready to receive requests.
    HttpClientInMemoryWebApiModule.forRoot(
      InMemoryDataService, { dataEncapsulation: false }
    )
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    EmployeesComponent,
    EmployeeDetailComponent,
    MessagesComponent,
    EmployeeSearchComponent,
    ServicesComponent,
	ServiceDetailComponent
  ],
  providers: [ EmployeeService, MessageService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
