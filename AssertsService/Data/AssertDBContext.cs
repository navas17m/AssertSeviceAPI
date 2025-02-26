﻿using AssertsService.Models;
using Microsoft.EntityFrameworkCore;
namespace AssertsService.Data
{
    public class AssertDBContext:DbContext
    {
        public AssertDBContext(DbContextOptions<AssertDBContext> options) : base(options)
        { 
        
        }
        public DbSet<Municipal> Municipals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }        
        public DbSet<AssertRegister> AssertRegisters { get; set; }
        public DbSet<AssetStatus> AssetStatus { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<LastMaintenanceStrategy> LastMaintenanceStrategies { get; set; }
        public DbSet<UtilizationRates> UtilizationRates { get; set; }
    }
}
