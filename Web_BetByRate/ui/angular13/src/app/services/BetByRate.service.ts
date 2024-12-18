import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { classSport } from '../models/sport.model';


@Injectable({
	providedIn: 'root'
})

export class BetByRateService{
	
	readonly APIUrl="https://localhost:44374/api"

	constructor(private http:HttpClient) { }

	getSportsList(): Observable<any[]>{
		//return this.http.get<any[]>(this.APIUrl+'/Sport/Get')
		return this.http.get<any[]>(this.APIUrl+'/Sport')
		//return this.http.get<any[]>(this.APIUrl)
	}

	/*
  getSportById(sportId: number): classSport {
		// Charger mySport avec une commande SQL

		//const mySport = this.XXXXTableauSportsXXXX.find(mySport => sport.id === sportId);
		//const faceSnap = this.faceSnaps.find(faceSnap => faceSnap.id === 2);
		if (!mySport) {
		  throw new Error('Sport not found!');
		} else {
		  return mySport;
		}
	}*/

/*
	chargeListeSport(listeFromApi): classSport[]{

	}*/

	//sports: classSport[] = []

	/*
	sports: classSport[] = [
		{
			id: 1,
			nom: 'Tennis'
		},
		{
			id: 2,
			nom: 'Volley'
		}
	];*/
	
	//getSportsList(): classSport[]{
	//return this.sports;}


}