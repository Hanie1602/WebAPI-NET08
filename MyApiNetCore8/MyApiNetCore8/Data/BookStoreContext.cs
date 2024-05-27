using Microsoft.EntityFrameworkCore;

namespace MyApiNetCore8.Data
{
    public class BookStoreContext : DbContext   //Để quản lý class tương ứng vs DB, thì kế thừa từ DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt): base(opt)
        {

        }

        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
