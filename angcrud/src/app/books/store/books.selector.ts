import { createFeatureSelector, createSelector } from "@ngrx/store";
import { BooksState } from "./books.reducer";

export const selectBooksState = createFeatureSelector<BooksState>('statebooks')

export const selectBooks = createSelector(
    selectBooksState,
    (state: BooksState) => state.books
)