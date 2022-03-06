using MGL7760POC.Implementation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MGL7760POC.Web
{
    //public class ImpotContextFactory: IDesignTimeDbContextFactory<ImpotsContext>
    //{
    //    public ImpotsContext CreateDbContext(string[] args)
    //    {
    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //        var builder = new DbContextOptionsBuilder<ImpotsContext>();
    //        var connectionString = configuration.GetConnectionString("DefaultConnection");

    //        builder.UseSqlServer(connectionString);

    //        return new ImpotsContext(builder.Options);
    //    }

    //}
}
