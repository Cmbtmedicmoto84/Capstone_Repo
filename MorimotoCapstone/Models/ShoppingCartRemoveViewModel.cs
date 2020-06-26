using Microsoft.AspNetCore.Mvc;
using MorimotoCapstone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public double CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
    }
    
}
