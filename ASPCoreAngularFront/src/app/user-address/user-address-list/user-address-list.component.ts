import { Component, OnInit } from '@angular/core';
import { UserAddressService } from '../../shared/user-address.service';
import { UserAddress } from '../../shared/user-address.model';

@Component({
  selector: 'user-address-list',
  templateUrl: './user-address-list.component.html',
  styleUrls: ['./user-address-list.component.css']
})
export class UserAddressListComponent implements OnInit {

  constructor(private service: UserAddressService) { }

  ngOnInit() {
    this.service.GetAddresses();
  }

  EditAddress(data: UserAddress){
    this.service.formData = data;
  }

  DeleteAddress(id: number){
    if(confirm("Are you sure you want to delete this item?")){
    this.service.DeleteForm(id).subscribe(
      res => {
        this.service.GetAddresses();
      },
      err => {
        console.log(err);
      }
    );
  }
  }
  
}
