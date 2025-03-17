using System;
using System.ComponentModel.DataAnnotations;

namespace TotalStore.Products
{
    public class CreateUpdateProductDTO
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "قیمت باید عددی بیشتر از 0 و به ریال باشد.")]
        public decimal Price { get; set; }
        //[Required]
        //public int WarehouseId { get; set; }
    }
}
