using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormatLessonNew
{
    public class User
    {
        //[JsonInclude]
        //[JsonPropertyName("username")]
        //public string Name;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public override string ToString()
        {
            return Name + "-" + Surname + "-" + Age;
        }
    }
}
