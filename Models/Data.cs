using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //necessary

namespace hello.Models
{
    public class Data
    {
        public int Id { get; set; }
        public string? Value1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Value2 { get; set; }
        public string? Value3 { get; set; }
        public decimal Value4 { get; set; }
    }
}