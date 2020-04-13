using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaAlmacenamiento: BaseMaquinas 
    {
        public MaquinaAlmacenamiento(int memory)
        {
            this.memory = memory;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de almacenamiento se apago");
        }

        public override void On()
        {
            Console.WriteLine("La maquina de almacenamiento se encendio");
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de almacenamiento esta colapsada, se va a reinciar la memoria");
        }
    }
}
