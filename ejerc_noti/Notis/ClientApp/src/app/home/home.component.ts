import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  featuredArticles = [
    { title: 'Artículo 1', description: 'Descripción del artículo 1', image: 'https://img.remediosdigitales.com/4b115d/verstappen-yas-marina-f1-2021/1366_2000.jpeg' },
    { title: 'Artículo 2', description: 'Descripción del artículo 2', image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmy1g_Z0eZTdHI1ggNU6Kmf4CTEIiGUeVw3w&s' },
    { title: 'Artículo 3', description: 'Descripción del artículo 3', image: 'https://media.revistagq.com/photos/61b7467075b0a617c031aa2e/16:9/w_2560%2Cc_limit/Verstappen%2520bandiera%2520Olanda.jpg' }
  ];
}
