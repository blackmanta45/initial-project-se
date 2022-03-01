import { LayoutModule } from '@angular/cdk/layout';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from "@angular/forms";
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatNativeDateModule, MatPseudoCheckbox, MatPseudoCheckboxModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatTableModule } from '@angular/material/table';
import { MatToolbarModule } from '@angular/material/toolbar';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { ConfigurationLComponent } from './configuration/configuration-list/configuration-list';
import { ConfigurationComponent } from './configuration/configuration.component';
import { ConfirmDialogComponent } from './configuration/dialog-box/confirm-dialog';
import { NavbarConfigComponent } from './configuration/navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './home/navbar/navbar.component';
import { MemberFormOperationComponent } from './operations/member-form-operation/member-form-operation.component';
import { MemberListComponent } from './operations/member-list/member-list.component';
import { NavbarOperationalComponent } from './operations/navbar/navbar.component';
import { OperationsComponent } from './operations/operations.component';
import { NavbarReportComponent } from './report/navbar/navbar.component';
import { ReportIncomesComponent } from './report/report-incomes-component/report.incomes.component';
import { ReportSpendingsComponent } from './report/report-spendings-component/report.spendings.component';
import { ReportComponent } from './report/report.component';
import { StatisticsComponent } from './report/statistics-component/statistics-component';

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
    MemberListComponent,
    ReportComponent,
    MemberFormOperationComponent,
    ReportComponent,
    NavbarConfigComponent,
    ConfigurationLComponent,
    ConfirmDialogComponent,
    NavbarOperationalComponent,
    StatisticsComponent,
    ReportComponent,
    ReportIncomesComponent,
    ReportSpendingsComponent,
    NavbarReportComponent,
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
    MatGridListModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    MatDatepickerModule,
    MatNativeDateModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
