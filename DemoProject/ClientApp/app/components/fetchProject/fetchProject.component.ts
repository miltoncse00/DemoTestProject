import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { DemoService } from '../../shared/demoService';
import { Project } from '../../shared/project.model';



@Component({
    selector: 'fetchproject',
    templateUrl: './fetchproject.component.html'
})


export class FetchProjectComponent {
    public projectList: Project[];

    constructor(public http: Http, private _router: Router, private _demoService: DemoService) {
        this.getEmployees();
    }


    getEmployees() {
        this._demoService.getProjects().subscribe(data => {
            this.projectList = data as Project[];
        }
        );
    }
}