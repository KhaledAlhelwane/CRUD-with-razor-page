using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalProfit.Model;

namespace PersonalProfit.Data
{
    public class PersonalProfitContext : DbContext
    {
        public PersonalProfitContext (DbContextOptions<PersonalProfitContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalProfit.Model.User> User { get; set; } = default!;
    }
}
