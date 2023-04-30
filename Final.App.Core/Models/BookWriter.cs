

using Final.App.Core.Models.BaseModels;

namespace Final.App.Core.Models
{
    public class BookWriter:BaseModel
    {
        private int _id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public List<Book> Book { get; set;}
    }
}
