using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Core.Base
{
	public abstract class BaseEntity
	{
		protected BaseEntity()
		{
			Id = Guid.NewGuid().ToString("N");
			CreatedTime = LastUpdatedTime = DateTimeOffset.Now;
		}

		[Key]
		public string Id { get; set; }
		public string? CreateBy { get; set; }
		public string? LastUpdateBy { get; set; }
		public string? DeleteBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }
	}
}
