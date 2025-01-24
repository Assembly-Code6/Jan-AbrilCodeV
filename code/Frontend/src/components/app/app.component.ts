import { Component } from '@angular/core';
import { RouterLink, RouterOutlet, RouterModule } from '@angular/router';


@Component({
  standalone: true,
  selector: 'app-root',
  template: `
    <nav>
      <a routerLink="/">Home</a>
      <br>
      <a routerLink="/bookPage">BookPage</a>
    </nav>
    <router-outlet></router-outlet>
  `,
  imports: [RouterOutlet,RouterLink],
  
})
export class AppComponent {}
