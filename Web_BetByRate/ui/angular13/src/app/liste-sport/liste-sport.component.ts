import { Component, OnInit, Input } from '@angular/core';
import { classSport } from '../models/sport.model';
import { BetByRateService } from '../services/BetByRate.service'
import { Router } from '@angular/router';
//import { Observable } from 'rxjs';

@Component({
  selector: 'app-liste-sport',
  templateUrl: './liste-sport.component.html',
  styleUrls: ['./liste-sport.component.scss']
})

export class ListeSportComponent implements OnInit {
  
  //sports!: sport[];
  //@Input() sport!: classSport;
  //sportList$!:Observable<any[]>;

  //constructor(private myService: BetByRateService) { }
  constructor(private myService: BetByRateService, private myRouter:Router) { }

  //ListeSports!: classSport[];
  ListeSports:any=[];
  Sport:any;



  ngOnInit(): void {
    //this.sports = this.BetByRateService.getAllSports();
    //this.refreshSportList();
    //this.ListeSports = this.myService.getAllSports();
    //this.sportList$ = this.myService.getSportList();

    // On charge la liste des sports
    this.myService.getSportsList().subscribe(data=>{
      this.ListeSports=data;
    })
  }


editSport(idSport: number){
 //editSport(item:any){
    this.myRouter.navigateByUrl(`sports/${idSport}`);
    //this.myRouter.navigateByUrl(`sports?idSport=${idSport}`);
    //this.myRouter.navigateByUrl(`sports/${item.idSport}`);
    //this.myRouter.navigateByUrl(`sports/${1}`);

  }

  /*
  refreshSportList(){
      this.myService.getSportsList().subscribe(data=>{
      this.ListeSports=data;
    })
  }*/




  
}
