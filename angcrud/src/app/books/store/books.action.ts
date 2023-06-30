import { createAction, props } from "@ngrx/store";
import { Book } from "../models/book";

export const GetBooksAction = createAction(
    '[Books] Get books'
)

export const GetBooksSuccessAction = createAction(
    '[Books] Get books success',
    props<{
        booksres: Book[]
    }>()
)