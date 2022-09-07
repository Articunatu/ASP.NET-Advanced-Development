using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_SUT21.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [Required (ErrorMessage ="Please enter your first name!")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required (ErrorMessage ="Please enter your last name!")]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address!")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the name of your city!")]
        [Display(Name = "City")]
        [StringLength(25)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your zip code!")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength =5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone number!")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
