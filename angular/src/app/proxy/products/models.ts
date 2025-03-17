import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateProductDTO {
  name: string;
  quantity: number;
  price: number;
}

export interface ProductDTO extends AuditedEntityDto<string> {
  name?: string;
  quantity: number;
  price: number;
}
