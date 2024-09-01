using Trabalho1CSHarp.UteisMenu;
namespace TesteTrabalho
{
    [TestClass]
    public class TesteDosMetodos
    {
        [TestMethod]
        public void TestandoFatorialDe5()
        {
            // Cenario  Ação & Teste
            Assert.AreEqual(120,Fatorial.CalcularFatorial(5), "O fatorial de 5 deveria dar 120");
        }
    }
}