using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1CSHarp.UteisMenu
{
    public class Ordenador
    {
        public static int[] Ordenacao(int[] _vetor)
        {
            int _tamanhoLista = _vetor.Length;
            for (int i = 1; i < _tamanhoLista; i++)
            {
                int _ponteiro = _vetor[i];
                int j = i - 1;

                // Move os elementos do vetor que são maiores que o ponteiro para uma posição à frente da sua posição atual.
                while (j >= 0 && _vetor[j] > _ponteiro)
                {
                    _vetor[j + 1] = _vetor[j];
                    j = j - 1;
                }
                _vetor[j + 1] = _ponteiro;
            }
            return _vetor;
        }
    }
}
