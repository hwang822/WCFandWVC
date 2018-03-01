import { Component, OnInit } from '@angular/core';
import { Service } from '../service';
import { SERVICES } from '../mock-services';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {
  heroes = SERVICES;
	  
  constructor(private serviceService: ServiceService) { }

  ngOnInit() {this.getHeroes();}

  getHeroes(): void {
    this.serviceService.getHeroes()
    .subscribe(heroes => this.heroes = heroes);
  }

  
  selectedService: Service;
	 	
  onSelect(service: Service): void {
  this.selectedService = service;}  

  
  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.serviceService.addHero({ name } as Service)
      .subscribe(hero => {
        this.heroes.push(hero);
      }
	);
  }
  delete(service: Service): void {
    this.heroes = this.heroes.filter(h => h !== service);
    this.serviceService.deleteHero(service).subscribe();
  }  
}
