import { Component } from '@angular/core';
import { HighlightDirective } from './highLight.directive'

@Component({
  selector: 'my-app',
  directives:[HighlightDirective],
  template: `
    <p [myHighlight]="color">My First Angular 2 App jeejee{{name}}</p>
    <button (click)="updateMyName()">asd</button>`
})
export class AppComponent {
    public name: string = "jorma"
    
    updateMyName() {
        this.name = "pekka"
    }
}