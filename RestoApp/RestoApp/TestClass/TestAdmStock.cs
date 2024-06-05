using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestClass
{
    [TestClass]
    public class TestAdmStock
    {
        [TestMethod]
        public void Test_Producto()
        {
            Producto producto = new Producto("pepas", "Efectivo", "Bagley", "1112", "Av.Galleton 123", "10/5", 25, 800);

        }
    }
}
