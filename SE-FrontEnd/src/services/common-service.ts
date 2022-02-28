import { Injectable, EventEmitter, Output } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class CommonService {
    @Output() removeEvent = new EventEmitter<string>();
    @Output() addEvent = new EventEmitter<string>();
    @Output() canRemoveEvent = new EventEmitter<boolean>();

    onRemoveClicked() {
        this.removeEvent.emit();
    }

    onAddClicked() {
        this.addEvent.emit();
    }

    canRemoveChanged(canRemove: boolean) {
        this.canRemoveEvent.emit(canRemove);
    }
}