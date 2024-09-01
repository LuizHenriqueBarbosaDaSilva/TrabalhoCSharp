using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1CSHarp.UteisMenu
{
    public class JogoDaVelha
    {
        public string[,] _matriz = new string[3, 3]; // O cerquilha mais conhecido dentro da classe como matriz e oque faz o jogo acontecer.
        public string _p1 = "■", _pIa = "■";         // p1 e pIa tem seus marcadores nulos ate que sejam definidos.
        private Random rand = new Random();         // Passa a biblioteca ou modulo random com instancia privada para a classe usar sendo rand.
        public int _contadorPartidas { get; private set; } = 0; // O contador de partidas e publico oque permite usar ele fora da classe alem incrementar +1 quando uma partida nova e inciada!
        public int _contadorVitoriasP1 { get; private set; } = 0; // O contador de vitoriasP1 incrementa +1 quando o jogador ganha!
        public int _contadorVitoriasIa { get; private set; } = 0; // O contador de vitoriasIa incrementa +1 quando a Ia ganha!
        public int _contadorEmpates { get; private set; } = 0; // O contador de empate incrementa +1 quando da velha!
        public void MenuDoJogo() // metodo que nos permite ter o menu sempre funcionando.
        {
            if (_contadorPartidas == 0)
            {
                Console.Write($"""
        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        | JOGO DA VELHA: A REDENÇÃO 3000 Tm               |
        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        | 0) Sair                                         |
        | 1) Iniciar o jogo/Reniciar o jogo               |
        | 2) Escolher qual simbolo usar                   |
        | 3) Marcar uma posição na cerquilha              |
        |                                                 |
        | Informações sobre o marcador do player e Ia     |
        | (P1:{_p1}) (Ia:{_pIa}) {"|".PadLeft(35)}
        | Total de partidas: {_contadorPartidas} {"|".PadLeft(28)}
        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
        Informe sua entrada:
        """); // Primeiro menu quando o programa incia onde não mostra a cerquilha devido a não ter começado a partida!
            }
            else
            {
                Console.Write($"""
    +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+  +-=-+-=-+-=-+
    | JOGO DA VELHA: A REDENÇÃO 3000 Tm               |  | Cerquilha |
    +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+  +-=-+-=-+-=-+
    | 0) Sair                                         |  | {_matriz[0, 0]} | {_matriz[0, 1]} | {_matriz[0, 2]} |
    | 1) Iniciar o jogo/Reniciar o jogo               |  +-=-+-=-+-=-+     
    | 2) Escolher qual simbolo usar                   |  | {_matriz[1, 0]} | {_matriz[1, 1]} | {_matriz[1, 2]} |  
    | 3) Marcar uma posição na cerquilha              |  +-=-+-=-+-=-+
    |                                                 |  | {_matriz[2, 0]} | {_matriz[2, 1]} | {_matriz[2, 2]} |
    |                                                 |  +-=-+-=-+-=-+
    | Informações sobre o marcador do player e Ia     |
    | (P1:{_p1}) (Ia:{_pIa}) {"|".PadLeft(35)}
    | Total de partidas: {_contadorPartidas} {"|".PadLeft(28)}
    +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
    Informe sua entrada:
    """);   // Segundo menu quando o jogador inicia uma partida ele e em diante sera esse menu que mostra a cerquilha!
            }
        }
        public void IniciarOuReniciarJogo()
        {
            for (int i = 0; i < 3; i++) // Laço contado de I que serve para ser a linha.
            {
                for (int j = 0; j < 3; j++) // Laço contado de J que serve para ser a coluna.
                {
                    _matriz[i, j] = " "; // enche a matriz de " " que e so um placeholder.
                }
            }
            if (_contadorPartidas == 0) // Verifica se o contadorPartidas e igual 0 se for vai mostrar a mensagem inciando partida.
            {
                Console.WriteLine(">    Iniciando partida! "); // Avisa o usuario que a partida esta iniciando

            }
            else                    // Se não for vai ser então reniciando partida.
            {
                Console.Write(">    Reniciando partida! "); // Avisa o usuario que a partida esta reniciando.
            }
            if (_contadorPartidas != 9) // Se não for 9 incrementa ate chegar la onde e o limite definido!
            {
                _contadorPartidas++; // Incrementa +1 no contadorPartidas.
            }
            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
        }
        public void Jogadores(string marcadorPlayer) // O metodo Jogadores exige o marcadorPlayer para ser executado.
        {
            _p1 = marcadorPlayer; // passa o marcadorPlayer para p1!
            if (marcadorPlayer == "X") // Se o marcadorPlayer for X ira passar por aqui.
            {
                _pIa = "O"; // Passa então para a Ia que seu marcador e O, ja que o marcadorPlayer e X!


            }
            else if (marcadorPlayer == "O") // Se o marcadorPlayer for O ira passar por aqui.
            {
                _pIa = "X"; // Passa então para a Ia que seu marcador e X, ja que o marcadorPlayer e O!

            }
            Console.WriteLine($">    Voce escolheu {_p1} então a Ia ira ficar com {_pIa}"); // Informa o usuario sobre sua escolha e que a Ia ficara com a outra.
            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
        }
        public void MarcarPosicaoP1(int linhaClasse, int colunaClasse)  // ao usar esse metodo estamos passando a linha e coluna selecionada para;
        {                                                              // dentro da classe onde posso marcar a cerquilha.
            if (_matriz[linhaClasse, colunaClasse] == _pIa)
            {
                Console.WriteLine(">    Posição inválida tentou marcar onde tem a posição do oponente! Tente novamente.");
                Thread.Sleep(3000);
            }
            else if (_matriz[linhaClasse, colunaClasse] == _p1)
            {
                Console.WriteLine(">    Posição inválida tentou marcar onde ja tem seu marcador! Tente novamente.");
                Thread.Sleep(3000);
            }
            else
            {
                if (_matriz[linhaClasse, colunaClasse] == " ") // se a matriz estiver disponivel com " " então entra nessa condição!
                {
                    _matriz[linhaClasse, colunaClasse] = _p1;   // Passa p1 para a coluna e linha desejada.
                    MarcarPosicaoIA();                       // chama o metodo de MarcarPosicaoIa para a Ia marcar um lugar.
                    if (VerificaVencedor(_p1))               // Começa a verificar o vencedor com o metodo VerificarVencedor(), aqui estamos passando p1(jogador).
                    {
                        Console.WriteLine($">    Jogador {_p1} venceu!"); // Avisa o jogador que ele venceu
                        Thread.Sleep(3000);        // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
                        IniciarOuReniciarJogo();  // Assim que uma partida acaba chamamos o metodo IniciarOuReniciarJogo para reniciar a partida!
                        _contadorVitoriasP1++;    // incrementa +1 no contadorVitoriasP1.
                    }
                    else if ((VerificaVencedor(_pIa)))  // Começa a verificar o vencedor com o metodo VerificarVencedor(), aqui estamos passando pIa(Ia).
                    {
                        Console.WriteLine($">    IA ({_pIa}) venceu!"); // Avisa o jogador que ele perdeu
                        Thread.Sleep(3000);        // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
                        IniciarOuReniciarJogo();  // Assim que uma partida acaba chamamos o metodo IniciarOuReniciarJogo para reniciar a partida!
                        _contadorVitoriasIa++;    // incrementa +1 no contadorVitoriasIa.
                    }
                    else if (VerificaEmpates())  // Começa a verificar se houve um empate com o metodo VerificarEmpates().
                    {
                        Console.WriteLine(">    Deu velha!");        // Avisa o jogador que houve um empate(Velha)
                        Thread.Sleep(3000);        // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
                        IniciarOuReniciarJogo();  // Assim que uma partida acaba chamamos o metodo IniciarOuReniciarJogo para reniciar a partida!
                        _contadorEmpates++;       // incrementa +1 no contadorEmpates.
                    }
                }
            }
        }
        private void MarcarPosicaoIA() // o metodo MarcarPosicaoIa faz uso da biblioteca random que esta em um objeto declarado acima como rand!
        {
            Console.WriteLine(">    a Ia esta escolhendo o proximo passo!"); // Avisa o jogador que a ia esta na sua vez de marcar
            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo.
            int _tentativas = 0; // Tentativas esta aqui para justamente limitar quantas chances a ia tem de fazer uma marcação na cerquilha
            while (_tentativas < 10) // como descrito ali em cima estamos limitando o movimento da ia para não ficar em um loop infinito
            {
                int linhaClasseRand = rand.Next(3); // a linhaClasseRand justamente usa o rand.Next(numero) que vai de 0 ao numero para definir a linha
                int colunaClasseRand = rand.Next(3); // a coulnaClasseRand justamente usa o rand.Next(numero) que vai de 0 ao numero para definir a coluna
                if (_matriz[linhaClasseRand, colunaClasseRand] == " ") // Verifica se a matriz tem um espaço vazio " " aonde a ia escolheu
                {
                    _matriz[linhaClasseRand, colunaClasseRand] = _pIa; // Marca com o marcador da Ia em qual linha e coluna a ia escolheu
                    return; // quando for marcado ele ira usar o return para voltar a onde o metodo foi chamado que e la em cima antes das verificações!
                }
                _tentativas++; // se não achar o espaço vazio incrementa +1 nas tentativas
            }
            Console.WriteLine(">    Não foi possível encontrar uma posição livre para o IA."); // Avisa o jogador que a Ia não pode encontrar um posição
            Thread.Sleep(3000); // ira esperar um pouco de segundos devido ao metodo Thread.Sleep() onde 3 mil equivale a 3 segundo. 
        }
        public bool VerificaEmpates() // O metodo VerificarEmpates serve justamente para ver empates.
        {
            for (int i = 0; i < 3; i++) // Passa i como linha.
            {
                for (int j = 0; j < 3; j++) // Passa j como coluna.
                {
                    if (_matriz[i, j] == " ") // Verifica se a matriz possui alguma posição com " " se for verdade passa a condição.
                    {
                        return false; // Ira nos retornar falso pois a condição acima foi verdadeira.
                    }
                }
            }
            return true; // Ele passa verdadeiro para entrar na condição do empate.
        }
        public bool VerificaVencedor(string marcador) // Aqui temos o metodo VerificaVencedor(string marcador) 
        {
            /* 
            Vamos ver essa matriz como exemplo!
                 Matriz
                 ["e","x","p"]
                 ["l","o","r"]
                 ["i","o","!"]
            */
            for (int i = 0; i < 3; i++) // Aqui iremos ver cada linha  entao ficaria assim uma representação!
            {
                /* 
                i = 0 -> ["e","x","p"]
                i = 1 -> ["l","o","r"]
                i = 2 -> ["i","o","!"]
                 */
                if (_matriz[i, 0] == marcador && _matriz[i, 1] == marcador && _matriz[i, 2] == marcador) // Se ele achar o marcador da ia ou do player nessas posições ira entrar na condição.
                {
                    return true; // Retorna verdadeiro oque confirma a vitoria do Jogador ou da Ia.
                }
            }
            for (int j = 0; j < 3; j++) // Aqui iremos ver cada coluna então ficaria assim uma representação!
            {
                /*
                j = 0 -> ["e","l","i"]
                j = 1 -> ["x","o","o"]
                j = 2 -> ["p","r","!"]
                 */
                if (_matriz[0, j] == marcador && _matriz[1, j] == marcador && _matriz[2, j] == marcador) // Se ele achar o marcador da ia ou do player nessas posições ira entrar na condição.
                {
                    return true; // Retorna verdadeiro oque confirma a vitoria do Jogador ou da Ia.
                }
            }
            if (_matriz[0, 0] == marcador && _matriz[1, 1] == marcador && _matriz[2, 2] == marcador) // Aqui iremos ver se a diagonal então ficaria assim uma representação!
            {
                /*
                Matriz:
                ["e","x","p"]
                ["l","o","r"]
                ["i","o","!"]  
                Condição: 
                0 , 0 -> ["e"]
                1 , 1 -> ["o"]
                2 , 2 -> ["!"]
                 */
                return true; // Retorna verdadeiro oque confirma a vitoria do Jogador ou da Ia.
            }
            if (_matriz[0, 2] == marcador && _matriz[1, 1] == marcador && _matriz[2, 0] == marcador) // Aqui iremos ver se a diagonal oposta então ficaria assim uma representação!
            {
                /*
                Matriz:
                ["e","x","p"]
                ["l","o","r"]
                ["i","o","!"]  
                Condição: 
                0 , 2 -> ["p"]
                1 , 1 -> ["o"]
                2 , 0 -> ["i"]
                 */
                return true; // Retorna verdadeiro oque confirma a vitoria do Jogador ou da Ia.
            }
            return false; // Se não achou nenhuma dessas condições retorna falso e parte para verificar se houve empate
        }

    }
}