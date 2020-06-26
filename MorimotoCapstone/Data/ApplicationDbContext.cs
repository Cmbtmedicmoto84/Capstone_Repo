using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Models;  

namespace MorimotoCapstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<InstallTech> InstallTechs { get; set; }
        public DbSet<CustomerServiceRep> CustomerServiceReps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    }
                );

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "InstallTech",
                        NormalizedName = "INSTALLTECH"
                    }
                );

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "CustomerServiceRep",
                        NormalizedName = "CUSTOMERSERVICEREP"
                    }
                );

            base.OnModelCreating(builder);
            //seed data
            builder.Entity<Product>()
                .HasData(
                    new Product { ProductId = 12, ProductName = "Ultra-Fast Internet", ProductPrice = 29.99, ProductDescription = "Our fastest Internet with syncronous Up/Down speeds of 1 Gig!!" },
                    new Product { ProductId = 22, ProductName = "Fast Internet", ProductPrice = 39.99, ProductDescription = "Fast internet with Up/Down speeds of 300Mbps!" },
                    new Product { ProductId = 32, ProductName = "Standard Internet", ProductPrice = 24.99, ProductDescription = "Basic fiber internet speeds of up to 100Mbps!" }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<HelpSupportTicket> HelpSupportTickets { get; set; }
        public DbSet<ServiceAppointment> ServiceAppointments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ServiceInstallOrder> ServiceInstallOrders { get; set; }
        public DbSet<ServiceOrderDetail> ServiceOrderDetails { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
