import { Component } from "@angular/core";

@Component({
    selector: 'heroes-list-component',
    templateUrl: './index.component.html',
    styleUrls: ['./index.component.scss']
})
export class HeroesListIndexComponent{
    public test: string = "funcionou";
}