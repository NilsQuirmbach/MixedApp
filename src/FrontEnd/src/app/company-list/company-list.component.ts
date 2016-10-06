import { Component, Inject, OnInit } from '@angular/core';
import { CompanyService, Company } from '../shared';

@Component({
  selector: 'app-company-list',
  templateUrl: './company-list.component.html',
  styleUrls: ['./company-list.component.css']
})
export class CompanyListComponent implements OnInit {

    companies: Array<Company> = [];

    constructor( @Inject(CompanyService) private companyService: CompanyService) { }

    ngOnInit() {
        this.companyService.loadCompanies().subscribe(data => this.companies = data);
    }

}
