using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Identity.Data;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public ApplicationUser() : base() { 
            
        }
        public CityClass City { get; set; }

        public CountryClass Country { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CityClass
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryClass")]
        public int CountryId { get; set; }

        public string Name { get; set; }
    }

    public class CountryClass
    {
        [Key]
        public int Id { get; set; }

        public List<CityClass> Cities { get; set; }

        public string Name { get; set; }
    }
}
