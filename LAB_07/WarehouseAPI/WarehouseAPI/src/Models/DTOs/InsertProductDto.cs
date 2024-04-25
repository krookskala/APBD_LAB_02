﻿using System.ComponentModel.DataAnnotations;

namespace WarehouseAPI.Models.DTOs
{
    public class InsertProductDto
    {
        [Required]
        public int IdProduct { get; set; }
        [Required]
        public int IdWarehouse { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}