using Bookry.Model;
using System.Text.Json;

namespace Bookry.Services
{
    public class JsonFileBookService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json"); }
        }

        public IEnumerable<Book> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName)) 
            {
                return JsonSerializer.Deserialize<Book[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
