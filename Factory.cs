using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_1_вар_8
{
    public class Factory:OilAndGasCompany
    {
        public string city;
        public int oilProduction;
        public int gasProduction;

        public Factory(long inn, string name, int oilPrice, int gasPrice, string city, int oilProduction, int gasProduction) : base(inn, name, oilPrice, gasPrice)
        {
            this.oilProduction = oilProduction;
            this.gasProduction = gasProduction;
            this.city = city;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Тип: Завод, Добыча нефти: {oilProduction}, Добыча газа: {gasProduction}, Город: {city}.";
            return info;
        }

        public void GetInformation()
        {
            Console.WriteLine($" Тип: Завод, Добыча нефти: {oilProduction}, Добыча газа: {gasProduction}, Город: {city}.");
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Factory))
            {
                return false;
            }
            return this.inn == ((Factory)obj).inn;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

}
