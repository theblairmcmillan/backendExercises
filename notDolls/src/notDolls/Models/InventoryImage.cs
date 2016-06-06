using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace notDolls.Models
{
    public class InventoryImage
    {
        [Key]
        public int ImageId { get; set; }
        public int InventoryId { get; set; }
        public string Image { get; set; }
    }
}
