using MGL7760POC.Abstraction.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGL7760POC.Implementation.Repositories
{
    public class ImpotsContext: DbContext
    {
        public DbSet<Declaration> Declarations { get; set; }

        public ImpotsContext(DbContextOptions<ImpotsContext> options)
         : base(options)
        { }
    }
}
