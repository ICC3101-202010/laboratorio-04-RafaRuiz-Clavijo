using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaVerificacion: BaseMaquinas, MachineMemoryRestart
    {
        public MaquinaVerificacion(int memory)
        {
            this.memory = memory;
            this.contador = 0;
        }

        public int ResetCount()
        {
            Console.WriteLine("La maquina de verificacion se reinicio con exito");
            return 0;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de verificacion se apago");
            System.Threading.Thread.Sleep(1000);
        }

        public override void On()
        {
            Console.WriteLine("La maquina de verificacion se encendio");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de verificacion esta colapsada, se va a reiniciar");
            contador = ResetCount();
        }
    }
}
