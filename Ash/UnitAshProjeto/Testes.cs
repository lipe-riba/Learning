using AshProjeto.Interfaces;
using AshProjeto.Models;
using AshProjeto.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows;

namespace UnitAshProjeto
{
    [TestClass]
    public class Testes
    {
        private CardinalPoints _cardinalPoints = new CardinalPoints();

        [TestMethod]
        public void Teste1()
        {
            ICardinalPointsService cardinalPointService = new CardinalPointsService(_cardinalPoints);
            IList<Point> points = cardinalPointService.ToPoints("SNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNN");
            int totalPokemons = cardinalPointService.GetTotalPokemons(points);
            Assert.AreEqual(totalPokemons, 370);
        }

        [TestMethod]
        public void Teste2()
        {
            ICardinalPointsService cardinalPointService = new CardinalPointsService(_cardinalPoints);
            IList<Point> points = cardinalPointService.ToPoints("NNSSNNNNGEEOOOOSOOOSH");
            int totalPokemons = cardinalPointService.GetTotalPokemons(points);
            Assert.AreEqual(totalPokemons, -1);
        }

        [TestMethod]
        public void Teste3()
        {
            ICardinalPointsService cardinalPointService = new CardinalPointsService(_cardinalPoints);
            IList<Point> points = cardinalPointService.ToPoints("SNSNENENENENENOOO");
            int totalPokemons = cardinalPointService.GetTotalPokemons(points);
            Assert.AreEqual(totalPokemons, 15);
        }

        [TestMethod]
        public void Teste4()
        {
            ICardinalPointsService cardinalPointService = new CardinalPointsService(_cardinalPoints);
            IList<Point> points = cardinalPointService.ToPoints("E");
            int totalPokemons = cardinalPointService.GetTotalPokemons(points);
            Assert.AreEqual(totalPokemons, 2);
        }
    }
}
