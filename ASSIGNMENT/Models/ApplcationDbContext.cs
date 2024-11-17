using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASSIGNMENT.Models
{
    public class ApplcationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplcationDbContext(DbContextOptions<ApplcationDbContext> options) : base(options)
        {
        }

      
    }
}
