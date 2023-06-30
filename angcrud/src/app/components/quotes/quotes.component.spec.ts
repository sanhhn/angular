import { TestBed } from "@angular/core/testing"
import { FormsModule } from "@angular/forms"
import { QuotesComponent } from "./quotes.component"

describe('QuotesComponent', () => {
    beforeEach(()=> {
        TestBed.configureTestingModule({
            declarations: [QuotesComponent],
            imports:[FormsModule]
        }).compileComponents()
    })

    it('should create the quote', () => {
        const fixture = TestBed.createComponent(QuotesComponent)
        const app = fixture.componentInstance
        expect(app).toBeTruthy()
    })
})