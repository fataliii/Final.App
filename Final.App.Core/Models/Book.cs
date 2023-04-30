

using Final.App.Core.Enums;
using Final.App.Core.Models.BaseModels;
using System.Globalization;

namespace Final.App.Core.Models
{
    public class Book : BaseModel
    {
        private static int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public BookCategory Category { get; set; }
        public BookWriter BookWriter { get; set; }
        

        public Book(string name,double price,double discountPrice,BookCategory category,BookWriter bookWriter) 
        
        {
            _id++;
            Id = _id;
            Name=name;
            Price = price;
            DiscountPrice = discountPrice;
            
            CreatedDate = DateTime.UtcNow.AddHours(4);
            Category = category;
            BookWriter = bookWriter; 
        }

        public Book(string name, double price, double discountprice)
        {
            Name = name;
            Price = price;
            DiscountPrice = discountprice;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, DiscountPrice: {DiscountPrice},CreatedDate {CreatedDate},UpdatedDate {UpdatedDate}";
        }
    }
}
