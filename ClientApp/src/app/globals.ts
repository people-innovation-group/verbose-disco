import { Injectable } from '@angular/core';
import { Observable, of, from } from 'rxjs';
import { CommonService } from './services/common.service';
import { Org } from './interfaces/org';
//import { MatTableDataSource, MatSort, MatPaginator, MatSnackBar } from '@angular/material';
//import { SelectionModel } from '@angular/cdk/collections';

@Injectable()
export class Globals {
    public organization: Org;

    //Constants
    jsDateFormat = 'YYYY-MM-DDTHH:mm:ss';

    constructor(private commonService: CommonService) {

    }

    initUser(): Promise<void> {

        const getOrg = this.commonService.getOrg().toPromise();

        const all = Promise.all([getOrg]).then(result => {
            this.organization = result[0];
            console.log(this.organization);
        });
        return all;
    }

}
