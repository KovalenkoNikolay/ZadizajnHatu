import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DesignStudio } from '../../shared/models/designstudio';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DesignstudioService {

  private _url: string = "http://localhost:51662/api/DesignStudio";
  public weatherForecast : DesignStudio;
public name : string;

  constructor(private http: HttpClient) { }

  getDesignStudio(): Observable<DesignStudio[]> {
    return this.http.get<DesignStudio[]>(this._url)
  }
}
