using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCartaoVirtual.Models
{
    public class ApiCartaoVirtualContext : DbContext
    {
        public ApiCartaoVirtualContext(DbContextOptions<ApiCartaoVirtualContext> options)
            : base(options)
        {
        }
        public DbSet<ApiCartaoVirtual.Models.Cartao> Cartao { get; set; }
    }
}
