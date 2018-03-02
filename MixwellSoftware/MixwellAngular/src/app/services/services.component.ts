import { Component, OnInit } from '@angular/core';
import { Service } from '../service';
import { Employee } from '../employee';
import { SERVICES } from '../mock-services';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})

export class ServicesComponent implements OnInit {
  services = SERVICES;

  constructor() { }

  ngOnInit() {
  }
  
}
