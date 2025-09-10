using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            InventoryContext inventoryContext = new InventoryContext();
            ProductsRepository productRepository = new ProductsRepository(inventoryContext);

            Product p = productRepository.Get<Product>("1");

            Assert.AreEqual("CANETA", p.Descricao);
        }
    }
}
