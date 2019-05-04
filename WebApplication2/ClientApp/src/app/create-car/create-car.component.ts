import { Component } from '@angular/core';
import { CarService, VehicleTypeService, BodyTypeService } from '../shared/services';
import { Car, VehicleType } from '../shared/models';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-create-car',
  templateUrl: './create-car.component.html',
  styleUrls: ['./create-car.component.css']
})

export class CreateCarComponent {
  car: any = { };
  public VehicleTypes: VehicleType[];
  public BodyTypes: any[];

  constructor(private carService: CarService, private vehicleTypeService: VehicleTypeService, private bodyTypeService: BodyTypeService, private router: Router) {
    vehicleTypeService.getVehicleTypes().subscribe(result => {
      this.VehicleTypes = result;
    }, error => console.error(error));

    bodyTypeService.getBodyTypes().subscribe(result => {
      this.BodyTypes = result;
    }, error => console.error(error));
  }

  save(car: Car) {
    car.VehicleType = '1';
    this.carService.save(car).subscribe(r => {
      alert('data saved');
      this.router.navigate(['create-car']);
    }, e => console.error(e));
  }

}
