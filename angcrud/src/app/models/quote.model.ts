export class QuoteModel
{
    constructor (text: string | null, timeCreated: string){
        this.text = text
        this.timeCreated = timeCreated
    }
    text: string | null = ''
    timeCreated: string = ''
}