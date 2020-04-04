using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<ManufacturerRefactor> manufacturerRefactor { get; set; }
        public DbSet<VehicleModelRefactor> vehicleModelRefactor { get; set; }
      
    }
}
