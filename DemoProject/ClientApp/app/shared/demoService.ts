import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { Project } from '../shared/project.model';

@Injectable()
export class DemoService
{
    myAppUrl: string = "";
  
    constructor(private _http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.myAppUrl = baseUrl;
    }

   

   
    getProjects() {
        return this._http.get(this.myAppUrl + "api/Projects")
            .map((response: Response) => response.json())
            .catch(this.errorHandler);
    }


    saveProject(project: Project) {
        if (project.Id == '') {
            project.Id = '00000000-0000-0000-0000-000000000000';
        }
        return this._http.post(this.myAppUrl + "api/Projects", project)
            .map((response: Response) => response.json())
            .catch(this.errorHandler)
    }

    errorHandler(error: Response) {
        console.log(error);
        return Observable.throw(error);
    }
}