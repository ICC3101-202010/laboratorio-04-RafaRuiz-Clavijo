using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    abstract class BaseMaquinas
    {

        private int memory;

        abstract public void On();
        abstract public void Restart();
        abstract public void Off();


    }
}
