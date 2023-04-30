

using Final.App.Core.Models;

namespace Final.App.Service.Services.Interfaces
{
    public interface IBookService
    {
        public Task<string> CreateAsync(string name, double price, double discountprice);
        public Task<string>DeleteAsync( int id);
        public Task<string> UpdateAsync( );
        public Task<Book> GetAsync();
        public Task GetAllAsync( );
        public Task<List< BookWriter>> GetAllBookWriterAsync(int id);

    }
}
