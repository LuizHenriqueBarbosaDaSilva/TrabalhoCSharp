using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1CSHarp.UteisMenu
{
    public class Fatorial()
    {
        // Fatorial do Luiz
        public int CalcularFatorialFOR(int _num1) // tem o argumento _num1 que ira ser usado para fazer o fatorial!
        {
            if (_num1 == 1) // como e de 1 ate 10 e so retornamos 1 caso o numero passado para o argumento seja 1 então entra nessa condição!
            {
                return _num1; // Retorna 1
            }
            else // Se argumento passado não for igual a 1 então entra nessa condição!
            {
                return _num1 * CalcularFatorialFOR(_num1 - 1); // Usando a recursividade nos conseguimos fazer o fatorial!
            }
        }
        // Fatorial do Weber
        public string CalcularFatorial(int _numero) // Tem o argumento _numero que ira ser usado para fazer o fatorial!
        {
            if (_numero < 0)
            {
                return "O número não pode ser negativo."; // Retorna uma mensagem avisando que o numero nao pode ser negativo!

            }
            else
            {
                int _fatorial = 1; // Aqui o _fatorial e 1.
                for (int i = 2; i <= _numero; i++)  // então i sera 2 e ira se acresentar ate ser maior ou igual o numero dado.
                {
                    _fatorial *=  i; // Fatorial se automultiplica com i assim levando ao resultado de um fatorial.
                }
                return _fatorial.ToString(); // depois do for _fatorial e retornado como string!
            }
        }
    }
}
