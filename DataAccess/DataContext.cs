using EternaHomeWork.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaHomeWork.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Service> Services { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }

    }
}
