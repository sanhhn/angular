import {FormGroup} from '@angular/forms';

export class GenericValidator {

    constructor(private validationMessages: { [key: string]: { [key: string]: string } }) {}  

    processMessages(container: FormGroup):{ [key: string]: string} {
        const message = {};

        for(const controlKey in container.controls){
            if(container.controls.hasOwnProperty(controlKey)){
                const c = container.controls[controlKey];
                if(c instanceof FormGroup){
                    const childMessages = this.processMessages(c);
                    
                    Object.assign(message, childMessages);
                }else{
                    if(this.validationMessages[controlKey]){
                        message[controlKey] = '';
                        if((c.dirty || c.touched) && c.errors){
                            Object.keys(c.errors).map(message => {
                                if(this.validationMessages[controlKey][message]){
                                    message[controlKey] += this.validationMessages[controlKey][message] + ' ';
                                }
                            })
                        }
                    }
                }
            }
        }

        return message;
    }
      
}
