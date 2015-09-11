using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Server.Models;

namespace Yoda.Net.Server.DataAccess
{
    class AmebaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
