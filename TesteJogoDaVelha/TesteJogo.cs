using Trabalho1CSHarp.UteisMenu;
namespace TesteJogoDaVelha
{
    [TestClass]
    public class TesteJogo
    {
        [TestClass]
        public class JogoDaVelhaTest
        {
            private JogoDaVelha jogoTeste;
            [TestInitialize]
            public void InstanciadorObjeto()
            {
                jogoTeste = new JogoDaVelha();
            }
            [TestMethod]
            public void IniciarJogo()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                // Ação & Teste
                Assert.AreEqual(1, jogoTeste._contadorPartidas, "O contador de partidas deveria ser 1 após iniciar o jogo.");

            }
            [TestMethod]
            public void ReiniciarJogo()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                jogoTeste.IniciarOuReniciarJogo();
                // Ação & Teste
                Assert.AreEqual(2, jogoTeste._contadorPartidas, "O contador de partidas deveria ser 2 após reniciar o jogo.");

            }
            [TestMethod]
            public void VerificarMatrizVazia()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                // Ação & Teste
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Assert.AreEqual(" ", jogoTeste._matriz[i, j], "A posição da matriz deveria estar vazia após iniciar o jogo.");
                    }
                }
            }
            [TestMethod]
            public void JogadorEscolheX()
            {
                // Cenario
                jogoTeste.Jogadores("X");
                // Ação & Teste
                Assert.AreEqual("X", jogoTeste._p1, "O marcador do jogador deveria ser X!");
                Assert.AreEqual("O", jogoTeste._pIa, "O marcador da Ia deveria ser O!");
            }
            [TestMethod]
            public void JogadorEscolheO()
            {
                // Cenario
                jogoTeste.Jogadores("O");
                // Ação & Teste
                Assert.AreEqual("O", jogoTeste._p1, "O marcador do jogador deveria ser O!");
                Assert.AreEqual("X", jogoTeste._pIa, "O marcador da Ia deveria ser X!");
            }
            [TestMethod]
            public void MarcandoPosicaoP1()
            {
                // Cenario
                int linhaTeste = 1;
                int colunaTeste = 0;

                // Ação
                jogoTeste.IniciarOuReniciarJogo();
                jogoTeste.Jogadores("X");
                jogoTeste.MarcarPosicaoP1(linhaTeste, colunaTeste);

                // Teste
                Assert.AreEqual("X", jogoTeste._matriz[linhaTeste, colunaTeste]);
            }
            [TestMethod]
            public void VerificandoJogadorVencedor()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                jogoTeste.Jogadores("X");
                // Ação
                /*Demonstração da cerquilha
                 [X,X,X]
                 [ , , ]
                 [ , , ]
                */
                jogoTeste._matriz[0, 0] = "X";
                jogoTeste._matriz[0, 1] = "X";
                jogoTeste._matriz[0, 2] = "X";
                // Teste
                Assert.IsTrue(jogoTeste.VerificaVencedor("X"), "Deveria identificar o vencedor corretamente.");
            }
            [TestMethod]
            public void VerificandoIaVencedor()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                jogoTeste.Jogadores("X");
                // Ação
                /*Demonstração da cerquilha
                 [O, , ]
                 [ ,O, ]
                 [ , ,O]
                */
                jogoTeste._matriz[0, 0] = "O";
                jogoTeste._matriz[1, 1] = "O";
                jogoTeste._matriz[2, 2] = "O";
                // Teste
                Assert.IsTrue(jogoTeste.VerificaVencedor(jogoTeste._pIa), "Deveria identificar o vencedor corretamente.");
            }
            [TestMethod]
            public void VerificandoEmpateOuVelha()
            {
                // Cenario
                jogoTeste.IniciarOuReniciarJogo();
                jogoTeste.Jogadores("X");
                // Ação
                /*Demonstração da cerquilha
                 [X,O,O]
                 [O,X,X]
                 [X,O,O]
                */
                jogoTeste._matriz[0, 0] = "X";
                jogoTeste._matriz[0, 1] = "O";
                jogoTeste._matriz[0, 2] = "O";
                jogoTeste._matriz[1, 0] = "O";
                jogoTeste._matriz[1, 1] = "X";
                jogoTeste._matriz[1, 2] = "X";
                jogoTeste._matriz[2, 0] = "X";
                jogoTeste._matriz[2, 1] = "O";
                jogoTeste._matriz[2, 2] = "O";
                // Teste
                Assert.IsTrue(jogoTeste.VerificaEmpates(), "Deveria identificar o vencedor corretamente.");
            }
        }
    }
}