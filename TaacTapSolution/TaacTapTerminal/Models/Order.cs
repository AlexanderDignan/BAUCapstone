using Microsoft.Data.Entity.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TableId { get; set; }
        [Required]
        public DateTime DateTimeCreated{ get;set;}
        [Required]
        public double TotalPrice { get; set; }
        [Required]

        public List<MenuItem> MenuItems { get; set; }



    }
}
