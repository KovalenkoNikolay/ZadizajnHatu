import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
 getStringFromApi()
 {
   return 'Hello world! (mock)'
 }
  constructor() { }
}
