using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebAppMvc.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
