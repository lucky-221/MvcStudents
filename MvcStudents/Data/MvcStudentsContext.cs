#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudents.Models;

namespace MvcStudents.Data
{
    public class MvcStudentsContext : DbContext
    {
        public MvcStudentsContext (DbContextOptions<MvcStudentsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStudents.Models.Student> Student { get; set; }
    }
}
