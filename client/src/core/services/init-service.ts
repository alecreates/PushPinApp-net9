import { inject, Injectable } from '@angular/core';
import { AccountService } from './account-service';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InitService {

  private accountService = inject(AccountService);
  
  init() {
    // code to be run before the app is initialized
    const userString = localStorage.getItem('user');
    if (!userString) return of(null);
    const user = JSON.parse(userString);
    this.accountService.currentUser.set(user);

    // return observable of
    return of(null);
  }
  
}
