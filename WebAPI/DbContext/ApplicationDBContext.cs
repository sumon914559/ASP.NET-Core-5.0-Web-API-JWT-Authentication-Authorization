using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.IdentityAuth;

namespace WebAPI.DbContext
{
    public class ApplicationDBContext: IdentityDbContext<ApplicationUser> 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}