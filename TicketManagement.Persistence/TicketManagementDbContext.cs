using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Persistence
{
    public class TicketManagementDbContext : DbContext
    {
        public TicketManagementDbContext(DbContextOptions<TicketManagementDbContext> options)
            : base(options) { }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
