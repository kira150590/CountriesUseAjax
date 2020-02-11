using System;
using Microsoft.EntityFrameworkCore;

namespace CountriesUseAjax.Models
{
    public class CountriesUseAjaxContext : DbContext
    {
        public CountriesUseAjaxContext(DbContextOptions<CountriesUseAjaxContext> options) : base(options) { }
       
        public DbSet<Province> Provinces { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Ward> Wards { get; set; }
    }
}
