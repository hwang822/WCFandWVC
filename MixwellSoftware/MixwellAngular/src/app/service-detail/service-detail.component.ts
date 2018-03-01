import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Service }         from '../service';
import { EmployeeService }  from '../employee.service';

@Component({
  selector: 'app-service-detail',
  templateUrl: './service-detail.component.html',
  styleUrls: [ './service-detail.component.css' ]
})
export class ServiceDetailComponent implements OnInit {
  @Input() service: Service;

  constructor(
    private route: ActivatedRoute,
    private heroService: EmployeeService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getService();
  }

  getService(): void {
//    const id = +this.route.snapshot.paramMap.get('id');
//    this.heroService.getHero(id)
//      .subscribe(hero => this.hero = hero);
  }

  goBack(): void {
    this.location.back();
  }

 save(): void {
  //  this.heroService.updateHero(this.hero)
//      .subscribe(() => this.goBack());
  }
}
