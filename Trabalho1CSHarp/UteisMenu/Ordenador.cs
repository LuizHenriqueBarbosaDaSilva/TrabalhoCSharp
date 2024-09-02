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
            // Usando o insertion sort para organizar o vetor!
            int _tamanhoLista = _vetor.Length; // passa o tamanho do vetor para uma variavel
            for (int i = 1; i < _tamanhoLista; i++) // laço contado onde o i, contando o laço enquanto o i for menor que _tamanhoLista! 
            {
                int _ponteiro = _vetor[i]; // _´ponteiro recebe o item acima de j para confirmar se ele esta numa ordem crescente!
                int j = i - 1; // define o j como i -1 então i sempre vai estar a frente

                // Move os elementos do vetor que são maiores que o ponteiro para uma posição à frente da sua posição atual.
                while (j >= 0 && _vetor[j] > _ponteiro) // Se o j for maior ou igual a 0 e o _vetor[j] for maior que o ponteiro então continua o loop!
                {
                                                // Vetor exemplo [8,3,1,4], j = 0, i = 1, _ponteiro = 3
                    _vetor[j + 1] = _vetor[j]; // dado o exemplo acima ira ajustar os item como visto _vetor[j + 1] = 3,vetor[j] = 8 então vetor[j+1] passa a ser 8 
                    j = j - 1;                // aqui j vai ser diminuido ate quebrar o loop quando ficar menor quer 0 mas enquanto isso ele vai reajustando as posições!
                }                
                _vetor[j + 1] = _ponteiro; // e o ponteiro que armazenou a posição vetor[j+1] tem 3 e coloca o na posição 0, ja que j = 0! exemplo: vetor[-1 + 1]
            }
            
            return _vetor; // Retorna o vetor organizado!
        }
    }
}
