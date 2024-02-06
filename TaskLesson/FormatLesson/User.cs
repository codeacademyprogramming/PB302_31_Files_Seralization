using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatLesson
{
    [Serializable]
    public class User
    {
        public string Name;
        public string Surname { get; set; }
        public byte Age;

        public override string ToString()
        {
            return Name+"-"+Surname+"-"+Age;
        }
    }
}
