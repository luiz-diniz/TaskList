import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { TaskItemModel } from "../models/TaskItemModel";
import { TaskCreateModel } from "../models/TaskCreateModel";
import { environment } from "src/environments/environment";

@Injectable()
export class TaskService{
    tasks: TaskItemModel[];
    taskRoute: string = "task/";

    constructor(private httpClient: HttpClient) {
    }

    createTask(task: TaskCreateModel){
        const createRoute = environment.url + this.taskRoute + "create";

        this.httpClient.post<TaskCreateModel>(createRoute, task).subscribe({error: console.error});
    }
}