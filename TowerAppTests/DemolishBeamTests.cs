using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TowerApp.Tests
{
    [TestClass()]
    public class DemolishBeamTests
    {
        private DemolishBeam beam = null;

        [TestInitialize()]
        public void setup()
        {
            beam = new DemolishBeam();
        }

        [TestMethod()]
        public void MovesToDemolishBuildingsTest()
        {
            int[] ar = new[] {5, 3, 4, 7, 2};
        int result =     beam.MovesToDemolishBuildings(5, ar);
            Assert.AreEqual(5,result);
        }

        [TestMethod()]
        public void MovesFromQuestion()
        {
            int[] ar = new[] {1, 1, 1, 1, 10};
            int buildings = 5;
            int result = beam.MovesToDemolishBuildings(buildings, ar);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MovesFromQuestion2()
        {
            int[] ar = new[] { 2,1,8,8,2,3 };
            int buildings = 6;
            int result = beam.MovesToDemolishBuildings(buildings, ar);
            Assert.AreEqual(5, result);
        }
        
    }
}