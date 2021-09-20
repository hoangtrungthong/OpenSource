using System;
using System.ComponentModel.DataAnnotations;

namespace netcore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
