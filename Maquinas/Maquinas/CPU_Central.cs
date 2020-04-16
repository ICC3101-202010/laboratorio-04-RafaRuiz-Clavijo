using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquinas
{
    public class CPU_Central
    {
        MaquinaRecepcion maqrec = new MaquinaRecepcion(5);
        MaquinaAlmacenamiento maqalm = new MaquinaAlmacenamiento(8);
        MaquinaEnsamblaje maqes = new MaquinaEnsamblaje(3);
        MaquinaEmpaque maqem = new MaquinaEmpaque(6);
        MaquinaVerificacion maqver = new MaquinaVerificacion(7);
        public void StartWork()
        {
            maqrec.On();
            maqalm.On();
            maqes.On();
            maqem.On();
            maqver.On();
        }

        public void AutomaticWorkTime()
        {
            Console.WriteLine();

            int hora = 8;
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
                    maqrec.contador += 1;
                    maqalm.contador += 1;
                    maqes.contador += 1;
                    maqem.contador += 1;
                    maqver.contador += 1;
                    if (maqrec.contador >= maqrec.memory)
                    {
                        maqrec.Restart();
                        verificador = 0;
                    }
                    if (maqalm.contador >= maqalm.memory)
                    {
                        maqalm.Restart();
                        verificador = 0;
                    }
                    if (maqes.contador >= maqes.memory)
                    {
                        maqes.Restart();
                        verificador = 0;
                    }
                    if (maqem.contador >= maqem.memory)
                    {
                        maqem.Restart();
                        verificador = 0;
                    }
                    if (maqver.contador >= maqver.memory)
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

        }

        public void ManualWork()
        {
            Console.WriteLine();

            int hora = 8;
            int verificador = 1;
            while (hora < 22)
            {
                int minutos = 0;
                while (minutos < 60)
                {
                    if (minutos != 0)
                    {
                        Console.WriteLine("Hora actual: " + hora + ":" + minutos);
                    }
                    else
                    {
                        Console.WriteLine("Hora actual: " + hora + ":0" + minutos);
                    }
                    maqrec.contador += 1;
                    maqalm.contador += 1;
                    maqes.contador += 1;
                    maqem.contador += 1;
                    maqver.contador += 1;
                    if (maqrec.contador >= maqrec.memory || maqalm.contador >= maqalm.memory || maqes.contador >= maqes.memory || maqem.contador >= maqem.memory || maqver.contador >= maqver.memory)
                    {
                        verificador = 0;
                    }
                    if (verificador == 0)
                    {
                        Console.WriteLine("Hay una maquina en mal estado, Desea verificar el estado de las maquinas?");
                        Console.WriteLine("1) YES");
                        Console.WriteLine("2) NO");
                        Console.WriteLine("Marque el numero de la opcion");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        if (opt == 1)
                        {
                            int term = 1;
                            while (term == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Maquina");
                                Console.WriteLine("1) Recepcion");
                                Console.WriteLine("2) Almacenamiento");
                                Console.WriteLine("3) Ensamblaje");
                                Console.WriteLine("4) Empaque");
                                Console.WriteLine("5) Verificacion");
                                Console.WriteLine("Elija el numero de la maquina a reiniciar: ");
                                int opt2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (opt2 == 1)
                                {
                                    if (maqrec.contador >= maqrec.memory)
                                    {
                                        maqrec.Restart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esta maquina esta en buen estado");
                                    }
                                }
                                if (opt2 == 2)
                                {
                                    if (maqalm.contador >= maqalm.memory)
                                    {
                                        maqalm.Restart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esta maquina esta en buen estado");
                                    }
                                }
                                if (opt2 == 3)
                                {
                                    if (maqes.contador >= maqes.memory)
                                    {
                                        maqes.Restart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esta maquina esta en buen estado");
                                    }
                                }
                                if (opt2 == 4)
                                {
                                    if (maqem.contador >= maqem.memory)
                                    {
                                        maqem.Restart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esta maquina esta en buen estado");
                                    }
                                }
                                if (opt2 == 5)
                                {
                                    if (maqver.contador >= maqver.memory)
                                    {
                                        maqver.Restart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esta maquina esta en buen estado");
                                    }
                                }

                                Console.WriteLine();
                                Console.WriteLine("Quiere revisar el estado de otra maquina?");
                                Console.WriteLine("1) Si");
                                Console.WriteLine("2) No");
                                Console.WriteLine("Indique el numero de la opcion");
                                term = Convert.ToInt32(Console.ReadLine());
                                if (maqrec.contador < maqrec.memory && maqalm.contador < maqalm.memory && maqes.contador < maqes.memory && maqem.contador < maqem.memory && maqver.contador < maqver.memory)
                                {
                                    verificador = 1;
                                }
                            }



                        }
                    }
                    else
                    {
                        Console.WriteLine("Todas las maquinas estan en buen estado");
                    }
                    minutos += 15;
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1000);
                }
                hora += 1;
            }
        }

        public void EndWork()
        {
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
