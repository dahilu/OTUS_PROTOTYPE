using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_PROTOTYPE
{
    // Класс Стул со спинкой, наследуемый от Стул и реализующий ICloneable и IMyCloneable
    public class ChairWithBackrest : Chair, IMyCloneable<ChairWithBackrest>, ICloneable
    {
        public bool HasSoftBackrest { get; set; }

        public ChairWithBackrest(string color, string factoryName, int legCount, bool hasSoftBackrest)
            : base(color, factoryName, legCount)
        {
            HasSoftBackrest = hasSoftBackrest;
        }

        public new ChairWithBackrest MyClone()
        {
            return new ChairWithBackrest(Color, FactoryName, LegCount, HasSoftBackrest);
        }

        public new object Clone()
        {
            return MyClone();
        }
    }
}
