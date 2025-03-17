import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product.component';
import { authGuard, permissionGuard } from '@abp/ng.core';


const routes: Routes = [{ path: '', component: ProductComponent,canActivate: [authGuard, permissionGuard] }];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductRoutingModule { }
