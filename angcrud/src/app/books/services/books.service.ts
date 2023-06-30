import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Book } from '../models/book';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  private _url: string = 'http://localhost:3000'

  constructor(private http: HttpClient) { }

  getBooks() {
    return this.http.get<Book[]>(`${this._url}/books`)
  }

}
