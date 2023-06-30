import { Component, OnDestroy, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { filter, Subject, takeUntil } from 'rxjs';
import { BooksService } from '../../services/books.service';
import { GetBooksAction } from '../../store/books.action';
import { selectBooks } from '../../store/books.selector';

@Component({
  selector: 'app-book-home',
  templateUrl: './book-home.component.html',
  styleUrls: ['./book-home.component.scss']
})
export class BookHomeComponent implements OnInit, OnDestroy {

  private unsubscribe$ = new Subject<void>();
  //books$: Observable<Books[]>;

  constructor(private store: Store, private service: BooksService) { }

  ngOnInit(): void {
    type StringOrNumber = string | number;
    // this.service.getBooks()
    // .pipe(
    //   takeUntil(this.unsubscribe$)      
    // )
    // .subscribe((res) => {
    //   console.log('check s: ', res)
    // })

    // this.books$ = this.store.pipe(select(selectBooks));
    //html: <li *ngFor="let book of books$ | async">

    this.store.dispatch(GetBooksAction())
    this.store.pipe(
      select(selectBooks),
      filter((res) => !!res), // && res.length > 0),
      takeUntil(this.unsubscribe$)
    )
    .subscribe((res) => {
      console.log('check st: ', res)      
    })
  }

  ngOnDestroy(): void {
    this.unsubscribe$.next()
    this.unsubscribe$.complete()
  }

}
