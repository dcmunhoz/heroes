import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    selector: 'heroes-list-component',
    templateUrl: './index.component.html',
    styleUrls: ['./index.component.scss']
})
export class HeroesListIndexComponent{
    
    public heroes: Array<any> = [
        { id: 1, name: 'Atrox', power: 10, defense: 30 },
        { id: 2, name: 'Yasuo', power: 40, defense: 10 },
        { id: 3, name: 'Yone', power: 35, defense: 15 }
    ];

    constructor( 
        private _router: Router
     ){}


    public onClick(): void{
        this._router.navigate(['/hero']);
    }

}