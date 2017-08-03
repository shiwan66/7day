﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class SalesERPDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmptyResult>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<EmptyResult> Employees { get; set; }

    }
}