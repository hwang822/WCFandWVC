import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Employee }         from '../employee';
import { EmployeeService }  from '../employee.service';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: [ './employee-detail.component.css' ]
})
export class EmployeeDetailComponent implements OnInit {
  @Input() hero: Employee;

  constructor(
    private route: ActivatedRoute,
    private heroService: EmployeeService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.heroService.getEmployee(id)
      .subscribe(hero => this.hero = hero);
  }

  goBack(): void {
    this.location.back();
  }

 save(): void {
    this.heroService.updateHero(this.hero)
      .subscribe(() => this.goBack());
  }
}
