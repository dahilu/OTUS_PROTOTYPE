using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_PROTOTYPE
{
    // Класс Стул, наследуемый от Мебель и реализующий ICloneable и IMyCloneable
    public class Chair : Furniture, IMyCloneable<Chair>, ICloneable
    {
        public int LegCount { get; set; }

        public Chair(string color, string factoryName, int legCount)
            : base(color, factoryName)
        {
            LegCount = legCount;
        }

        public new Chair MyClone()
        {
            return new Chair(Color, FactoryName, LegCount);
        }

        public new object Clone()
        {
            return MyClone();
        }
    }
}
