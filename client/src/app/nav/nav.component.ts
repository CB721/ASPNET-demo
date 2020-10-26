import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  title = 'Dating App';
  model: any = {};

  constructor(public accountService: AccountService) {}

  ngOnInit(): void {
  }
  login() {
    this.accountService.login(this.model).subscribe(
      (res) => {
        console.log(res);
      },
      (err) => console.log(err)
    );
  }
  logout() {
    this.accountService.logout();
  }
}
