using Trabalho1CSHarp.UteisMenu;
// 7) Fatoriais de 1 até 10 (Equipe 4 Método com retorno / Ordenar vetor de N elementos Método estático)
int op32 = 0;

do
{
    Console.Write($"""
        +-=-=-=-=-=-=-=-=-=+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        | Menu             | Bem Vindo!                   |
        +-=-=-=-=-=-=-=-=-=+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        | 0) Sair                                         |
        | 1) Acessar Somar Numeros                        |
        | 2) Acessar Conversão de metros a milimetros     |
        | 3) Acessar Fatorias                             |
        | 4) Acessar Ordenar vetor de N elementos         |  
        | 5) Acessar JOGO DA VELHA: A REDENÇÃO 3000 Tm    |
        |                                                 |
        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        Informe sua entrada:
        """);
    op32 = int.Parse(Console.ReadLine());
    switch (op32)
    {
        case 0:
            Console.WriteLine("Fechando o programa");
            Thread.Sleep(2000);
            Console.Clear();
            break;
        case 1:
            Console.WriteLine("Acessando Soma!");
            break;
        case 2:
            Console.WriteLine("Acessando Conversão");
            break;
        case 3:
            Console.WriteLine("Acessando Fatorias!");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"O fatorial de {i} é:{Fatorial.CalcularFatorial(i)}\n");
            }
            Thread.Sleep(5000);
            Console.Clear();
            break;
        case 4:
            Console.WriteLine("Acessando Ordenador de vetores");
            break;
        case 5:
            Console.WriteLine("Acessando JOGO DA VELHA: A REDENÇÃO 3000 Tm");
            break;
    }


} while (op32 != 0);
