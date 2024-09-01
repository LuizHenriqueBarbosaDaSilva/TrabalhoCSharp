using Trabalho1CSHarp.UteisMenu;
namespace TesteTrabalho
{
    [TestClass]
    public class TesteDosMetodos
    {
        [TestMethod]
        public void TestandoFatorialDe5()
        {
            // Cenario, Ação & Teste
            Assert.AreEqual(120,Fatorial.CalcularFatorial(5), "O fatorial de 5 deveria dar 120!");
        }
        [TestMethod]
        public void TestandoOrdenacao()
        {
            // Cenario  
            int[] resultado = { 1, 4, 5, 6, 7, 8 };
            int[] vetorFora = { 8, 6, 5, 7, 4, 1 };
            // Ação & Teste
            CollectionAssert.AreEqual(resultado, Ordenador.Ordenacao(vetorFora), "A lista não foi ordenada corretamente!");
        }
    }
}