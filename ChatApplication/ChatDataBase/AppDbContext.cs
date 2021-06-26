using ChatEntities.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChatDataBase
{
    public class AppDbContext:IdentityDbContext<User>
    {
      public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
