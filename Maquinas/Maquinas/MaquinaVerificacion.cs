using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class MaquinaVerificacion: BaseMaquinas
    {
        public MaquinaVerificacion(int memory, bool necesita_reparo)
        {
            this.memory = memory;
            this.necesita_reparo = necesita_reparo;
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
            Console.WriteLine("La maquina de verificacion esta colapsada, se va a reinciar la memoria");
        }
    }
}
