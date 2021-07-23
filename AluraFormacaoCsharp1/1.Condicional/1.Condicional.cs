using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Logica
{
    public class Condicional
    {
        public void CondicionalIf()
        {       
             double salario = 4000.0;

            if (salario >= 1900 && salario <=2800)
            {
                Console.WriteLine("IR é de 7.5% e pode deduzir R$ 142");
            }
            if (salario >= 2800.01 && salario <= 3751)
            {
                Console.WriteLine("IR é de 15% e pode deduzir R$ 350");
            }
            if (salario >= 3751.01 && salario <= 4664)
            {
                Console.WriteLine("IR é de 22.5% e pode deduzir R$ 636");
            }
        }
    }
}
