using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaEnsamblaje: BaseMaquinas, MachineMemoryRestart
    {
        public MaquinaEnsamblaje(int memory)
        {
            this.memory = memory;
            this.contador = 0;
        }
        public int ResetCount()
        {
            Console.WriteLine("La maquina de ensamblaje se reinicio con exito");
            return 0;
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
            Console.WriteLine("La maquina de ensamblaje esta colapsada, se va a reiniciar");
            contador = ResetCount();
        }
    }
}
