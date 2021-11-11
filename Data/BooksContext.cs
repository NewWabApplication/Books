using Microsoft.EntityFrameworkCore;

namespace Books.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext (DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Book> Book { get; set; }
    }
}
