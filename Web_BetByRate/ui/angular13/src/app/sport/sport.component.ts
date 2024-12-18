import { Component, OnInit, Input } from '@angular/core';
import { classSport } from '../models/sport.model';
import { BetByRateService } from '../services/BetByRate.service'
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-sport',
  templateUrl: './sport.component.html',
  styleUrls: ['./sport.component.scss']
})

export class SportComponent implements OnInit {
  //@Input() MySport!: classSport;
  OneSport!: classSport;
  //sportId!: number;
  sportId!: string;

  constructor(private myService: BetByRateService, private route: ActivatedRoute){}

  ngOnInit(){
    // On récupère l'id qui est entré dans l'adresse http
    this.sportId = this.route.snapshot.paramMap.get('IdSport')!;

    // On charge l'objet Sport
    //this.OneSport = this.BetByRate.service.getSportById(sportId);

    //this.OneSport.sportId = +this.route.snapshot.params['id']; // le + c'est pour changer en Number
    //this.sportId = +this.route.snapshot.params['id']; // le + c'est pour changer en Number
    //this.OneSport = this.BetByRateService.getSportById(sportId);

  }

  OpenSport(){
    //this.myRouter.navigateByUrl(`sport/${this.MySport.id}`);
  }

}




