using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Room_Category
    {
        [Key]
        public int categ_id { set; get; }
        [Required]
        public string category { set; get; }
        [Required]
        public float rc_price { set; get; }
        public string ? rc_floor { set; get; }


    }
}
