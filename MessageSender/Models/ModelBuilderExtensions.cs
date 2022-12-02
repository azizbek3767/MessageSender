using Microsoft.EntityFrameworkCore;

namespace MessageSender.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new
                {
                    Id = 1,
                    Name = "John"
                },
                new
                {
                    Id = 2,
                    Name = "Robert"
                },
                new
                {
                    Id = 3,
                    Name = "Bob"
                },
                new
                {
                    Id = 4,
                    Name = "Jenifer"
                },
                new
                {
                    Id = 5,
                    Name = "Jeck"
                },
                new
                {
                    Id = 6,
                    Name = "Dan"
                },
                new
                {
                    Id = 7,
                    Name = "Jasur"
                },
                new
                {
                    Id = 8,
                    Name = "Nodir"
                },
                new
                {
                    Id = 9,
                    Name = "Alisher"
                }
                ); ;
        }
    }
}
