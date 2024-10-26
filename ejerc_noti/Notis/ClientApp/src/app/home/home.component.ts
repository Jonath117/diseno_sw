import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  featuredArticles = [
    { title: 'Artículo 1', description: 'Descripción del artículo 1', image: 'https://via.placeholder.com/150' },
    { title: 'Artículo 2', description: 'Descripción del artículo 2', image: 'https://via.placeholder.com/150' },
    { title: 'Artículo 3', description: 'Descripción del artículo 3', image: 'https://via.placeholder.com/150' }
  ];
}
