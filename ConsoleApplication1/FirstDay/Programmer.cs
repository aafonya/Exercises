using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Coder
    {
        //referenciát fog visszaadni a létrejött példányra
        //memóriahelyet foglal a fieldeknek -> beállítja az értéket
        public Coder(string name)
        {
            Name = name;
        }
        //overload
        public Coder(string name, Language favouriteLanguage) : this(name)
        {
            this.favouriteLanguage = favouriteLanguage;
        }

        public Coder(string name, string language) : this("John Doe", (Coder.Language)Enum.Parse(typeof(Coder.Language), language, true))
        {

        }

        public override string ToString()
        {

            return base.ToString();
        }
        public enum Language { Ruby, Csharp, Cpp, Java, Python}

        double energyLevel; //0.0 - 1.0
        Language favouriteLanguage;

        public string Name { get; set; }

        public double EnergyLevel
        {
            get
            {
                return energyLevel;
            }

            set
            {
                energyLevel = Math.Max(Math.Min(value, 1.0), 0.0);
                //if(value >= 0.0 && value <= 1.0)
                //    {
                //    energyLevel = value;
                //}
                
            }
        }

        internal Language FavouriteLanguage
        {
            get
            {
                return favouriteLanguage;
            }

            set
            {
                favouriteLanguage = value;
            }
        }

        public void Sleep(int hours)
        {
            if(hours >= 3)
            {
                energyLevel *= 2;
            }
        }

        public bool Work(int hours)
        {
            if(hours >= 8)
            {
                energyLevel *= 0.5;
                return true;
            }
            return false;
        }

        public bool Work(int hours, bool productive)
        {
            return (hours >= 8 && productive);
        }

        //public int Work(int hours)
        //{
        //    return 10;
        //}
    }
}
