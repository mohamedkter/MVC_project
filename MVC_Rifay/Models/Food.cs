using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Food
    {
        [Key]
        public int item_id { get; set; }
        [Required]
        public string item_name { get; set; }
        [Required]
        public float? item_price { get; set; }
        public int? item_qty { get; set;}
        public float? item_total { get; set; }


    }
}
