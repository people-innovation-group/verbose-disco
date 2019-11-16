import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Org } from 'src/app/interfaces/org';

@Injectable({
  providedIn: 'root'
})
export class CommonService {

  private readonly getOrgURI = 'api/Common/GetOrg';
  private readonly getOrgByIdURI = 'api/Common/GetOrg/';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  /**
   * Get All Organizations
   */
  getOrgs(): Observable<Org[]> {
    return this.http.get<Org[]>(this.baseUrl + this.getOrgURI);
  }

  /**
   * Get Specific Organization
   * @param id 
   */
  getOrgById(id: number): Observable<Org> {
    return this.http.get<Org>(this.baseUrl + this.getOrgByIdURI + id);
  }

}
