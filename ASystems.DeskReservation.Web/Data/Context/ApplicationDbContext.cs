using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Data.Context;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Desk> Desks { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("Users");
        builder.Entity<Role>().ToTable("Roles");

        builder.SeedData();
    }

}