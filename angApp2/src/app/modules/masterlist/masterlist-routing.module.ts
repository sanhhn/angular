import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import { MasterListComponent } from './masterlist.component';

const routes: Routes = [
  {path: '', component: MasterListComponent},
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})

export class MasterListRoutingModule {
}
