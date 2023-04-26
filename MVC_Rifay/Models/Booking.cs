using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Booking
    {
        [Key]
        public int booking_id { get; set; }
        [Required]
        public int customer_id { get; set; }
        [Required]
        public int item_id{ get ;set;}
        [Required]
        public float total_amount { get; set; }
    }
}
