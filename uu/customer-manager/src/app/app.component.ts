import { Component } from "@angular/core";

import { Customer } from "./model";

@Component({
  selector: "app-root",
  template: `
    <div class="container">
      <div class="panel panel-default">
        <div class="panel-heading">
          <h1 [style.color]="nameColor" [class.isActive]="isActive">
            {{ customer.name.toUpperCase() }}
          </h1>
        </div>
        <div class="panel-body">
          <div class="row">
            <div class="col-sm-8">
              <p>{{ customer.description }}</p>
              <p>Wiek: {{ customer.age }}</p>
              <p>
                Adres {{ customer.address.street }},
                {{ customer.address.houseNumber }},
                {{ customer.address.city }}
              </p>
              <button
                (click)="isActive = !isActive"
                type="button"
                class="btn btn-primary"
              >
                Przełącz podkreślenie
              </button>

              <button
                (click)="changeColor()"
                type="button"
                class="btn btn-primary"
              >
                Przełącz kolor
              </button> 
            </div>
            <div class="col-sm-4">
              <img [src]="customer.photoUrl" alt="" />
            </div>
          </div>
        </div>
      </div>
      <!-- <input type="text" [value]="name" (input)="name=getValue($event)"> -->
      <!-- <input type="text" [(ngModel)]="customer.name" /> -->
    </div>
  `,
  styles: [".isActive {text-decoration: underline;}"],
})
export class AppComponent {
  customer: Customer = {
    name: "Jan Kowalski",
    photoUrl: "assets/images/customer.png",
    description: "very important client",
    age: 34,
    address: {
      street: "Zielona",
      houseNumber: 5,
      city: "Warszawa",
    },
  };

  nameColor: string = "blue";
  isActive: boolean = true;

  constructor() {
    setTimeout(() => {
      this.customer.name = "Wojciech";
    }, 3000);
  }
  changeColor() {
    this.nameColor = this.nameColor === "blue" ? "red" : "blue";
  }
  // getValue(event:Event): string {
  //   return(event.target as HTMLInputElement).value;
  // }
}
