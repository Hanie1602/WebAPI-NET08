using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;     //Ngày và giờ hiện tại
        public int? StockId { get; set; }   //khóa ngoại của 'Stock', int?: nó có thể null
        public Stock? Stock { get; set; }   //mối quan hệ giữa Commentvà Stock. Stock?: có thể null
        //public string AppUserId { get; set; }
        //public AppUser AppUser { get; set; }
    }
}
