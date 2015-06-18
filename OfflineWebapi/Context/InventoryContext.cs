using OfflineWebapi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OfflineWebapi.Context
{
    public class InventoryContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}