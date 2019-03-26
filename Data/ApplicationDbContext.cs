﻿
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SandwichShop.Data
{
    public class ApplicationDbContext : IdentityDbContext /* Or just DbContext*/
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Just define the shape of each table in another data model class, and add 
        //those as DbSets here:
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}