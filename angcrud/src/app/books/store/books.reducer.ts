import { Action, createReducer, on } from "@ngrx/store";
import { Book } from "../models/book";
import { GetBooksSuccessAction } from "./books.action";

export interface BooksState {
    books: Book[]
}

export const initialState: BooksState = {
    books: []
}

export const booksReducer = createReducer (
    initialState,
    on(
        GetBooksSuccessAction,
        (state: BooksState, {booksres}) => (
            {
                ...state,
                books: booksres
            }
        )
    )
)

export function reducer(state: BooksState | undefined, action: Action): any {
    return booksReducer(state, action)
}
