using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanAPI.Core.DataAccess.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser> {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public override int SaveChanges(){
            return base.SaveChanges();            
        }

    }
}