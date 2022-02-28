import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { CommonService } from 'src/services/common-service';

@Component({
  selector: 'navbar-config',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarConfigComponent {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  canDelete: boolean = false;

  constructor(private breakpointObserver: BreakpointObserver, private CommonService: CommonService) {
    this.CommonService.canRemoveEvent.subscribe((data: boolean) => {
      this.canDelete = data;
    });
  }

  removeSelectedRows() {
    this.CommonService.onRemoveClicked();
  }

  addRow() {
    this.CommonService.onAddClicked();
  }
}