using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaVerificacion: BaseMaquinas
    {
        public MaquinaVerificacion(int memory)
        {
            this.memory = memory;
        }
        public override void Off()
        {
            Console.WriteLine("La maquina de verificacion se apago");
        }

        public override void On()
        {
            Console.WriteLine("La maquina de verificacion se encendio");
        }

        public override void Restart()
        {
            Console.WriteLine("La maquina de verificacion esta colapsada, se va a reinciar la memoria");
        }
    }
}
