using Trabalho1CSHarp.UteisMenu;
namespace TesteTrabalho
{
    [TestClass]
    public class TesteDosMetodos
    {
        // Teste do Luiz
        [TestMethod]
        public void TestandoFatorialDe5()
        {
            // Cenario
            Fatorial fat = new Fatorial();
            //Ação & Teste
            Assert.AreEqual(5040, fat.CalcularFatorialFOR(7), "O fatorial de 5 deveria dar 120!");
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
        // Teste do weber
        [TestMethod]
        public void TestFatorial()
        {
            //cenário
            var calc = new Fatorial();
            int num = 5 ;
            string resultado;
            //ação
            resultado = calc.CalcularFatorial(num);
            //teste
            Assert.AreEqual("120", resultado);
        }
        [TestMethod]
        public void TestFatorial2()
        {
            //cenário
            var calc = new Fatorial();
            int num = 10;
            string resultado;
            //ação
            resultado = calc.CalcularFatorial(num);
            //teste
            Assert.AreEqual("3628800", resultado);
        }
    }
}