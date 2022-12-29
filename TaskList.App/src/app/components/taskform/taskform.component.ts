import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TaskCreateModel } from 'src/app/models/TaskCreateModel';
import { TaskService } from 'src/app/services/tasks.service';

@Component({
  selector: 'app-taskform',
  templateUrl: './taskform.component.html',
  styleUrls: ['./taskform.component.scss']
})
export class TaskformComponent implements OnInit {

  taskForm: FormGroup;

  constructor(private taskService: TaskService) { }

  ngOnInit(): void {
    this.taskForm = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(2), Validators.maxLength(50)]),
      description: new FormControl(null, [Validators.required, Validators.minLength(2), Validators.maxLength(100)])
    })
  }

  onSubmit(){
    let task: TaskCreateModel = {
      IdUser: 1,
      Name: this.taskForm.value['name'],
      Description: this.taskForm.value['description']
    };
    
    this.taskService.createTask(task);
  }

  onClear(){
    this.taskForm.reset();
  }
}