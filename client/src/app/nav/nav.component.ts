import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  title = 'Dating App';
  model: any = {};
  loggedIn: Boolean;

  constructor(private accountService: AccountService) {}

  ngOnInit(): void {}
  login() {
    this.accountService.login(this.model).subscribe(
      (res) => {
        console.log(res);
        this.loggedIn = true;
      },
      (err) => console.log(err)
    );
  }
  logout() {
    this.loggedIn = false;
  }
}
