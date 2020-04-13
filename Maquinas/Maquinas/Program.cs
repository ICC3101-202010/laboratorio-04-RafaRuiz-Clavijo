using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaRecepcion maqrec = new MaquinaRecepcion(5);
            maqrec.On();
            MaquinaAlmacenamiento maqalm = new MaquinaAlmacenamiento(8);
            maqalm.On();
            MaquinaEnsamblaje maqes = new MaquinaEnsamblaje(3);
            maqes.On();
            MaquinaEmpaque maqem = new MaquinaEmpaque(6);
            maqem.On();
            MaquinaVerificacion maqver = new MaquinaVerificacion(7);
            maqver.On();

            Console.WriteLine();

            int hora = 8;
            int step = 0;
            while (hora < 22)
            {
                int minutos = 0;
                while (minutos < 60)
                {
                    int verificador = 1;
                    if (minutos != 0)
                    {
                        Console.WriteLine("Hora actual: " + hora + ":" + minutos);
                    }
                    else
                    {
                        Console.WriteLine("Hora actual: " + hora + ":0" + minutos);
                    }
                    step++;
                    if (step%maqrec.memory == 0)
                    {
                        maqrec.Restart();
                        verificador = 0;
                    }
                    if (step % maqalm.memory == 0)
                    {
                        maqalm.Restart();
                        verificador = 0;
                    }
                    if (step % maqes.memory == 0)
                    {
                        maqes.Restart();
                        verificador = 0;
                    }
                    if (step % maqem.memory == 0)
                    {
                        maqem.Restart();
                        verificador = 0;
                    }
                    if (step % maqver.memory == 0)
                    {
                        maqver.Restart();
                        verificador = 0;
                    }
                    if (verificador == 1)
                    {
                        Console.WriteLine("Todas las maquinas trabajan con regularidad");
                    }
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                    minutos += 15;

                }
                hora += 1;
            }

            Console.WriteLine("22:00 Hora de cerrar la fabrica");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            maqrec.Off();
            maqalm.Off();
            maqes.Off();
            maqem.Off();
            maqver.Off();
            System.Threading.Thread.Sleep(3000);

        }
    }
}
