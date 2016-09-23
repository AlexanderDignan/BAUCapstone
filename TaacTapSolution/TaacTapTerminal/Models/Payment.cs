using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class Payment
    {
        [Key]
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public int BillOrderId { get; set; }
        [Required]
        public int BillId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
