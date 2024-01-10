import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-flight',
  templateUrl: './search-flight.component.html',
  styleUrls: ['./search-flight.component.css']
})
export class SearchFlightComponent implements OnInit {

  searchResult: FlightRm[] = [
    {
      airline: "TAM",
      remainingNumberOfSeats: 500,
      departure: { time: Date.now().toString(), place: "Los Angeles" },
      arrival: { time: Date.now().toString(), place: "Instabul" },
      price: "350",
    },
    {
      airline: "Luftansa",
      remainingNumberOfSeats: 230,
      departure: { time: Date.now().toString(), place: "Mexico" },
      arrival: { time: Date.now().toString(), place: "USA" },
      price: "630",
    },
    {
      airline: "Ryanair",
      remainingNumberOfSeats: 75,
      departure: { time: Date.now().toString(), place: "Dublin" },
      arrival: { time: Date.now().toString(), place: "London" },
      price: "120",
    },
    
  ]
  constructor() { }

  ngOnInit(): void {
  }

}

export interface FlightRm
{
  airline: string;
  arrival: TimePlaceRm;
  departure: TimePlaceRm;
  price: string;
  remainingNumberOfSeats: number;
}

export interface TimePlaceRm
{
  place: string;
  time: string;
}
