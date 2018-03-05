import { Component, OnInit } from '@angular/core';
import { Service } from '../service';
import { Employee } from '../employee';
import { DataService } from '../data.service';



@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})

export class ServicesComponent implements OnInit {

  services: Service[]; 

  selectedService: Service;
  constructor(private serviceService: DataService) {}

  ngOnInit() {
    this.getServices();
  }

  
  getServices(): void {
	this.services = this.serviceService.getServices();
  }
  
  onSelect(service: Service): void {
    this.selectedService = service;
  }  
}
