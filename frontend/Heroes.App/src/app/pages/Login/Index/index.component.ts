import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    selector: 'index-component',
    templateUrl: './index.component.html',
    styleUrls: ['./index.component.scss']
})
export class LoginIndexComponent{
    public username: string = "teste";
    public password: string = "1234";

    constructor(
        public _router: Router
    ){}

    public onSubmit(): void{
        this._router.navigate(['/heroes'])
    }


}