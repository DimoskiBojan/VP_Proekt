using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt
{
    public class Stavka
    {
        public string Name { get; set; }

        public string Category { get; set; }
        public Image image { get; set; }
        public string description { get; set; }

        public Stavka()
        {
           
        }

        public Stavka(string n, string cat, Image image, string description)
        {
            Name = n;
            Category = cat;
            this.image = image;
            this.description = description;
        }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
