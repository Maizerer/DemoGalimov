﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoGalimov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SkiResortEntities : DbContext
    {
        private static SkiResortEntities _context;
        public SkiResortEntities()
            : base("name=SkiResortEntities")
        {
        }
        public static SkiResortEntities GetContext()
        {
            if (_context == null)
                _context = new SkiResortEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Orders_Services> Orders_Services { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
    }
}
