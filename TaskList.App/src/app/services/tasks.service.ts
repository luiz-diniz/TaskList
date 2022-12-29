import { Injectable } from "@angular/core";
import { TaskItemModel } from "../models/TaskItemModel";
import { HttpRequestService } from "./http.request.service";

@Injectable()
export class TaskService{
    tasks: TaskItemModel[];

    constructor(private _httpRequestService: HttpRequestService) {
    }

    createTask(){

    }
}