import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './dashboard.html',
  styleUrls: ['./dashboard.css']
})
export class Dashboard {
saveNotes() {
throw new Error('Method not implemented.');
}
  notes: string[] = [];
  note = '';

  addNote() {
    const text = this.note.trim();
    if (!text) return;
    this.notes.push(text);
    this.note = '';
  }
}
