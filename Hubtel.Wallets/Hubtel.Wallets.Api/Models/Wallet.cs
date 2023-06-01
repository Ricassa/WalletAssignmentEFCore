using System;
using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models
{
    public class Wallet
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string AccountScheme { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public int UserID { get; set; }
    }
}
