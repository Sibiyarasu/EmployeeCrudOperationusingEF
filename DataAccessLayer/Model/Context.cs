using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public  class Context : DbContext
    {
        public Context(DbContextOptions options) : base (options)

        {

        }
         public DbSet<EmployeeModel> EmployeeInfo { get; set; }
        public DbSet<EmployeeDropDownModel> EmployeeWorkType { get; set; }
    }
}
