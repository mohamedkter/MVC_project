using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Booking_Details
    {
        [Key]
        public int booking_details { get; set; }
        public int booking_id { get; set;}
        public int room_id { get; set;}
        public int room_category { get; set; }
        public DateTime check_in { get; set; }
        public DateTime check_out { get; set; }
        public int? total_days { get; set; }
        public int? booking_amount { get; set; }


    }
}
