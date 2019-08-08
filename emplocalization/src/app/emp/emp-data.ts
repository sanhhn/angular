import {InMemoryDbService} from 'angular-in-memory-web-api';
import {Employee} from './employee';

export class EmpData implements InMemoryDbService {
    createDb(){
        const employees: Employee[] = [
            {  
                'id': '496f04a0-5c6d-400f-a0a8-0929088dc41e',  
                'name': 'Sarath Lal',  
                'address': 'Kakkanad',  
                'gender': 'Male',  
                'company': 'Orion Business Innovation',  
                'designation': 'Technical Lead'  
            },  
            {  
                'id': '03810397-381c-4b9d-85f6-d7c87622e518',  
                'name': 'Baiju Mathew',  
                'address': 'Kakkanad',  
                'gender': 'Male',  
                'company': 'Orion Business Innovation',  
                'designation': 'Project Manager'  
            }  
        ];

        return { employees};
    }
}
