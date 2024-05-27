using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApiNetCore8.Data
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(100)]    //100 ký tự
        public string? Title { get; set; }
        public string? Description { get; set; }    //cho phép null
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }

    }
}
