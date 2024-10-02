import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ProjectRoutingModule } from './project-routing.module';
import { ProjectViewProjectComponent } from './view-project/view-project.component';

const COMPONENTS: any[] = [ProjectViewProjectComponent];
const COMPONENTS_DYNAMIC: any[] = [];

@NgModule({
  imports: [
    SharedModule,
    ProjectRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_DYNAMIC
  ]
})
export class ProjectModule { }
