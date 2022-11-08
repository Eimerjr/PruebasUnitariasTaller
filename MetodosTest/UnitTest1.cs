using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MetodosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodoPar()
        {
            //Arrange

            //ACT
            bool result = PruebasUnitarias.MisMetodos.par(20);
            //Asser
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMetodoSumar()
        {
            //Arrange

            //ACT
            int result = PruebasUnitarias.MisMetodos.sumar(1, 9);
            //Asser
            Assert.AreEqual(10,result);


        }

        [TestMethod]
        public void TestMetodoNombre()
        {

            //Arrange

            //ACT
            string result = PruebasUnitarias.MisMetodos.Nombre();
            //Asser
            Assert.AreEqual("Eimer", result);
        }

        [TestMethod]
        public void TestMetodoLoging()
        {
            bool result = PruebasUnitarias.MisMetodos.Loging("Eimer22", "2020");
            Assert.IsTrue(result);
        }
    }
}