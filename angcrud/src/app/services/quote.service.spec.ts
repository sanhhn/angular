import { QuoteService } from "./quote.service";

describe('QuoteService', () =>{
    let service: QuoteService

    beforeEach(() => {
        service = new QuoteService()
    })

    it('should create quote', () => {
        const quote = 'This is a quote'
        service.addNewQuote(quote)
        expect(service.quoteList.length).toBeGreaterThanOrEqual(1)
    })

    it('shoult remove quote', () => {
        service.addNewQuote('add to remove')
        service.removeQuote(0)

        expect(service.quoteList.length).toBeLessThan(1)
    })
})
