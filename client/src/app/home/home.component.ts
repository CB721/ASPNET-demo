import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  isRegisterMode: Boolean = false;

  constructor() {}

  ngOnInit(): void {}
  registerToggle() {
    this.isRegisterMode = !this.isRegisterMode;
  }

  cancelRegisterMode(event: Boolean) {
    this.isRegisterMode = event;
  }
}
