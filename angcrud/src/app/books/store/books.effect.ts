import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { Store } from "@ngrx/store";
import { catchError, EMPTY, map, mergeMap, of, switchMap } from "rxjs";
import { Book } from "../models/book";
import { BooksService } from "../services/books.service";
import { GetBooksAction, GetBooksSuccessAction } from "./books.action";

@Injectable()
export class BooksEffect {
    constructor(
        private actions$: Actions,
        private service: BooksService,
        private store: Store
    ){}

    getBooks$ = createEffect(() => this.actions$.pipe(
        ofType(GetBooksAction),
        switchMap(() => this.service.getBooks()
            //.pipe(map((res) => GetBooksSuccessAction({booksres: res})))
            .pipe(
                map((res) => {
                    console.log('check s r1: ', res)
                    return GetBooksSuccessAction({booksres: res})
                })
                // mergeMap((res) => {
                //     console.log('check s r1: ', res)
                //     return [GetBooksSuccessAction({booksres: res})]
                // })
                , catchError(() => EMPTY)
            )
        )
    ))
}
