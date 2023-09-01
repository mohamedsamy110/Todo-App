using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Context
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo.Models.Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }


        //public TodoContext(DbContextOptions options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P9GD2V1\\SQLEXPRESS;Database=Todo;Trusted_Connection=True;Encrypt=False;trustservercertificate=true;");
        }
    }
}
