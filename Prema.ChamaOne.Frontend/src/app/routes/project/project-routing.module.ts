import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectViewProjectComponent } from './view-project/view-project.component';

const routes: Routes = [{ path: '', component: ProjectViewProjectComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProjectRoutingModule { }
