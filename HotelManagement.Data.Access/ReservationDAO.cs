﻿namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;
    using HotelManagement.Data.Transfer;

    using Microsoft.EntityFrameworkCore;

    using System.Numerics;

    public class ReservationDAO : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }

        public bool HasStaffId(BigInteger id)
            => (from i in Set<Reservation>()
                where i.StaffID == id
                select i).Any();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
            modelBuilder.Entity<Reservation>()
                .BigIntegerIdProperty(nameof(Reservation.StaffID), "StaffID", "SA", "3");
            modelBuilder.Entity<Invoice>()
                .BigIntegerIdProperty(nameof(Invoice.StaffID), "StaffID", "SA", "3");
            modelBuilder.Entity<RentRoomDetail>()
                            .BigIntegerIdProperty(nameof(RentRoomDetail.StaffID), "StaffID", "SA", "3");
            modelBuilder.Entity<UseServiceDetail>()
                            .BigIntegerIdProperty(nameof(UseServiceDetail.StaffID), "StaffID", "SA", "3");

        }
    }
}
