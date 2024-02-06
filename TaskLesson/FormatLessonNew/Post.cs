using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormatLessonNew
{
    internal class Post
    {
        [JsonPropertyName("id")]
        public int Id { get;set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
        [JsonIgnore]
        public int Age { get; set; }

        public override string ToString()
        {
            return Id.ToString() +"-"+ Title+"-" + Body;
        }
    }
}
