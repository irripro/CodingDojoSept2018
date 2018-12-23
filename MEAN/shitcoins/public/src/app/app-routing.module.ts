import { HomeComponent } from './home/home.component';
import { MineComponent } from './mine/mine.component';
import { BuyComponent } from './buy/buy.component';
import { SellComponent } from './sell/sell.component';
import { LedgerComponent } from './ledger/ledger.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
const routes: Routes = [
  { path: 'home',component: HomeComponent },
  { path: 'mine',component: MineComponent },
  { path: 'buy',component: BuyComponent },
  { path: 'sell',component: SellComponent },
  { path: 'ledger',component: LedgerComponent },

  
  { path: '', pathMatch: 'full', redirectTo: '/home' },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }