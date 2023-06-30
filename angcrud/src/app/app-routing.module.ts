import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { QuotesComponent } from './components/quotes/quotes.component';

const routes: Routes = [
  {
    path:'',
    component: QuotesComponent
  },
  {
    path:'books',
    loadChildren: () =>
      import('./books/books.module').then((b) => b.BooksModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
