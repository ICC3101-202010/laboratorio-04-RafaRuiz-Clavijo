using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaEnsamblaje: BaseMaquinas
    {
        public MaquinaEnsamblaje(int memory, bool necesita_reparo)
        {
            this.memory = memory;
            this.necesita_reparo = necesita_reparo;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de ensamblaje se apago");
            System.Threading.Thread.Sleep(1000);
        }

        public override void On()
        {
            Console.WriteLine("La maquina de ensamblaje se encendio");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de ensamblaje esta colapsada, se va a reinciar la memoria");
        }
    }
}
