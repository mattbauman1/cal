using Calendar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Data
{
    public class CalendarDbContext : DbContext
    { 
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
}
}
