import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonService } from '../services/common.service';
import { Org } from '../interfaces/org';
import { forkJoin, Subscription } from 'rxjs';
import { Globals } from '../globals';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, OnDestroy {
  subs: Subscription;
  isLoading: boolean = true;
  isQuerying: boolean = false;
  schools: Org[];
  //currentOrgId: number;

  constructor(
    public commonService: CommonService,
    public globals: Globals
  )
  {
    //this.currentOrgId = globals.current_organization.id;
    forkJoin(commonService.getOrgs()).subscribe(([result]) => {
      this.schools = result;
      this.isLoading = false;
      console.log(globals.current_organization.id);
    });
  }

  changeSchool(orgId: number)
  {
    this.isQuerying = true;
    forkJoin(this.commonService.getOrgById(orgId)).subscribe(([result]) => {
      this.globals.changeOrg(result);
      this.isQuerying = false;
    });
  }
  ngOnInit() {
  
  }
  ngOnDestroy() {

  }
}
