using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookry.Model;
using Bookry.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookry.Pages
{
    public class BookModel : PageModel
    {
        public JsonFileBookService BookService;
        public IEnumerable<Book> Books { get; private set; }
        public BookModel(JsonFileBookService bookService)
        {
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.GetProducts();
        }
    }
}