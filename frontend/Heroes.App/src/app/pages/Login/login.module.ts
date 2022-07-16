import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { LoginIndexComponent } from "./Index/index.component";
import { LoginRouter } from "./login-router.module";

@NgModule({
    declarations: [
        LoginIndexComponent
    ],
    imports: [LoginRouter, FormsModule, ReactiveFormsModule],
    exports: []
})
export class LoginModule{}