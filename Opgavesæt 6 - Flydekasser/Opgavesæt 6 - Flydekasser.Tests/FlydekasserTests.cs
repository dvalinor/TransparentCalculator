using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgavesæt_6___Flydekasser;

namespace Opgavesæt_6___Flydekasser.Tests
{
    [TestClass]
    public class FlydekasserTests
    {        
        [TestMethod, TestCategory("Calculation"), TestCategory("Box")]
        public void BoxVolume()
        {
            Calclulator calc = new Calclulator();

            double h = 1;
            double w = 1;
            double d = 1;

            double result = Math.Round(calc.CalculateBoxVolume(h, w, d));
            Assert.AreEqual(1, result);
        }

        [TestMethod, TestCategory("Calculation"), TestCategory("Box")]
        public void BoxWeight()
        {
            Calclulator calc = new Calclulator();

            double h = 2;
            double w = 3;
            double d = 4;
            double t = 0.1;

            double density = 7870;

            double result = calc.CalculateBoxWeight(h, w, d, t, density);
            Assert.AreEqual(38154, Math.Round(result));
        }

        [TestMethod, TestCategory("Calculation"), TestCategory("Box")]
        public void BoxBoyancy()
        {
            Calclulator calc = new Calclulator();

            double h = 2;
            double w = 3;
            double d = 4;
            double t = 0.1;

            double density = 7870;

            double result = calc.CalculateBoyancyProvess(calc.CalculateBoxWeight(h, w, d, t, density), calc.CalculateBoxVolume(h, w, d));

            Assert.AreEqual(-14154, Math.Round(result));
        }

        [TestMethod, TestCategory("Calculation"), TestCategory("Cylinder")]
        public void CylinderVolume()
        {
            Calclulator calc = new Calclulator();

            double h = 10;
            double r = 5;
            double t = 1;

            double density = 7870;

            double result = calc.CalculateCylinderVolume(h, r);
            Assert.AreEqual(785, Math.Round(result));
        }

        [TestMethod, TestCategory("Calculation"), TestCategory("Cylinder")]
        public void CylinderWeight()
        {
            Calclulator calc = new Calclulator();

            double h = 10;
            double r = 5;
            double t = 1;

            double density = 7870;

            double result = calc.CalculateCylinderWeight(h, r, t, density);
            Assert.AreEqual(3016369, Math.Round(result));
        }

        [TestMethod, TestCategory("Calculation"), TestCategory("Cylinder")]
        public void CylinderBoyancy()
        {
            Calclulator calc = new Calclulator();

            double h = 10;
            double r = 5;
            double t = 1;

            double density = 7870;

            double result = calc.CalculateBoyancyProvess(calc.CalculateCylinderWeight(h, r, t, density), calc.CalculateCylinderVolume(h, r));

            Assert.AreEqual(-2230971, Math.Round(result));
        }
    }
}
