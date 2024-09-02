using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1CSHarp.UteisMenu
{
    public class Fatorial()
    {
        public static int CalcularFatorial(int _num1) // tem o argumento _num1 que ira ser usado para fazer o fatorial!
        {
            if (_num1 == 1) // como e de 1 ate 10 e so retornamos 1 caso o numero passado para o argumento seja 1 então entra nessa condição!
            {
                return _num1; // Retorna 1
            }
            else // Se argumento passado não for igual a 1 então entra nessa condição!
            {
                return _num1 * CalcularFatorial(_num1 - 1); // Usando a recursividade nos conseguimos fazer o fatorial!
            }
        }
    }
}
