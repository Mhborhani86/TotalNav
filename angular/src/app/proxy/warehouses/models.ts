import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateWarehouseDto {
  name: string;
  location: string;
  capacity: number;
}

export interface WarehouseDto extends AuditedEntityDto<string> {
  name?: string;
  location?: string;
  capacity: number;
  isActive: boolean;
}
