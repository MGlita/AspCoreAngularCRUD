import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { UserAddressComponent } from './user-address/user-address.component';
import { UserAddressListComponent } from './user-address/user-address-list/user-address-list.component';
import { UserAddressFormComponent } from './user-address/user-address-form/user-address-form.component';
import { UserAddressService } from './shared/user-address.service';

@NgModule({
  declarations: [
    AppComponent,
    UserAddressComponent,
    UserAddressFormComponent,
    UserAddressListComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [UserAddressService],
  bootstrap: [AppComponent]
})
export class AppModule { }
