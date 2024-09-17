using Trabalho1CSHarp.UteisMenu;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestandoFatorialDe9()
        {
            // Cenario
            Fatorial fat = new Fatorial();
            //Ação & Teste
            Assert.AreEqual(362880, fat.CalcularFatorialFOR(9), "O fatorial de 9 deveria dar 362880!");
        }
    }
}