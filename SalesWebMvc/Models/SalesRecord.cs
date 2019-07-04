using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Amout  { get; set; }
        public SalesStatus Status { get; set; }
        public Seller seller  { get; set; }
    }
}
