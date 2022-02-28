import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './home/navbar/navbar.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatCardModule } from '@angular/material/card';
import { HomeComponent } from './home/home.component';
import { OperationsComponent } from './operations/operations.component';
import { ConfigurationComponent } from './configuration/configuration.component';
import { MemberComponent } from './operations/member/member.component';
import { MemberListComponent } from './operations/member-list/member-list.component';
import { ReportComponent } from './report/report.component';
import { MemberFormOperationComponent } from './operations/member-form-operation/member-form-operation.component';
import { ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
import { NavbarConfigComponent } from './configuration/navbar/navbar.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTableModule } from '@angular/material/table';
import { FormsModule } from '@angular/forms';
import { MatDialogModule } from '@angular/material/dialog';
import { ConfigurationLComponent } from './configuration/configuration-list/configuration-list';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule, MatPseudoCheckbox, MatPseudoCheckboxModule } from '@angular/material/core';
import { ConfirmDialogComponent } from './configuration/dialog-box/confirm-dialog';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatInputModule } from '@angular/material/input';
import { NavbarOperationalComponent } from './operations/navbar/navbar.component';

const appRoutes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: '', component: HomeComponent },
  { path: 'configuration', component: ConfigurationComponent },
  { path: 'operations', component: OperationsComponent },
  { path: 'report/:id', component: ReportComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    OperationsComponent,
    ConfigurationComponent,
    MemberComponent,
    MemberListComponent,
    ReportComponent,
    MemberFormOperationComponent,
    ReportComponent,
    NavbarConfigComponent,
    ConfigurationLComponent,
    ConfirmDialogComponent,
    NavbarOperationalComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    MatTableModule,
    RouterModule.forRoot(appRoutes),
    ReactiveFormsModule,
    HttpClientModule,
    MatFormFieldModule,
    MatSnackBarModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatPseudoCheckboxModule,
    MatCheckboxModule,
    MatInputModule,
    MatDialogModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    MatDatepickerModule,
    MatNativeDateModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
