import { Component, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute, Route } from '@angular/router';
import { DemoService } from '../../shared/demoService';
import { Project } from '../../shared/project.model';



@Component({
    selector: 'createproject',
    templateUrl: './addProject.component.html'
})
export class CreateProjectComponent implements OnInit {
    projectForm: FormGroup;
    title: 'Create';
    Id: string;
    errorMessage: string;

    ngOnInit(): void {
    }

    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _demoService: DemoService, private _router: Router) {
        if (this._avRoute.snapshot.params["id"]) {
            this.Id = this._avRoute.snapshot.params["id"];
        }

        this.projectForm = this._fb.group({
            Id: '',
            name: ['', [Validators.required]],
            duration: ['', [Validators.required]]
        });
    }


    save() {
        if (!this.projectForm.valid)
            return;

        this._demoService.saveProject(this.projectForm.value)
            .subscribe((data) => {
                this._router.navigate(['/fetch-project']);
            }, error => this.errorMessage = error)

    }

    cancel() {
        this._router.navigate(['/fetch-project']);
    }

    get name() { return this.projectForm.get('name'); }
    get duration() { return this.projectForm.get('duration'); }
  
}