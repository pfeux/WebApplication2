import { Injectable } from '@angular/core';

export class Car {
  VehicleID: number;
  VehicleType: string;
  Make: string;
  Model: string;
  Engine: string;
  Doors: number;
  Wheels: number;
  BodyType: string;
}

export interface VehicleType {
  ID: number;
  Type: string;
}

export interface BodyType {
  ID: number;
  Type: string;
}
