using System;
using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models
{
    public class Option
    {
        [Key]
        public int PopID { get; set; }
        public int PopNumber { get; set; }
        public string PopDesc { get; set; }//1:Momo,2:Card;  1:Visa,2:Master Card,3:MTN,4:Vodafone,5:AirtelTigo
        public string PopComment { get; set; }//Type;   Account Scheme
        public string PopEntryPerson { get; set; }
        public DateTime PopSysDate { get; set; }
    }
}
