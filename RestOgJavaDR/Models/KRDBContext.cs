﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestOgJavaDR.Models
{
    public partial class KRDBContext : DbContext
    {
        public KRDBContext()
        {
        }

        public KRDBContext(DbContextOptions<KRDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Records> Records { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}