import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListeSportComponent } from './liste-sport/liste-sport.component';
import { SportComponent } from './sport/sport.component';

const routes: Routes = [
  // Le '' correspond au Get seul
  // Le 'sports' correspond au get + Sport. url : site\sports. Le nom 'sports' corrspond au nom de la fonction dans l'API
  //{Path: 'home', component: HomeComponent},
  { path: '',             component: ListeSportComponent },
  { path: 'sports',       component: ListeSportComponent },
  //{ path: 'sport',        component: SportComponent },
  { path: 'sports/:IdSport',  component: SportComponent },
  //{ path: 'sports?IdSport=:IdSport',  component: SportComponent },
  //{ path: '',redirectYo: '/home', patchMatch: 'full'},

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
