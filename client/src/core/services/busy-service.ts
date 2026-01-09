import { Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequestCount = signal(0);

  busy() {
    this.busyRequestCount.update(current => current + 1);
  }

  // decrement by 1 but never below 0
  idle() {
    this.busyRequestCount.update(current => Math.max(0, current - 1));
  }
}
