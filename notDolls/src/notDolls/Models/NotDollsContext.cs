using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace notDolls.Models
{
    public class NotDollsContext : DbContext
    {
        public NotDollsContext(DbContextOptions<NotDollsContext> options)
            : base(options)
        { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InventoryImage> Image { get; set; }
    }
}