using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1CSHarp.UteisMenu
{
    public class Fatorial()
    {
        public static int CalcularFatorial(int _num1)
        {
            if (_num1 == 1)
            {
                return _num1;
            }
            else
            {
                return _num1 * CalcularFatorial(_num1 - 1);
            }
        }
    }
}
