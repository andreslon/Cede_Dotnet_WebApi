using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MedicalAppointment.Core.Entities;

namespace MedicalAppointment.Core
{
    public class MedicalAppointmentContext : DbContext
    {
        public MedicalAppointmentContext(DbContextOptions<MedicalAppointmentContext> options)
            : base(options)
        { }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Disponibility> Disponibility { get; set; }
        public DbSet<Specialist> Specialist { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            #region SeedData
            modelBuilder.Seed();
            #endregion
        }

    }
}
