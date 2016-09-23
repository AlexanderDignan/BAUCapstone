using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int MenuItemId { get; set; }

    }
}
