using System;

namespace Лабораторная_работа_1_вар_8
{
    public abstract class Organization
    {
        protected long inn;
        private string name;
        public Organization(long inn, string name)
    {
        this.inn = inn;
        this.name = name;
    }
        // В C# есть класс от которого неявно наследуются все классы - это класс Object.
        // У него есть несколько методов которые можно переопределить для данного класса.
        // Это методы GetHashCode - возвращает Хэш-код элемента,
        // Метод Equals - проверяет равны ли два объекта класса.
        // И метод ToString - Переводит сведения о объекте класса в строку.
        // Переопределим методы ToString и Equals т.к. это понадобится нам в дальнейшей работе в классе Program.
        public override string ToString()
        {
            string info = $"Название организации: {name}, ИНН организации: {inn}";
            return info;
        }

        public override bool Equals(Object? obj)
        {
            // Проверяем класс на null.
            if (obj == null)
            {
                return false;
            }
            // Проверяем является ли объект сравнения Изделием.
            if (!(obj is Organization))
            {
                return false;
            }
            // Сравниваем объекты только по серийному номеру, т.к. он уникален для каждого объекта.
            return this.inn == ((Organization)obj).inn;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

   
}
