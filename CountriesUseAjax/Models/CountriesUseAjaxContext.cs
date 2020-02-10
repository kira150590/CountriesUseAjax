using System;
using Microsoft.EntityFrameworkCore;

namespace CountriesUseAjax.Models
{
    // Class kế thừa DbContext, thực hiện truy vấn dữ liệu
    public class CountriesUseAjaxContext : DbContext
    {
        public CountriesUseAjaxContext(DbContextOptions<CountriesUseAjaxContext> options) : base(options) { }
       
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
