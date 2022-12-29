import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

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
      name: new FormControl(null, [Validators.required, Validators.minLength(2), Validators.maxLength(50)]),
      description: new FormControl(null, [Validators.required, Validators.minLength(2), Validators.maxLength(100)])
    })
  }

  onSubmit(){
    console.log(this.taskForm)
  }

  onClear(){
    this.taskForm.reset();
  }
}