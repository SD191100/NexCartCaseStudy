using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NexCart.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        public string CompanyName { get; set; }

        [Required]
        public string GSTNumber { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        public string BankAccountNumber { get; set; }
        public string IFSC { get; set; }

        // Navigation
        public ICollection<Product> Products { get; set; }
        public Address Address { get; set; }
    }
}

