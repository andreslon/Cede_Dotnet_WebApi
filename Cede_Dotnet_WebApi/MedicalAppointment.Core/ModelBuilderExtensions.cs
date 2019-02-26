using MedicalAppointment.Core.Entities;
using MedicalAppointment.Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace MedicalAppointment.Core
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "William",
                    LastName = "Ramirez",
                    Nit = "0001",
                    Genre = Genre.Male,
                    BirthDay = new DateTime(1990, 1, 1),
                    NitDate = new DateTime(2008, 5, 6)
                }
            , new User() { UserId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Sofia", LastName = "Cano", Nit = "0002", Genre = Genre.Female, BirthDay = new DateTime(1995, 1, 1), NitDate = new DateTime(2013, 01, 01) }
            , new User() { UserId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Andres", LastName = "Ortega", Nit = "0003", Genre = Genre.Male, BirthDay = new DateTime(1992, 1, 1), NitDate = new DateTime(2007, 5, 6) }
            , new User() { UserId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "David", LastName = "Urrutia", Nit = "0004", Genre = Genre.Male, BirthDay = new DateTime(1986, 1, 1), NitDate = new DateTime(2005, 01, 01) }
            );

            modelBuilder.Entity<Specialist>().HasData(
             new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Carlos", LastName = "Plata", Specialty = Specialty.General }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Manuel", LastName = "Gamez", Specialty = Specialty.General }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Lucia", LastName = "Garcia", Specialty = Specialty.Nutritionist }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Ana", LastName = "Gamez", Specialty = Specialty.Odontology }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Sara", LastName = "Aristizabal", Specialty = Specialty.Physiotherapy }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Darleys", LastName = "Valderrama", Specialty = Specialty.Odontology }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Camilo", LastName = "Hernandez", Specialty = Specialty.Ophthalmology }
            , new Specialist() { SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Estela", LastName = "pulgar", Specialty = Specialty.General }
            );

            modelBuilder.Entity<Disponibility>().HasData(
             new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000100"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 8 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000101"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 9 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000102"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 10 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000103"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 11 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000104"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 13 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000105"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 14 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000106"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 15 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000107"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 16 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000108"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Hour = 17 }
            );

            modelBuilder.Entity<Disponibility>().HasData(new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000109"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 8 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000110"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 9 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000111"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 10 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000112"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 11 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000113"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 13 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000114"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 14 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000115"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 15 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000116"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 16 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000117"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Hour = 17 }
            );

            modelBuilder.Entity<Disponibility>().HasData(
                new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000118"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 8 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000119"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 9 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000120"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 10 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000121"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 11 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000122"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 13 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000123"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 14 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000124"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 15 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000125"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 16 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000126"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Hour = 17 }
            );

            modelBuilder.Entity<Disponibility>().HasData(
                new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000127"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 8 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000128"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 9 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000129"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 10 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000130"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 11 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000131"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 13 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000132"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 14 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000133"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 15 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000134"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 16 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000135"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Hour = 17 }
            );
            modelBuilder.Entity<Disponibility>().HasData(
                new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000136"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 8 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000137"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 9 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000138"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 10 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000139"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 11 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000140"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 13 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000141"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 14 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000142"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 15 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000143"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 16 }
            , new Disponibility() { DisponibilityId = Guid.Parse("00000000-0000-0000-0000-000000000144"), SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Hour = 17 }
            );
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment() { AppointmentId = Guid.Parse("00000000-0000-0000-0000-000000001001"), Code = "AP001", SpecialistId = Guid.Parse("00000000-0000-0000-0000-000000000005"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"), AppointmentStatus = AppointmentStatus.Scheduled, AppointmentDate = new DateTime(2019, 12, 12) }
                );
        }
    }


}
