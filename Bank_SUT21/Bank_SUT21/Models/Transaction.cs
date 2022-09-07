using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_SUT21.Models
{
    public class Transaction
    {
        [Key]
        public int TransationID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Holder Name")]
        [Required(ErrorMessage ="This field is requiered!")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Holder Name")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string HolderName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Holder Name")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Holder Name")]
        [Required(ErrorMessage = "This field is requiered!")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:mm-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
