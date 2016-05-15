import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  directives:[],
  template: `
    <p>My First Angular 2 App jeejee{{name}}</p>
    <button (click)="updateMyName()">asd</button>`
})
export class AppComponent {
    public name: string = "jorma"
    
    updateMyName() {
        this.name = "pekka"
    }
}