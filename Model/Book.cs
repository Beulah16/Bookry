using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bookry.Model
{
    public class Book
    {
        public string Id { get; set; }
        public string Author { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Book>(this);
    }

}
