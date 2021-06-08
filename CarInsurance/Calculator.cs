using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    public class Calculator
    {
        public double calcCarValue(double value, double years, double volume, double hp)
        {
            double response;
            if (value < 1000 || years < 0 || volume < 900 || hp < 40)
                throw new ArgumentException();
            response = 0.05 * ((value - (0.1 * value * years) + volume) / (200 / hp));
            if (response < 250)
                response = 250;
            return response;
        }
        public double calcDriverMod(double age, double driverLicence)
        {
            double response;
            if (age < 18 || age > 100 || driverLicence > age - 18)
                throw new ArgumentException();
            response = 150 - age;
            response -= (driverLicence * 3);
            response = response / 100;
            if (response < 0.3)
                response = 0.3;
            return response;
        }
        public double calcResult(double value, double years, double volume, double hp, double age, double driverLicence)
        {
            if (value < 1000 || years < 0 || volume < 900 || hp < 40 || age < 18 || age > 100 || driverLicence > age - 18)
                throw new ArgumentException();
            double car = calcCarValue(value, years, volume, hp);
            double driver = calcDriverMod(age, driverLicence);
            double result = car * driver;
            return result;
        }
    }
}
