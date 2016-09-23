using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
   public class MenuItem
    {
        [Key]
        [Required]
        public int MenuItemId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public String Description { get; set; }

        [Required]
        public int MenuId { get; set; }


    }
}
