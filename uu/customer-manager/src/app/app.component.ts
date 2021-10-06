import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
  <div class="container">
    <div class="panel panel-default">
    <div class="panel-heading">
    <h1 [style.color]="nameColor" [class.isActive]="isActive">{{ customer.name.toUpperCase() }}</h1>
    </div>
    <div class="panel-body">
      <div class="row">
        <div class="col-sm-6">
          <p>{{ customer.description }}</p>
          <p>Wiek: {{ customer.age }}</p>
          <p>Adres: {{ customer.age }}</p>
        </div>
      </div>
    </div>
    </div>
  </div>
    
  `,
  styles: []
})
export class AppComponent {
  title = 'customer-manager';
}
