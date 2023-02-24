using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_1_вар_8
{
    public class OilAndGasCompany : Organization
    {
        public int oilPrice;
        public int gasPrice;
        public OilAndGasCompany(long inn, string name, int oilPrice, int gasPrice) : base(inn, name)
        {
            this.oilPrice = oilPrice;
            this.gasPrice = gasPrice;
        }


        public override string ToString()
        {
            string info = base.ToString();
            info += $" Тип: Нефтегазовая компания, Цена на нефть: {oilPrice}, Цена на газ: {gasPrice}.";
            return info;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is OilAndGasCompany))
            {
                return false;
            }
            return this.inn == ((OilAndGasCompany)obj).inn;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

}
