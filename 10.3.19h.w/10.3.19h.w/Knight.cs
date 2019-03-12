using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3._19h.w
{
    class Knight:IComparable<Knight>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }

        public string this[string n]
        {
            get
            {
                if (n == "Name")
                {
                    return this.Name;
                }
                else if (n == "BirthTown")
                {
                    return this.BirthTown;
                }
                else if (n == "Title")
                {
                    return this.Title;
                }
                else
                    return "UnKnown";
            }
            set
            {
                n = value;
            }
        }

        public override string ToString()
        {
            return $"Knight {this.Name}, Birth town:{this.BirthTown},Title:{this.Title}";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other);
        }
    }
}
