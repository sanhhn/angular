import { Component, OnInit } from '@angular/core';
import { QuoteService } from '../../services/quote.service';
import { QuoteModel } from '../../models/quote.model';

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.scss']
})
export class QuotesComponent implements OnInit {

  public quoteList: QuoteModel[] = [];
  public quoteText: string | null = null;

  strt = ""

  constructor(private service: QuoteService) { }

  ngOnInit() {
    this.quoteList = this.service.getQuote();
    this.strt = `abc
    def
    ghi`
  }

  createNewQuote() {
    this.service.addNewQuote(this.quoteText);
    this.quoteText = null;
  }

  removeQuote(index: number) {
    this.service.removeQuote(index);
  }
}