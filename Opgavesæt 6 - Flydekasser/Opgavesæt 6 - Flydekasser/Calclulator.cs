using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavesæt_6___Flydekasser
{
    public class Calclulator
    {
        public Calclulator()
        { }

        public double CalculateBoxWeight(double h, double w, double d, double t, double density)
        {
            //calculate the volume of the material for the box
            double result = (h * w * t * 2) + ((d - (2 * t)) * h * 2 * t) + ((w - (2 * t)) * (d - (2 * t)) * 2 * t);

            //volume of material times density of material
            result = result * density;

            //return result
            return result;
        }

        public double CalculateBoxVolume(double h, double w, double d)
        {
            double result = h * w * d;

            return result;
        }

        public double CalculateCylinderWeight(double h, double r, double t, double density)
        {
            double result = 0;

            double area1 = r * r * Math.PI;
            double area2 = (r - t) * (r - t) * Math.PI;

            result = (area1 - area2) * h + (area2 * t) * 2;

            return result * density;
        }

        public double CalculateCylinderVolume(double h, double r)
        {
            double result = 0;

            result = r * r * Math.PI * h;

            return result;
        }

        public double CalculateBoyancyProvess(double weight, double volume)
        {
            double result = 0;

            result = volume * 1000 - weight;

            return result;
        }
    }
}
