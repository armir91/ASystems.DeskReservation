using ASystems.DeskReservation.Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace ASystems.DeskReservation.Web.Data.Seeding;

public static class ModelBuilderExtension
{
    public static void SeedData(this ModelBuilder builder)
    {
        // STATIC GUIDS FOR ROLES(SEEDING ONLY)
        var adminRoleGuid = MySeededGuidGenerator.CreateGuid();
        var userRoleGuid = MySeededGuidGenerator.CreateGuid();

        // STATIC GUIDS FOR USERS(SEEDING ONLY)
        var userGuid = MySeededGuidGenerator.CreateGuid();
        var user1Guid = MySeededGuidGenerator.CreateGuid();
        var user2Guid = MySeededGuidGenerator.CreateGuid();
        var user3Guid = MySeededGuidGenerator.CreateGuid();
        var user4Guid = MySeededGuidGenerator.CreateGuid();
        var user5Guid = MySeededGuidGenerator.CreateGuid();
        var user6Guid = MySeededGuidGenerator.CreateGuid();


        // SEED DATA INTO ROLE TABLE
        _ = builder.Entity<Role>().HasData
        (
            new Role
            {
                Id = adminRoleGuid,
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new Role
            {
                Id = userRoleGuid,
                Name = "User",
                NormalizedName = "USER"
            }
        );

        // SEED data into User table
        //PASSWORD HASHER
        var hasher = new PasswordHasher<User>();

        var user = new User
        {
            Id = userGuid,
            FirstName = "Armir",
            LastName = "Keta",
            UserName = "armir.keta@gmail.com",
            NormalizedUserName = "ARMIR.KETA@GMAIL.COM",
            Email = "armir.keta@gmail.com",
            NormalizedEmail = "ARMIR.KETA@GMAIL.COM",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0695586306",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user);

        var user1 = new User
        {
            Id = user1Guid,
            FirstName = "User1",
            LastName = "User1",
            UserName = "user1@gmail.com",
            NormalizedUserName = "user1@gmail.com",
            Email = "user1@gmail.com",
            NormalizedEmail = "user1@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user1);

        var user2 = new User
        {
            Id = user2Guid,
            FirstName = "User2",
            LastName = "User2",
            UserName = "user2@gmail.com",
            NormalizedUserName = "user2@gmail.com",
            Email = "user2@gmail.com",
            NormalizedEmail = "user2@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user2);

        var user3 = new User
        {
            Id = user3Guid,
            FirstName = "User3",
            LastName = "User3",
            UserName = "user3@gmail.com",
            NormalizedUserName = "user3@gmail.com",
            Email = "user3@gmail.com",
            NormalizedEmail = "user3@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user3);

        var user4 = new User
        {
            Id = user4Guid,
            FirstName = "User4",
            LastName = "User4",
            UserName = "user4@gmail.com",
            NormalizedUserName = "user4@gmail.com",
            Email = "user4@gmail.com",
            NormalizedEmail = "user4@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user4);

        var user5 = new User
        {
            Id = user5Guid,
            FirstName = "User5",
            LastName = "User5",
            UserName = "user5@gmail.com",
            NormalizedUserName = "user5@gmail.com",
            Email = "user5@gmail.com",
            NormalizedEmail = "user5@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user5);

        var user6 = new User
        {
            Id = user6Guid,
            FirstName = "User6",
            LastName = "User6",
            UserName = "user6@gmail.com",
            NormalizedUserName = "user6@gmail.com",
            Email = "user6@gmail.com",
            NormalizedEmail = "user6@gmail.com",
            EmailConfirmed = true,
            LockoutEnabled = false,
            PhoneNumber = "0690000000",
            PasswordHash = hasher.HashPassword(null, "Admin*123"),
            SecurityStamp = string.Empty
        };
        builder.Entity<User>().HasData(user6);

        // SEED ROLE TO EACH USER

        _ = builder.Entity<IdentityUserRole<Guid>>().HasData
        (
            new IdentityUserRole<Guid>
            {
                RoleId = adminRoleGuid,
                UserId = userGuid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user1Guid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user2Guid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user3Guid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user4Guid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user5Guid
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleGuid,
                UserId = user6Guid
            }
        );

        // SEED DESKS TABLE
        _ = builder.Entity<Desk>().HasData
        (
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk1"
            },
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk2"
            },
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk3"
            },
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk4"
            },
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk5"
            },
            new Desk
            {
                Id = Guid.NewGuid(),
                Name = "Desk6"
            }
        );
    }


    // METHOD THAT GENERATES THE SAME SEQUENCE OF GUID(STATIC)
    public static class MySeededGuidGenerator
    {
        private static int sequence;
        public static Guid CreateGuid()
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes($"{sequence++}"));
                return new Guid(hash);
            }
        }
    }
}
