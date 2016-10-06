import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { Company } from './company';

@Injectable()
export class CompanyService {

    constructor( @Inject(Http) private http: Http) { }

    loadCompanies(): Observable<Company[]> {
        return this.http.get('api/company')
            .map(res => res.json());
    }

    getCompany(companyID: number): Observable<Company> {
        return this.http.get('api/company/' + companyID.toString())
            .map(res => res.json());
    }

    saveCompany(company: Company): Observable<boolean> {
        return this.http.post('api/company', company)
            .map(res => res.json());
    }

    deleteCompany(companyID: number): Observable<boolean> {
        return this.http.delete('api/company/' + companyID.toString())
            .map(res => res.json()); 
    }
}
