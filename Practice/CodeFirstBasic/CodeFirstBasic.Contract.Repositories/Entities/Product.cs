using CodeFirstBasic.Core.Base;

namespace CodeFirstBasic.Contract.Repositories.Entities
{
	public class Product : BaseEntity
	{
		public string ProductId { get; set; } = string.Empty;
		public string ProductName { get; set; } = string.Empty;
		public string? Description {  get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
	}
}
