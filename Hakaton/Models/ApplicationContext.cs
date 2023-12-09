using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hakaton.Models
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMembers> ChatMembers { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>().ToTable("Chat");
            modelBuilder.Entity<ChatMembers>().ToTable("ChatMembers");
            modelBuilder.Entity<Message>().ToTable("Message");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
    }
}
