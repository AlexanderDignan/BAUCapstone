using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models
{
    public class RestaurantInfo
    {
        [Key]
        [Required]
        public int RestaurantInfoId {get;set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

        public string City { get; set; }
        [Required]
        public  string phone { get; set; }
        [Required]
        public int NumberOfTables { get; set; }




    }
}
