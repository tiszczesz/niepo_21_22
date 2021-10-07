import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
  <h1 [style.color]="nameColor" [class.isActive]="isActive">{{ name.toUpperCase() }}</h1>
  <img [src]="photoURL" alt="">
  `,
  styles: [
    '.isActive {text-decoration: underline;}'
  ]
})
export class AppComponent {
  name: string = "Jan Kowalski";
  photoURL: string = "assets/images/customer.png";
  nameColor: string = "blue";
  isActive: boolean = true;

  constructor(){
    setTimeout(()=>{
      this.name = "Wojciech";
    },3000);
  }
}
