using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class RestaurantTable
    {
        [Key]
        [Required]
         public int RestaurantTableId { get; set; }
        [Required]

        public List<Order> Orders { get; set; }
    }
}
