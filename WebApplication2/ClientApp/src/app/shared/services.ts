import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Car, VehicleType, BodyType } from './models';
import { Observable } from 'rxjs';
import { RequestOptions } from '@angular/http';

@Injectable()
export class CarService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  save(car: Car): Observable<any> {
    var headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
    return this.http.post(this.baseUrl + 'api/Vehicle/CarInsert', JSON.stringify(car), {headers: headers});
  }
}

@Injectable()
export class VehicleTypeService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  getVehicleTypes(): Observable<any> {
    return this.http.get<VehicleType[]>(this.baseUrl + 'api/Vehicle/GetVehicleType');
  }
}

@Injectable()
export class BodyTypeService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  getBodyTypes(): Observable<any> {
    return this.http.get<BodyType[]>(this.baseUrl + 'api/Vehicle/GetBodyType');
  }
}
