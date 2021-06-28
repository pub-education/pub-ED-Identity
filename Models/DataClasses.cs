using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Identity.Data;
using Nelibur.ObjectMapper;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        private ApplicationUser user;

        public ApplicationUser() : base() { 
            
        }

        public ApplicationUser(ApplicationUser user)
        {
            this.user = user;
        }

        [ForeignKey("CityClass")]
        public int CityId { get; set; }


        [ForeignKey("CountryClass")]
        public int CountryId { get; set; }

        public ApplicationUser User { get { return this.user; } }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class AppUserData: ApplicationUser
    {
        public AppUserData(ApplicationUser user, ApplicationDbContext ctx):base(user) {
            City = ctx.Cities.Find(user.CityId);
            Country = ctx.Countries.Find(user.CountryId);
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            PasswordHash = user.PasswordHash;
            CityName = City.Name;
            CountryName = Country.Name;
        }

        public string CityName { get; set; }
        public string CountryName { get; set; }
        public CityClass City { get; }
        public CountryClass Country { get; }
    }

    public class CityClass
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryClass")]
        public int CountryId { get; set; }
        public List<ApplicationUser> Users { get; set; }

        public string Name { get; set; }

        
    }

    public class CountryClass
    {
        [Key]
        public int Id { get; set; }

        public List<CityClass> Cities { get; set; }

        public List<ApplicationUser> Users { get; set; }

        public string Name { get; set; }
    }

    public class Countries
    {
        public List<CountryClass> List { get; set; }

        public Countries()
        {
            List = new List<CountryClass>();
        }

        public void LoadCountries(ApplicationDbContext ctx)
        {
            var _list =ctx.Countries;
            foreach(CountryClass country in _list)
            {
                List.Add(country);
            }
        }
    }

    public class Cities
    {
        public List<CityData> List { get; set; }

        public void LoadCities(ApplicationDbContext ctx)
        {
            List = new List<CityData>();
            var _list = ctx.Cities;
            foreach (CityClass city in _list)
            {
                var cityData = new CityData(city.CountryId, ctx);
                cityData.Name = city.Name;
                cityData.Id = city.Id;
                List.Add(cityData);
            }
        }
    }

    public class CityData : CityClass
    {
        public CityData(int countryId, ApplicationDbContext ctx) : base() {
            Country = ctx.Countries.Find(countryId).Name;
            CountryId = countryId;
        }

        public string Country { get; set; }
    }
}
