import { Injectable }  from '@angular/core';
import { Globals } from './globals';
 
@Injectable()
export class AppInitService {
 
    constructor() {
    }
    
    Init(globals: Globals) {
        return globals.initUser();
    }
}