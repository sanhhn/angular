import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {AccountListComponent } from './account-list/account-list.component';
import {AccountCreateComponent } from './account-create/account-create.component';
import {ActivityListComponent } from './activity-list/activity-list.component';
import {ActivityCreateComponent} from './activity-create/activity-create.component';
import {ContactListComponent} from './contact-list/contact-list.component';
import {ContactCreateComponent} from './contact-create/contact-create.component'

const routes: Routes = [
  {
    path: '', redirectTo: 'contratcs', pathMatch: 'full'
  },
  {
    path: 'acounts', component: AccountListComponent
  },
  {
    path: 'acount-create', component: AccountCreateComponent
  },
  {
    path: 'contracts', component: ContactListComponent
  },
  {
    path: 'contract-create', component: ContactCreateComponent
  },
  {
    path: 'activities', component: ActivityListComponent
  },
  {
    path: 'activity-create', component: ActivityCreateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
