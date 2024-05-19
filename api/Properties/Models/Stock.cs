using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Stocks")]
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;  //Chuỗi trống để tránh value null
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();  //mqh 1 - N giữa 'Stock' và 'Comment'. Được khởi tạo thành một danh sách trống để tránh các vấn đề về tham chiếu rỗng.
        //public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    }
}
