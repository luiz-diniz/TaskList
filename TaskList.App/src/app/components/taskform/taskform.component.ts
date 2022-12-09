import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-taskform',
  templateUrl: './taskform.component.html',
  styleUrls: ['./taskform.component.scss']
})
export class TaskformComponent implements OnInit {

  taskForm: FormGroup;

  constructor() { }

  ngOnInit(): void {
    this.taskForm = new FormGroup({
      name: new FormControl(null),
      description: new FormControl(null)
    })
  }
}