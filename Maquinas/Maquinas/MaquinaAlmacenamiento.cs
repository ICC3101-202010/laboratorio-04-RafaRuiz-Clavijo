using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaAlmacenamiento: BaseMaquinas , MachineMemoryRestart
    {
        public MaquinaAlmacenamiento(int memory)
        {
            this.memory = memory;
            this.contador = 0;
        }
        public int ResetCount()
        {
            Console.WriteLine("La maquina de almacenamiento se reinicio con exito");
            return 0;
        }

        public override void Off()
        {
            Console.WriteLine("La maquina de almacenamiento se apago");
            System.Threading.Thread.Sleep(1000);
        }

        public override void On()
        {
            Console.WriteLine("La maquina de almacenamiento se encendio");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de almacenamiento esta colapsada, se va a reiniciar");
            contador = ResetCount();
        }
    }
}
