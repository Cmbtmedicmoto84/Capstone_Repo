using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class Customer
    {
        [Key]
        public int CustomerAccountId { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your Street Address")]
        [Display(Name = "Address Line 1")]
        public string AddressLineOne { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLineTwo { get; set; }

        [Required(ErrorMessage = "Enter your City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter your State")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Enter your Zip Code")]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        public string ServiceStatus { get; set; }
        public string AccountBalance { get; set; }

        //[ForeignKey("Product")] //subscribed product
        //public int ProductId { get; set; }
        //public Product Product { get; set; }

        //public IEnumerable<Product> Products { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }     
    }
}
