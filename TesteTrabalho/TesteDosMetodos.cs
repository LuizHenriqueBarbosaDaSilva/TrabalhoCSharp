using Trabalho1CSHarp.UteisMenu;
namespace TesteTrabalho
{
    [TestClass]
    public class TesteDosMetodos
    {
        [TestMethod]
        public void TestandoFatorialDe5()
        {
            // Cenario, A��o & Teste
            Assert.AreEqual(120,Fatorial.CalcularFatorial(5), "O fatorial de 5 deveria dar 120!");
        }
        [TestMethod]
        public void TestandoOrdenacao()
        {
            // Cenario  
            int[] resultado = { 1, 4, 5, 6, 7, 8 };
            int[] vetorFora = { 8, 6, 5, 7, 4, 1 };
            // A��o & Teste
            CollectionAssert.AreEqual(resultado, Ordenador.Ordenacao(vetorFora), "A lista n�o foi ordenada corretamente!");
        }
    }
}