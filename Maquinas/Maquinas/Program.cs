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
            CPU_Central ia = new CPU_Central();
            Console.WriteLine("Elija estado de su computador central: ");
            Console.WriteLine("1) Control Automatico -> Elija esta opcion si su PC central esta en buen estado");
            Console.WriteLine("2) Control Manual -> Elija esta opcion si su PC central esta en mal estado");
            Console.WriteLine("Escoja con un numero: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            ia.StartWork();
            if (opt == 1)
            {
                ia.AutomaticWorkTime();
            }
            else
            {
                ia.ManualWork();
            }
            ia.EndWork();

        }
    }
}
