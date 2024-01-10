import { Component, OnInit } from '@angular/core';
import { FlightService } from './../api/services/flight.service';
import { FlightRm } from '../api/models';

@Component({
  selector: 'app-search-flight',
  templateUrl: './search-flight.component.html',
  styleUrls: ['./search-flight.component.css']
})

export class SearchFlightComponent implements OnInit {

  searchResult: FlightRm[] = [
   
  ]
  constructor(private flightService: FlightService) { }

  ngOnInit(): void {
  }

  search()
  {
    this.flightService.searchFlight({})
      .subscribe(response => this.searchResult = response, this.handleError)
  }

  private handleError(err: any)
  {
    console.log(err);
  }
}
