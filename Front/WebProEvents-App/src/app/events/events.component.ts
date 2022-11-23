import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss'],
})
export class EventsComponent implements OnInit {
  public events: any = [];
  public eventsFiltered: any = [];

  widthImg: number = 150;
  paddingImg: number = 2;
  showImage: boolean = true;
  private _filterList: string = '';

  public get filterList(): string {
    return this._filterList;
  }
  public set filterList(value: string) {
    this._filterList = value;
    this.eventsFiltered = this.filterList ? this.filterEvents(this.filterList) : this.events;
  }

  filterEvents(filterBy: string): any {
    filterBy = filterBy.toLowerCase();
    return this.events.filter(
      (event: any) => event.theme.toLowerCase().indexOf(filterBy) !== -1 ||
        event.local.toLowerCase().indexOf(filterBy) !== -1
    )
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEvents();
  }

  alterImage() {
    this.showImage = !this.showImage;
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe({
      next: (response) => (
        this.events = response,
        this.eventsFiltered = this.events
      ),
      error: (error) => console.log(error)
  });
  }
}
