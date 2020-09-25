import { NgModule } from '@angular/core';
//import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { LockComponent } from './lock/lock.component';
import { RecoverComponent } from './recover/recover.component';

import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
    SharedModule
  ],
  declarations: [
    LoginComponent,
    RegisterComponent,
    LockComponent,
    RecoverComponent
  ],
  exports: [
    LoginComponent,
    RegisterComponent,
    LockComponent,
    RecoverComponent
  ]
})
export class AuthModule { }
