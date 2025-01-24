import { Routes } from "@angular/router";
import { AppComponent } from "./app.component";
import { HomeComponent } from "../home/home.component";
import { BookListComponent } from "../book_list.component.ts/book_list.component";

export const routes: Routes = [
    {
        path: '',
        title: 'App Home Page',
        component: HomeComponent,
    },
    {
        path: 'bookPage',
        title: 'PintasPage',
        component: BookListComponent,
    },

];

