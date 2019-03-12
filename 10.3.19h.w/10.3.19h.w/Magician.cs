using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3._19h.w
{
    class Magician:IComparable<Magician>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthTown, string favoriteSpell)
        {
            Name = name;
            BirthTown = birthTown;
            FavoriteSpell = favoriteSpell;
        }
        public string this[string n]
        {
            get
            {
                if (n == "Name")
                {
                    return this.Name;
                }
                if (n == "BirthTown")
                {
                    return this.BirthTown;
                }
                if (n == "FavoriteSpell")
                {
                    return this.FavoriteSpell;
                }
                
                    return "UnKnown";
            }
            set
            {
                if (n == "Name")
                {
                    this.Name=value;
                }
                if (n == "BirthTown")
                {
                    this.BirthTown=value;
                }
                if (n == "FavoriteSpell")
                {
                    this.FavoriteSpell=value;
                }
            }
        }

        public override string ToString()
        {
            return $"Magician {this.Name}, Birth town:{this.BirthTown},Favorite Spell:{this.FavoriteSpell}";
        }

        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other);
        }
    }
}
