using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_PROTOTYPE
{
    // Класс Мебель, реализующий ICloneable и IMyCloneable
    public class Furniture : IMyCloneable<Furniture>, ICloneable
    {
        public string Color { get; set; }
        public string FactoryName { get; set; }

        public Furniture(string color, string factoryName)
        {
            Color = color;
            FactoryName = factoryName;
        }

        public Furniture MyClone()
        {
            return new Furniture(Color, FactoryName);
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
