import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterListComponent } from './masterlist.component';
import { MasterListRoutingModule } from './masterlist-routing.module';

@NgModule({
  declarations: [MasterListComponent],
  imports: [
    CommonModule,
    MasterListRoutingModule
  ]
})
export class MasterListModule { }
