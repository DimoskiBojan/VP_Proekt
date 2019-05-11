using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt
{
    public class Stavka
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public Stavka()
        {
           
        }

        public Stavka(string n, string cat)
        {
            Name = n;
            Category = cat;
        }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
