using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcUserForm.Models;

namespace MvcUserForm.Data
{
    public class MvcUserFormContext : DbContext
    {
        public MvcUserFormContext (DbContextOptions<MvcUserFormContext> options)
            : base(options)
        {
        }

        public DbSet<MvcUserForm.Models.UserData> UserData { get; set; }
    }
}
