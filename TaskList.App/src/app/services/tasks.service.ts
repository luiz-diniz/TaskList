import { Injectable } from "@angular/core";
import { HttpRequestService } from "./http.request.service";

@Injectable()
export class TaskService{
    tasks: Task[];

    constructor(private _httpRequestService: HttpRequestService) {
    }

    createTask(){
        
    }
}