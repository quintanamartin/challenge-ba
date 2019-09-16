import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-dniform',
  templateUrl: './dniform.component.html',
  styleUrls: ['./dniform.component.css']
})
export class DniformComponent implements OnInit {
  nombreCompleto: string;

  dniForm = new FormGroup({
    dni: new FormControl()
  });

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  ngOnInit() {}

  get dni() {
    return this.dniForm.get('dni');
  }

  validar() {
    this.http
      .get<Persona>(this.baseUrl + `api/personas/${this.dni.value}`)
      .subscribe(
        x => (this.nombreCompleto = `${x.nombre}  ${x.apellido}`),
        error => (this.nombreCompleto = 'Not Found')
      );
  }
}
interface Persona {
  id: number;
  dni: number;
  nombre: string;
  apellido: string;
}
