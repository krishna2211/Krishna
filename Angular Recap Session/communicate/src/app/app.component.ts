import { Component  } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'communicate';
  firstName: string;
lastName: string;
  
  ngOnInit(){
    this.firstName = 'John';
    console.log(this.firstName);
    this.lastName = 'Doe';
   }
}

