import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddDeptComponent } from './add-dept/add-dept.component';
import { UpdateDeptComponent } from './update-dept/update-dept.component';
import { DeleteDeptComponent } from './delete-dept/delete-dept.component';
import { ShowdeptComponent } from './showdept/showdept.component';

@NgModule({
  declarations: [
    AppComponent,
    AddDeptComponent,
    UpdateDeptComponent,
    DeleteDeptComponent,
    ShowdeptComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
