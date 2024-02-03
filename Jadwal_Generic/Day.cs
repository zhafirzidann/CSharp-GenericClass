using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadwal_Generic
{
    class Day<T>
    {
        public T value;

        public Day(T parameter)
        {
            this.value = parameter;
        }
    }
}
