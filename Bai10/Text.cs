using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public class Text
    {
        public string characters { get; set; }

        public Text()
        {
        }

        public Text(string characters)
        {
            this.characters = characters;
        }
        public override string ToString()
        {
            return "Text: " + this.characters;
        }
    }
}
