using AshProjeto.Interfaces;
using AshProjeto.Models;
using AshProjeto.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitAshProjeto
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void Teste1()
        {
            ICardinalPointsService cardinal = new CardinalPointsService();
            int total = cardinal.GetTotalPokemonsByCardinalPoint("SNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNN");
            Assert.AreEqual(total, 370);
        }

        [TestMethod]
        public void Teste2()
        {
            ICardinalPointsService cardinal = new CardinalPointsService();
            int total = cardinal.GetTotalPokemonsByCardinalPoint("NNSSNNNNGEEOOOOSOOOSH");
            Assert.AreEqual(total, -1);
        }

        [TestMethod]
        public void Teste3()
        {
            ICardinalPointsService cardinal = new CardinalPointsService();
            int total = cardinal.GetTotalPokemonsByCardinalPoint("SNSNENENENENENOOO");
            Assert.AreEqual(total, 15);
        }

        [TestMethod]
        public void Teste4()
        {
            ICardinalPointsService cardinal = new CardinalPointsService();
            int total = cardinal.GetTotalPokemonsByCardinalPoint("E");
            Assert.AreEqual(total, 2);
        }
    }
}
