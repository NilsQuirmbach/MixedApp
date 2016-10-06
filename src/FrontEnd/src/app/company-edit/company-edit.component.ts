import { Component, OnInit, Input, Inject } from '@angular/core';
import { CompanyService, Company } from '../shared';
import { Observable } from 'rxjs/Observable';

@Component({
  selector: 'app-company-edit',
  templateUrl: './company-edit.component.html',
  styleUrls: ['./company-edit.component.css']
})
export class CompanyEditComponent implements OnInit {

    @Input() companyID: number;
    model: Company;

    isLoading: boolean;

    get isNew() {
        return this.companyID == undefined || this.companyID.toString() === 'new';
    }

    constructor( @Inject(CompanyService) private companyService: CompanyService) { }

    ngOnInit() {

        if (this.isNew) {
            this.model = new Company();
        } else {
            this.isLoading = true;

            this.companyService.getCompany(this.companyID).subscribe(data => {
                this.model = data;
                this.isLoading = false;
            });
        }
    }

    saveCompany() {
        console.log(this.model);
    }
}
