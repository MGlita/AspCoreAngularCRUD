import { Component, OnInit } from '@angular/core';
import { UserAddressService } from '../../shared/user-address.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'user-address-form',
  templateUrl: './user-address-form.component.html',
  styleUrls: ['./user-address-form.component.css']
})
export class UserAddressFormComponent implements OnInit {

  constructor(private service: UserAddressService) { }

  ngOnInit() {
    this.service.formData = {
      UserId: 0,
      FullName: '',
      City: '',
      ZipCode: '',
      Street: '',
    }
  }

  onSubmit(formData: NgForm){
    if(formData.value.UserId==0){
      this.service.PostForm(formData.value).subscribe(
        res => {
          formData.resetForm();
          this.service.GetAddresses();
        },
        err => {
          console.log(err);
        }
      );
    }
    if(formData.value.UserId!=0){
      this.service.PutForm(formData.value.UserId, formData.value).subscribe(
        res => {
          formData.resetForm();
          this.service.GetAddresses();
        },
        err => {
          console.log(err);
        }
      )
    }
  }


}
