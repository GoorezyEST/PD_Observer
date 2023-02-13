using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_PD
{
    // Observer interface
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
