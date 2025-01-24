import { Component, NgModule } from '@angular/core';
import {  BookCardComponent } from '../bookCard/book_card.component';
import { Book } from 'src/model/Book';
import { BrowserModule } from '@angular/platform-browser'
import { CommonModule } from '@angular/common';


@Component({
  standalone: true,
  selector: 'book-list',
  template: `
  <div class="container">
    <p>Pintas book</p>
    <book-card *ngFor="let book of bookList;" [book]="book"/>
  </div>
  `,
  imports: [BookCardComponent,CommonModule],
  styleUrls: ['./book_list.component.css'],
  
})
export class BookListComponent {
  title = 'homes';
  bookList: Book[] = [
      {id:1,nome:"O pintas ainda nao tinha nascido"},
      {id:2,nome:"O pintas tem depressao",imagem:"https://bettervet.com/hs-fs/hubfs/sad-and-depressed-dog-with-tears.jpg?width=734&height=413&name=sad-and-depressed-dog-with-tears.jpg",preco:3.50},
      {id:3,nome:"O pintas tomou Ansiolítico",imagem:"https://plus.unsplash.com/premium_photo-1694819488591-a43907d1c5cc?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8Y3V0ZSUyMGRvZ3xlbnwwfHwwfHx8MA%3D%3D",preco:32.50},
      {id:4,nome:"O pintas inalou um baseado",imagem:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTufhEXstXXpYDFAnZSx6AYJlxvSyFfxoVlKQ&s",preco:22.50},
      {id:5},
      {id:6},
      {id:7},
      {id:8},
      {id:9},
      {id:10},
  ]
}


