using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_SUT21_VS2022.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Name")]
        [Required(ErrorMessage ="This field is requiered!")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Holder Name")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string HolderName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime Date { get; set; }
    }
}
