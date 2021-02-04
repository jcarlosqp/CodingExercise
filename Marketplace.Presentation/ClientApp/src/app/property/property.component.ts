import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Property } from './property';

@Component({
  selector: 'app-property',
  templateUrl: './property.component.html'
})
export class PropertyComponent {
  public properties: Property[];
  private readonly apiUrl: string = "";

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl = baseUrl + 'api/property';

    http.get<Property[]>(this.apiUrl).subscribe(result => {
      this.properties = result;
    }, error => console.error(error));
  }

  onSave(item: Property) {

    this.http.post<Property>(this.apiUrl, item).subscribe(result => {
      console.info(item);
      alert("The property was saved in the Database!");
    }, error => console.error(error));

  } 
}
