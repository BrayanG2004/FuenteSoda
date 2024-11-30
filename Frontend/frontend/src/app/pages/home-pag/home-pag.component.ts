import { Component } from '@angular/core';
import { MenuComponent } from '../../components/menu/menu.component';

@Component({
  selector: 'fnd-home-pag',
  standalone: true,
  imports: [MenuComponent],
  templateUrl: './home-pag.component.html',
  styleUrl: './home-pag.component.scss'
})
export class HomePagComponent {

}
