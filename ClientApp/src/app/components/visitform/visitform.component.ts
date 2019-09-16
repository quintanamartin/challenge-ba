import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-visitform',
  templateUrl: './visitform.component.html'
})
export class VisitformComponent {
  public sectores: Sectores[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Sectores[]>(baseUrl + 'api/sectores').subscribe(
      result => {
        this.sectores = result;
        // console.log(this.sectores);
      },
      error => console.error(error)
    );
  }
}

interface Sectores {
  id: number;
  nombre: string;
}
