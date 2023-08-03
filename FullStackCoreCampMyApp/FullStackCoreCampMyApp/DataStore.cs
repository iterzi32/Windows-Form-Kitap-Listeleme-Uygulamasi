using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackCoreCampMyApp
{
     class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, UserName = "Admin", Password = "1234"};
        public static List<Book> Books = new List<Book>()
        {
            new Book{Id = 1, Title = "Uçurtma Avcısı"},
            new Book{Id = 2, Title = "Sefiller"},
            new Book{Id = 3, Title = "Osmancık"},
            new Book{Id = 4, Title = "Devlet Ana"}
        };
    }
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
