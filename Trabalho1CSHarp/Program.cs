using System.Numerics;
using Trabalho1CSHarp.UteisMenu;
// 7) Fatoriais de 1 até 10 (Equipe 4 Método com retorno / Ordenar vetor de N elementos Método estático)
int op32 = 0;

do // Usando a estrutura de loop do {} while(condição);
{
    Console.Clear(); // Limpa a  a cada conclusao do loop apos usar um metodo ou errar o digito
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
        | 6) Creditos aos desenvolvedores                 |
        |                                                 |
        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        Informe sua entrada:
        """);
    op32 = int.Parse(Console.ReadLine());
    switch (op32)
    {
        // Se op32 == 0 ira encerrar o programa.
        case 0:
            Console.WriteLine("Fechando o programa"); // Avisa que ira fechar o programa
            Thread.Sleep(2000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 2 mil equivale a 2 segundos
            break;
        // Se a op32 == 1 acessara a classe para somar numeros.
        case 1:
            Console.WriteLine("Acessando Soma!"); // Avisa o usuario que esta acessando a classe  Soma.
            break;
        // Se op32 == 2 acessara a classe da conversão para converter metodos em milimetros.
        case 2:
            Console.WriteLine("Acessando Conversão"); // Avisa o usuario que esta acessando a classe  Conversão.
            break;
        // Se op32 == 3 acessara a classe fatorial para fatorar.
        case 3:
            Console.WriteLine("Acessando Fatorias!"); // Avisa o usuario que esta acessando a classe Fatorial
            for (int i = 1; i < 11; i++) // laço contado de 1 ate 10!
            {
                Console.Write($"O fatorial de {i} é:{Fatorial.CalcularFatorial(i)}\n"); // Mostra para o usuario fatorial de 1 ate 10.
            }
            Thread.Sleep(5000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 5 mil equivale a 5 segundos.
            break;
        // Se op32 == 4 acessara a classe Ordenador de vetores para ordernar.
        case 4:
            Console.WriteLine("Acessando Ordenador de vetores"); // Avisa o usuario que esta acessando a classe Ordenador.
            Console.Write("Informe o tamanho da lista:"); // Pede para o usuario informar o tamanho da vetor!
            int n = int.Parse(Console.ReadLine()); // a varivavel n ira se tornar o valor informado
            while (true) // aqui começa um loop com um while para informar os numeros da vetor com um limite de n, itens dentro da vetor. 
            {
                int[] vetorFora = new int[n]; // Aqui cria o vetor apartir da variavel n!                                       tamanho do vetor: 6!
                Console.Write("\nInforme os numeros agora todos juntos:"); // Informa ao usuario que ele precisa dar todos os valores exemplo: 7 8 1 4 5 6.
                String[] caixa = Console.ReadLine().Split(' '); // caixa ira separar os numeros em itens devido ao split() que tem um espaço vazio " ".
                if (caixa.Length == n) // se caixa.Lenght for igual a n então entra na condição.
                {
                    for (int i = 0; i < n; i++) // laço contado de i ate n!
                    {
                        vetorFora[i] = int.Parse(caixa[i]); // passa os valor de caixa[i] para o vetorFora tornando os inteiros antes de passar
                    }
                    int[] vetorOrdenado = Ordenador.Ordenacao(vetorFora); // passa o vetorFora para dentro do metodo Ordenacao() e quando for concluido passa o vetor;
                                                                         // ordenado para uma nova variavel tipo vetor, nomeada vetorOrdenado! 
                    Console.Write("Vetor Ordenado -> ["); // aqui começar a exibição dos itens dentro da lista.
                    for (int i = 0; i < vetorOrdenado.Length; ++i) // laço contado de i ate vetorOrdenado.Length. Nota: Length pega o tamanho do vetor!
                    {
                        Console.Write($"{vetorOrdenado[i]}"); // aqui ira printar os itens do vetor a cada passo
                        if (i != vetorOrdenado.Length - 1)   // se o vetorOrdenado for diferente da ultima posição ira imprimir uma ","
                        {
                            Console.Write(","); // imprimi a ","
                        }
                    }
                    Console.Write("]"); // no fim do laço contado fecha a exibição da lista com "]" 
                    Thread.Sleep(10000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 10 mil equivale a 10 segundos.
                    Console.ReadLine();
                    break;
                }
                else // Se a condição de cima der falso então entra nessa
                {
                    Console.WriteLine("Foi dado mais numeros do que o permitido"); // Aqui avisa o usuario que os numeros foram alem do limite de N
                }
                
            }   
            break;
        // Se op32 == 5 acessara o Jogo da velha: A REDENÇÃO 3000 Tm
        case 5: 
            Console.WriteLine("Acessando JOGO DA VELHA: A REDENÇÃO 3000 Tm"); 
            Thread.Sleep(4000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 4 mil equivale a 4 segundos
            JogoDaVelha Joguinho = new JogoDaVelha(); // Faz com que o objeto Joguinho seja um objeto da classe JogoDaVelha();
            int op64, linha, coluna; // aqui definimos que op432,linha e coluna são inteiros assim so precisamos usa-las sem definirmos para frente
            var registroABC = new Dictionary<char, int> // Esse dicionario nos ajuda a fazer a marcação la embaixo por base das chaves serem o caracter e os numeros da linha virem depois
            {
                { 'A', 1 },
                { 'B', 2 },
                { 'C', 3 }
            };

            do // Usando a estrutura de loop do {} while(condição);
            {
                Console.Clear(); // Limpa a  a cada conclusao do loop apos usar um metodo ou errar o digito
                Joguinho.MenuDoJogo(); // Puxa o metodo do menu para ser executado com duas versões diferentes uma quando inicia a partida e outro quando inicia o programa em si
                op64 = int.Parse(Console.ReadLine()); // Op432 esta ligada diretamente com switch dando assim o menu para usar
                int marca = Joguinho._contadorPartidas; // a Marca server pra manter o menu atualizado ja que depois de uma incialização vai mostrar o novo menu onde mostra a cerdilha
                if (marca >= 9) // Se a marca chegar a 9 finaliza o programa 
                {
                    Console.WriteLine(">    O limite de partidas foi excedido renicie o programa ou espere 10 segundos para ver as estasticas!");
                    Thread.Sleep(10000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 10 mil equivale a 10 segundos
                    goto Fim; //  se a marca de partidas chegar a 9 ira pular tudo e ir direto ao final do programa assim encerrando ele
                }

                switch (op64)
                {
                    // Se op64 == 0 finaliza o programa
                    case 0: 
                        Console.WriteLine(">    Finalizando o programa!"); // Bem finaliza o programa
                        break;
                    // Se op64 == 1 Inicializa a partida ou renicializa a partida. Temos um contador no metodo IniciarOuReniciarJogo() que assim que fazer uma incialização todas as proximas
                    case 1: 
                            // contam como renicialização!
                        Joguinho.IniciarOuReniciarJogo(); // Chama o metodo IniciarOuReniciarJogo() para ser executado a partir do objeto Joguinho
                        break;
                    // Se op64 == 2 Ira poder selecionar o marcador do jogador somente depois de ser inciado a partida
                    case 2: 
                        if (marca != 0) // Se a marca for diferente de 0 então pode essa opção ser executada pois a cerquilha foi criada! 
                        {
                            Console.Write("Escolha um marcador entre X ou O: ");  // Pede para usuario fornecer X ou Y
                            string marcadorPlayer = Console.ReadLine().ToUpper(); // O marcadorPlayer ira receber do usuario se ele quer ser x ou y, caso o usuario esteja com o caps desativado;
                                                                                  // ira sempre ser usado o ToUpper()  que e um metodo para deixar tudo no uppercase!

                            while (marcadorPlayer != "X" && marcadorPlayer != "O") // Se o marcadorPlayer não for X nem Y então ele ira forçar a mudar ate que seja o desejado
                            {
                                Console.Write("Escolha novamente um marcador entre X ou O: "); // Avisa o usuario que fez uma escolha errada
                                marcadorPlayer = Console.ReadLine().ToUpper(); // marcadorPlayer continua a receber uma string ate que seja fornecido x ou y!
                            }
                            Joguinho.Jogadores(marcadorPlayer); // Chama o metodo Jogadores(marcadorPlayer) para definir o marcador do jogador e aproveitar para definir o marcador da Ia
                        }
                        else
                        {
                            Console.WriteLine(">    Não foi possivel fazer um ação devido cerquilha não existir!"); // Avisa que o usuario ainda não Iniciou Nenhuma partida!
                            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundos
                        }

                        break;
                    // Se op64 == 3 Então ira pedir para o usuario marcar sua posição e depois a ia ira marcar a dela no fim conferindo se houve um vencedor
                    case 3: 
                           // ou um empate!
                        if (marca != 0) // Se a marca for diferente de 0 então pode essa opção ser executada pois a cerquilha foi criada! 
                        {
                            while (true) // isso e so pra garantir que a linha e coluna sejam corretamente informados no padrao  (1-3) e (A-C)!
                            {
                                Console.Write("Informe a linha (1-3)  e a coluna (A-C) :");    // so informa o usuario para digitar entre (1-3) e (A-C).
                                string informacaoBox = Console.ReadLine().ToUpper();  // O informacaoBox ira receber do usuario se ele quer ser 1,2,3 junto de A,B,C;
                                                                                      // caso o usuario esteja com o caps desativado ira sempre ser usado o ToUpper();
                                                                                      // que e um metodo para deixar tudo no uppercase!  
                                char linhaChar = informacaoBox[1]; // Passa o primeiro o characther sendo (A,B,C)
                                int colunaNumero; // Passa o segundo o inteiro (1,2,3)
                                if (int.TryParse(informacaoBox[0].ToString(), out colunaNumero)) // Aqui o TryParse verifica se a string[0] tem um numero se tiver ira passar para colunaNumero.
                                {
                                    if (linhaChar == 'A' || linhaChar == 'B' || linhaChar == 'C') // Confere se linhaChar e A,B,C e entra na condição.
                                    {
                                        linha = registroABC[linhaChar] - 1;    // Como estamos trabalhando com matriz ela obdece a regra de sua contagem de item ser de 0 a 2;
                                                                               // se digitarmos 3 vai por exemplo dar 2 oque cabe na regra e nao confunde tanto o usuario.
                                        coluna = colunaNumero - 1;           // Como o da linha ja diz usamos esse entendimento logico para justamente ajudar o usuario;
                                                                             // a entender corretamente oque esta acontecendo.
                                        if (coluna >= 0 && coluna <= 2 && linha >= 0 && linha <= 2) // Da uma conferida na coluna para ver se ela esta no padrão desejado.
                                        {
                                            Joguinho.MarcarPosicaoP1(linha, coluna); // Passa a linha e coluna para o metodo MarcarPosicaoP1.
                                            break;                                  // Nota: MarcarPosicaoP1 e para o jogador, ja MarcarPosicaoIa e para a Ia que so e um random!
                                        }

                                    }
                                }
                            }
                            Thread.Sleep(1000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 1 mil equivale a 1 segundos.
                        }
                        else if (marca == 0) // se a marca for igual a 0 então permite a entrada para avisar o usuario!
                        {
                            Console.WriteLine(">    Não foi possivel fazer um ação devido cerquilha não existir!");
                            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundos.
                        }

                        break;
                    // Caso seja informado um numero fora das opções atuais no menu ira jogar para default caso tenha o default!
                    default: 
                        Console.WriteLine(">    A opção selecionada não exise no menu atual!"); 
                        Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundos.
                        break;
                }

            } while (op64 != 0); // Se op64 != 0 vai encerrar o programa mas como estamos usando uma estrutura do {} while (condição), ela vai executar pelo menos uma unica vez!
            Fim: // Como mencionado aqui pula para o final do programa caso chegue a 9
            Console.Clear();// Limpa a tela uma ultima vez para mostrar abaixo as estatiscas da partida toda desde quantas partidas, empates, vitorias em ambos lados
            Console.Write($"""
+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
|            Estatiscas da partida                |
|                                                 |
|                 Vitorias:                       |
|                P1: {Joguinho._contadorVitoriasP1} Ia: {Joguinho._contadorVitoriasIa} {"|".PadLeft(22)}
|                Empates(Velha): {Joguinho._contadorEmpates}  {"|".PadLeft(15)}
|                Total de partidas: {Joguinho._contadorPartidas} {"|".PadLeft(13)}
+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
""");
            break;
        // Se op32 == 6 acessara os desenvolvedores!
        case 6: 
            Console.Clear(); // Limpa a  a cada conclusao do loop apos usar um metodo ou errar o digito.
            Console.WriteLine("""
                +-=-=-=-=-=-=-=-=-=+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
                | Desenvolvedores do trabalho!                                |
                +-=-=-=-=-=-=-=-=-=+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
                | Nome:                               Matricula:              | 
                | Luiz Henrique Barbosa da Silva      2023121494              |
                | Jorge Luiz Barbosa da Silva         2023121496              |  
                | Julia Gabriella                     2023121812              |
                | Weber Monteiro Luna                 2023121504              |
                +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
                """);
            Thread.Sleep(5000);
            break;
        // Caso seja informado um numero fora das opções atuais no menu ira jogar para default caso tenha o default!
        default:
            Console.WriteLine("A opção selecionada não exise no menu atual!");
            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundos.
            break;
    }
} while (op32 != 0); // Se op32 for diferente de 0 vai encerrar o programa mas como estamos usando uma estrutura do {} while (condição), ela vai executar pelo menos uma unica vez!
