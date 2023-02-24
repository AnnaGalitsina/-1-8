using System;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

namespace Лабораторная_работа_1_вар_8
{
    public class InsuranceСompany : Organization
    {
        private int number_of_clients;
        private int incomes;
        private int expenses;

        public InsuranceСompany(long inn, string name, int number_of_clients, int incomes, int expenses) : base(inn, name)
        {
            this.number_of_clients = number_of_clients;
            this.incomes = incomes;
            this.expenses = expenses;
        }

        // Возвращает доходы компании
        public int GetIncomes()
        {
            return incomes;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $" Тип: Страховая компания, Количество клиентов: {number_of_clients}, Доходы компании: {incomes}, Расходы компании: {expenses}.";
            return info;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InsuranceСompany))
            {
                return false;
            }
            return this.inn == ((InsuranceСompany)obj).inn;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
