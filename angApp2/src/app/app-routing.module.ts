import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '', redirectTo: 'masterlist', pathMatch: 'full'
  },
  {path: 'masterlist', loadChildren: () => import('./modules/masterlist/masterlist.module').then(m => m.MasterListModule)},
  // {
  //   path: 'acounts', component: AccountListComponent
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
