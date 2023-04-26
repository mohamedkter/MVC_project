using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Rooms
    {
        [Key]
        public int room_id { set; get; }
        [Required]
        public string room_img { set; get; }
        [Required]
        public int categ_id { set; get; }


    }
}
