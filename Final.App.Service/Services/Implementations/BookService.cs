using Final.App.Core.Enums;
using Final.App.Core.Models;
using Final.App.Data.Repositories.Books;
using Final.App.Service.Services.Interfaces;
using System.Text.RegularExpressions;

namespace Final.App.Service.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly static BookRepository _repository = new BookRepository();
       public async Task<string>CreateAsync(string name,double price,double discountprice  )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.IsNullOrWhiteSpace(name))
                return "Add valid name";
            if (double.TryParse(name, out price))
                return "Add valid price";
            if (double.TryParse(name, out discountprice))
                return "Add valid discountprice";

            Console.ForegroundColor = ConsoleColor.Green;
                 Book book=new Book(name, price, discountprice);
           await _repository.AddAsync(book);
            return "Successfully created";
              
        }

        public async Task<string> DeleteAsync(int id)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Book book = await _repository.GetAsync(book=>book.Id==id);
            if (book == null)
                return "Book not found";
            await _repository.RemoveAsync(book);
            Console.ForegroundColor = ConsoleColor.Green;
            return "Succes";

        }

        public async Task GetAllAsync()
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            foreach(var item in  await _repository.GetAllAsync())
            {
                Console.WriteLine(item);
            }
        }

        public async Task<List<BookWriter>> GetAllBookWriterAsync(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Book book = await _repository.GetAsync(book => book.Id == id);
            if(book == null)
            {
                Console.WriteLine("Book not found");
                return null;
            }
            return book.BookWriter;
        }

        public Task<Book> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        Task<string> IBookService.CreateAsync(string name, double price, double discountprice)
        {
            throw new NotImplementedException();
        }
    }
}
