using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace notDolls.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quanity { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int year { get; set; }
        public double sellerId { get; set; }
        public double CreationDate { get; set; }
        public bool Sold { get; set; }
    }
}
