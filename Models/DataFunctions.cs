using Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class DataFunctions
    {
        private ApplicationDbContext _context { get; set; }

        public DataFunctions(ApplicationDbContext ctx)
        {
            this._context = ctx;
        }

        public List<ApplicationUser> GetUsers()
        {
            IQueryable<ApplicationUser> query = (IQueryable<ApplicationUser>)this._context.Users.OrderBy(x => x.UserName);

            return query.ToList<ApplicationUser>();
        } 
    }
}
