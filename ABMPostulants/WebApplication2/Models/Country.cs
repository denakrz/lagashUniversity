using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Country
    {
        public int IdCountry { get; set; }

        [Required]
        public string CountryName { get; set; }

    }
}
