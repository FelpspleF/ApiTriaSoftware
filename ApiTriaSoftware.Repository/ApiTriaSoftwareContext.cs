using ApiTriaSoftware.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTriaSoftware.Repository
{
    public class ApiTriaSoftwareContext : DbContext
    {
        public ApiTriaSoftwareContext(DbContextOptions<ApiTriaSoftwareContext> options) : base(options)
        {

        }

        #region DbSets
        public DbSet<Product> Products { get; set; }
        #endregion
    }
}
