import { NgModule } from "@angular/core";
import { IndexComponent } from "./Index/index.component";
import { LoginRouter } from "./login-router.module";

@NgModule({
    declarations: [
        IndexComponent
    ],
    imports: [LoginRouter],
    exports: []
})
export class LoginModule{}