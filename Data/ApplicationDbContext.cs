using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MertKaymaz_HW2.Models;

namespace MertKaymaz_HW2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MertKaymaz_HW2.Models.Book> Book { get; set; }
        public DbSet<MertKaymaz_HW2.Models.Category> Category { get; set; }
        public DbSet<MertKaymaz_HW2.Models.Comment> Comment { get; set; }
    }
}
