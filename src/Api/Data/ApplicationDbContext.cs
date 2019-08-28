using System;
using System.Collections.Generic;
using System.Text;
using Api.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Golpe> Golpes { get; set; }

        public DbSet<Midia> Midias { get; set; }
    }
}
