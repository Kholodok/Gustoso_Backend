﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Gustoso.Common.Models;

namespace Gustoso.Context
{
    public class MSContext : IdentityDbContext<User>
    {

        public MSContext(DbContextOptions<MSContext> options)
            : base(options)
        {

        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ReservationStatus> ReservationStatus { get; set; }
    }
}
