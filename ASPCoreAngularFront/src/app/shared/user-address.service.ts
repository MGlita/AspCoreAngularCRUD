import { Injectable } from '@angular/core';
import { UserAddress } from './user-address.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserAddressService {
  formData: UserAddress;
  list: UserAddress[];
  rootUrl: string = "http://localhost:62977/api";
  constructor(private http: HttpClient) { }

  PostForm(formData: UserAddress){
    return this.http.post(this.rootUrl + '/UserAddresses', formData);
  }

  PutForm(id: number, formData: UserAddress){
    return this.http.put(this.rootUrl + '/UserAddresses/' + id, formData);
  }

  DeleteForm(id: number){
    return this.http.delete(this.rootUrl + '/UserAddresses/' + id);
  }

  GetAddresses(){
    this.http.get(this.rootUrl + '/UserAddresses')
    .toPromise()
    .then(res => this.list = res as UserAddress[]);
  }

}
