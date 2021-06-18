using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int CityId { get; set; }

        public int CountryId { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class CityClass
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryClass")]
        public int CountryRefId { get; set; }

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
