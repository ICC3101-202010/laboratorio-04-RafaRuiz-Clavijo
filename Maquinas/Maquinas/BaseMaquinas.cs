using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    abstract class BaseMaquinas
    {

        public int memory;
        public bool necesita_reparo;

        abstract public void On();
        abstract public void Restart();
        abstract public void Off();


    }
}
