import { Component, OnInit, OnDestroy } from '@angular/core';
import {select, Store} from '@ngrx/store';

@Component({
  selector: 'app-masterlist',
  templateUrl: './masterlist.component.html'
})
export class MasterListComponent implements OnInit, OnDestroy {

  gridColumns: any = [];
  constructor() { }

  ngOnInit() {
  }

  ngOnDestroy(): void {
  }

}
