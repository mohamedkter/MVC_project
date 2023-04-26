using System.ComponentModel.DataAnnotations;

namespace MVC_Rifay.Models
{
    public class Customer
    {
        [Key]
        public int customer_Id { get; set; }
        [Required]
        public string? customer_Name { get; set; }
        public string? customer_address { get; set; }
        public int customer_phone { get; set; }
        public string? customer_email { get; set; }
        public DateTime customer_DOB { get; set; }
    }
}
