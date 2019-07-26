using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace PakhsheMoyragi.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String MobileNo { get; set; }
    }
}
