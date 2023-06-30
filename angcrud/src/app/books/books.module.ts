import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BooksRoutingModule } from './books-routing.module';
import { BookHomeComponent } from './components/book-home/book-home.component';
import { StoreModule } from '@ngrx/store';
import { reducer } from './store/books.reducer';
import { EffectsModule } from '@ngrx/effects';
import { BooksEffect } from './store/books.effect';


@NgModule({
  declarations: [
    BookHomeComponent
  ],
  imports: [
    CommonModule,
    BooksRoutingModule,
    StoreModule.forFeature('statebooks', reducer),
    EffectsModule.forFeature([BooksEffect])
  ]
})
export class BooksModule { }
