import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { DesignStudio } from '../../shared/models/designstudio';
import { Observable } from 'rxjs';
import { DesignStudioPortfolio } from 'src/app/shared/models/design-studio-portfolio';

@Injectable({
  providedIn: 'root'
})
export class DesignstudioService {

  private _url: string = "http://localhost:51662/api/DesignStudio/";
  public weatherForecast : DesignStudio;
  public name : string;

  constructor(private http: HttpClient) { }

  getDesignStudios(fromAmount : number, toAmount : number, name : string): Observable<DesignStudio[]> {
    let params = new HttpParams();
    if (fromAmount != null){
      params = params.set("fromAmount", String(fromAmount))
    }
    if (toAmount != null){
      params = params.set("toAmount", String(toAmount))
    }
    if (name != null){
      params = params.set("name", name)
    }
    return this.http.get<DesignStudio[]>(this._url, {params : params})
  }

  getDesignStudioById(id : string): Observable<DesignStudio> {
    return this.http.get<DesignStudio>(this._url + id);
  }

  getPortfoliosByDesignStudioId(id : string): Observable<DesignStudioPortfolio[]> {
    return this.http.get<DesignStudioPortfolio[]>(this._url + id + "/portfolios");
  }
}
