using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaEmpaque : BaseMaquinas , MachineMemoryRestart
    {
        public MaquinaEmpaque(int memory)
        {
            this.memory = memory;
            this.contador = 0;
        }

        public int ResetCount()
        {
            Console.WriteLine("La maquina de empaque se reinicio con exito");
            return 0;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de empaque se apago");
            System.Threading.Thread.Sleep(1000);
        }

        public override void On()
        {
            Console.WriteLine("La maquina de empaque se encendio");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de empaque esta colapsada, se va a reiniciar");
            contador = ResetCount();
        }
    }
}
