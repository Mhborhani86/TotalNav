import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductService, ProductDTO } from '@proxy/products';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.component.html',
  styleUrl: './product.component.scss',
  providers:[ListService,      { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter } 
  ]
})
export class ProductComponent implements OnInit {
product = { items:[],totalCount : 0 } as PagedResultDto<ProductDTO> ;
form: FormGroup;
selectedProduct = {} as ProductDTO;


isModalOpen = false;
constructor (
  public readonly list:ListService,
  private productService : ProductService,
  private fb: FormBuilder,
  private confirmation: ConfirmationService
){}
ngOnInit() {
  const productStreamCreator = (query) => this.productService.getList(query);

  this.list.hookToQuery(productStreamCreator).subscribe((response) => {
    this.product = response;
  }); 
}
createProduct() {
  this.selectedProduct = {} as ProductDTO; 
  this.buildForm();
  this.isModalOpen = true;
}

editProduct(id: string) {
  this.productService.get(id).subscribe((product) => {
    this.selectedProduct = product;
    this.buildForm();
    this.isModalOpen = true;
  });
}

deleteProduct(id: string) {
  this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
    if (status === Confirmation.Status.confirm) {
      this.productService.delete(id).subscribe(() => this.list.get());
    }
  });
}

buildForm() {
  this.form = this.fb.group({
    name: [this.selectedProduct.name || '', Validators.required],
    quantity: [this.selectedProduct.quantity || null,Validators.required],
    price: [this.selectedProduct.price || null,Validators.required],
  });
}

 save() {
  if (this.form.invalid) {
    return;
  }


  
  const request = this.selectedProduct.id
  ? this.productService.update(this.selectedProduct.id, this.form.value)
  : this.productService.create(this.form.value);

request.subscribe(() => {
  this.isModalOpen = false;
  this.form.reset();
  this.list.get();
});
  
}
}
