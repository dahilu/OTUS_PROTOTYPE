using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_PROTOTYPE
{
    // Интерфейс IMyCloneable с обобщенным типом T
    public interface IMyCloneable<T>
    {
        T MyClone();
    }
}
