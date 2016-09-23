using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaacTapTerminal.Models
{
    public class Bill
    {
        [Key]
        [Required]
        public int BillId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public Double SubTotal { get; set; }
        [Required]
        public Double TaxRate { get; set; }
        [Required]
        public Double TipP { get; set; }




    }
}
