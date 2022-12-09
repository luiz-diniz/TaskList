import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

//components
import { AppComponent } from './app.component';
import { TaskformComponent } from './components/taskform/taskform.component';
import { TasksComponent } from './components/tasks/tasks.component';
import { TaskComponent } from './components/task/task.component';

//services
import { TaskService } from './services/tasks.service';
import { HttpRequestService } from './services/http.request.service';

@NgModule({
  declarations: [
    AppComponent,
    TaskformComponent,
    TasksComponent,
    TaskComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [
    TaskService,
    HttpRequestService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
