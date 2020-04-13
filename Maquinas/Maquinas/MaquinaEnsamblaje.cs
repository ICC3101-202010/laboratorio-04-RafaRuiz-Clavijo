using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaEnsamblaje: BaseMaquinas
    {
        public MaquinaEnsamblaje(int memory)
        {
            this.memory = memory;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de ensamblaje se apago");
        }

        public override void On()
        {
            Console.WriteLine("La maquina de ensamblaje se encendio");
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de ensamblaje esta colapsada, se va a reinciar la memoria");
        }
    }
}
