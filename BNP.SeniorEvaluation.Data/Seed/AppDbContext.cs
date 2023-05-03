using BNP.SeniorEvaluation.Domain;
using Microsoft.EntityFrameworkCore;

namespace BNP.SeniorEvaluation.Data;

public partial class AppDbContext
{
    public void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = 1,
                FirstName = "William",
                LastName = "Shakespeare"
            },
            new Author
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Austen"
            },
            new Author
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Twain"
            },
            new Author
            {
                Id = 4,
                FirstName = "Fyodor",
                LastName = "Dostoevsky"
            },
            new Author
            {
                Id = 5,
                FirstName = "Charlotte",
                LastName = "Bronte"
            }
        );
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "Romeo and Juliet",
                AuthorId = 1
            },
            new Book
            {
                Id = 2,
                Title = "Pride and Prejudice",
                AuthorId = 2
            },
            new Book
            {
                Id = 3,
                Title = "The Adventures of Tom Sawyer",
                AuthorId = 3
            },
            new Book
            {
                Id = 4,
                Title = "Crime and Punishment",
                AuthorId = 4
            },
            new Book
            {
                Id = 5,
                Title = "Jane Eyre",
                AuthorId = 5
            },
            new Book
            {
                Id = 6,
                Title = "Hamlet",
                AuthorId = 1
            },
            new Book
            {
                Id = 7,
                Title = "Sense and Sensibility",
                AuthorId = 2
            },
            new Book
            {
                Id = 8,
                Title = "The Adventures of Huckleberry Finn",
                AuthorId = 3
            },
            new Book
            {
                Id = 9,
                Title = "The Brothers Karamazov",
                AuthorId = 4
            },
            new Book
            {
                Id = 10,
                Title = "Villette",
                AuthorId = 5
            },
            new Book
            {
                Id = 11,
                Title = "Macbeth",
                AuthorId = 1
            },
            new Book
            {
                Id = 12,
                Title = "Emma",
                AuthorId = 2
            },
            new Book
            {
                Id = 13,
                Title = "Adventures of Huckleberry Finn",
                AuthorId = 3
            },
            new Book
            {
                Id = 14,
                Title = "Notes from Underground",
                AuthorId = 4
            },
            new Book
            {
                Id = 15,
                Title = "Shirley",
                AuthorId = 5
            },
            new Book
            {
                Id = 16,
                Title = "King Lear",
                AuthorId = 1
            },
            new Book
            {
                Id = 17,
                Title = "Mansfield Park",
                AuthorId = 2
            },
            new Book
            {
                Id = 18,
                Title = "The Prince and the Pauper",
                AuthorId = 3
            },
            new Book
            {
                Id = 19,
                Title = "The Idiot",
                AuthorId = 4
            });
    }
}