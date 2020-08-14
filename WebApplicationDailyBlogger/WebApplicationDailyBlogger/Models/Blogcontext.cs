using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDailyBlogger.Models
{
    public class Blogcontext : DbContext
    {
        public DbSet<BlogPost> blogpost { get; set; }
        public Blogcontext(DbContextOptions<Blogcontext> options) : base(options)
        {

        }
    }
}
