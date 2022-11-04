using AshProjeto.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitAshProjeto
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void Teste1()
        {
            ICoordModel coords = new CoordModel();
            int total = coords.GetTotalPokemonsByCoords("SNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNN");
            Assert.AreEqual(total, 370);
        }

        [TestMethod]
        public void Teste2()
        {
            ICoordModel coords = new CoordModel();
            int total = coords.GetTotalPokemonsByCoords("NNSSNNNNGEEOOOOSOOOSH");
            Assert.AreEqual(total, -1);
        }

        [TestMethod]
        public void Teste3()
        {
            ICoordModel coords = new CoordModel();
            int total = coords.GetTotalPokemonsByCoords("SNSNENENENENENOOO");
            Assert.AreEqual(total, 15);
        }

        [TestMethod]
        public void Teste4()
        {
            ICoordModel coords = new CoordModel();
            int total = coords.GetTotalPokemonsByCoords("E");
            Assert.AreEqual(total, 2);
        }
    }
}
