using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cleanwaterprojectsupport.Models
{
    public class SecurityContext : IdentityDbContext
    {
        public SecurityContext(DbContextOptions<SecurityContext> options)
        : base(options)
        {
        }
        // Unable to generate entity type for table 'dbo.Project'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Feedback'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-ADKNEVB\\SQLEXPRESS;Database=Cleanwaterprojectsupport;Trusted_Connection=True;");
            }
        }
    }
}
