using System;
using System.ComponentModel.DataAnnotations;

namespace TotalStore.Warehouses
{
    public class CreateUpdateWarehouseDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Location { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "ظرفیت باید عددی مثبت باشد.")]
        public int Capacity { get; set; }
    }
}
