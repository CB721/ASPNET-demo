import { Injectable } from '@angular/core';
import {
  CanActivate,
  CanDeactivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';
import { EditMembersComponent } from '../members/edit-members/edit-members.component';

@Injectable({
  providedIn: 'root',
})
export class PreventUnsavedChangesGuard implements CanDeactivate<unknown> {
  canDeactivate(component: EditMembersComponent): boolean {
    if (component.editForm.dirty) {
      return confirm(
        'Are you sure you want to leave the page?  Any unsaved changes will be lost.'
      );
    }
    return true;
  }
}
