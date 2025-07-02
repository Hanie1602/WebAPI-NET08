using CodeFirstBasic.Contract.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Repositories.DBContext
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		//DB set cho các bảng
		public DbSet<Product> Products { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Cấu hình bảng nếu cần (ví dụ: tên bảng, quan hệ)
			modelBuilder.Entity<Product>().ToTable("Products");
		}
	}
}
