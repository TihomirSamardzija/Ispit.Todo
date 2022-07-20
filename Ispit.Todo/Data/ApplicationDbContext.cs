using Ispit.Todo.Models.Dbo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Ispit.Todo.Data
{
    public class ApplicationDbContext : IdentityDbContext<AspNetUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string role = "admin";
            string userName = "matomatic@domena.com";
            string roleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();


            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = role,
                NormalizedName = "ADMIN",
                Id = roleId
            });
            var hasher = new PasswordHasher<AspNetUser>();
            builder.Entity<AspNetUser>().HasData(new AspNetUser
            {
                Id = userId,
                UserName = userName,
                Email = userName,
                NormalizedUserName = userName.ToUpper(),
                NormalizedEmail = userName.ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password12345!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Mato",
                LastName = "Matic"

            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });

        }

        public DbSet<AspNetUser> AspNetUser { get; set; }
        public DbSet<TodoTask> Tasks { get; set; }
        public DbSet<TodoList> Todolist { get; set; }
    }
}