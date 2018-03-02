import { Component, OnInit } from '@angular/core';

import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
//  heroes: Employee[];
  employees: Employee[] = [];

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.getEmployees();
  }

  getEmployees(): void {
    this.employeeService.getEmployees()
    .subscribe(employees => this.employees = employees);
  }

  add(name: string): void {
    name = name.trim();
//    if (!name) { return; }
//    this.employeeService.addHero({ name } as Employee)
//      .subscribe(hero => {
//        this.employeeService.push(hero);
//      });
  }

  delete(hero: Employee): void {
//    this.employeeService = this.employeeService.filter(h => h !== hero);
//    this.employeeService.deleteHero(hero).subscribe();
  }

}
