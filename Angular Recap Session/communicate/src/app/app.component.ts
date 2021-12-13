import { Component  } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'communicate';
  fname: string;
lname: string;
  
  ngOnInit(){
    this.fname = 'John';
    console.log(this.fname);
    this.lname = 'Doe';
   }
}

