#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lms.core.Entities;

namespace Lms.Data.Data
{
    public class LmsDataContext : DbContext
    {
        public LmsDataContext (DbContextOptions<LmsDataContext> options)
            : base(options)
        {
        }

        public DbSet<Lms.core.Entities.Course> Course { get; set; }

        public DbSet<Lms.core.Entities.Module> Module { get; set; }
    }
}
