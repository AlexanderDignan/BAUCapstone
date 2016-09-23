using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int ReservationId { get; set; }
        [Required]
        public int RestaurantTableId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
