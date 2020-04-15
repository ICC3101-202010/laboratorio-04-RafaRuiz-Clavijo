using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaRecepcion : BaseMaquinas
    {
        public MaquinaRecepcion(int memory, bool necesita_reparo)
        {
            this.memory = memory;
            this.necesita_reparo = necesita_reparo;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de recepcion se apago");
            System.Threading.Thread.Sleep(1000);
        }

        public override void On()
        {
            Console.WriteLine("La maquina de recepcion se encendio");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de recepcion esta colapsada, se va a reinciar la memoria");
        }
    }
}
