using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class Menu
    {
        [Key]
        [Required]
        public int MenuId { get; set; }
        [Required]
        public String MenuName { get; set; }
        [Required]
        public String RestaurantInfo { get; set; }
    }
}
