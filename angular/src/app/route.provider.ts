import { RoutesService, eLayoutType } from '@abp/ng.core';
import { inject, provideAppInitializer } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

function configureRoutes() {
  const routes = inject(RoutesService);
  routes.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },      
      {
        path: '/dashboard',
        name: '::Menu:Dashboard',
        iconClass: 'fas fa-chart-line',
        order: 2,
        layout: eLayoutType.application,
        requiredPolicy: 'ProductStore.Dashboard.Host || AbpAccount.SettingManagement',
      },
      {
        path: '/product-store',
        name: '::Menu:ProductStore',
        iconClass: 'fas fa-product',
        order: 101,
        layout: eLayoutType.application,
      },
      {
        path: '/product',
        name: 'Products',
        parentName: '::Menu:ProductStore',
        layout: eLayoutType.application,
        requiredPolicy: 'TotalStore.Products',
      }
  ]);
}
