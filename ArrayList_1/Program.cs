using System;
using System.Collections.Generic;
using System.Collections; //для работы обязтельно подключаем это пространство имён!!!
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList()//создаём коллекцию
            {
               228,
               223,
               "Ильназ Алмазович",
               "Ваня",
               '%',
               22.8
            };
            Console.WriteLine("Выводим коллекцию:");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Добавление 
            Console.WriteLine("Добавление:");
            array.Add("ОАиП");
            array.Add("БД");
            array.Add(5);
            array.Add('!');
            //также можно добавить массив
            array.AddRange(new string[] { "Автоматов", "не", "будет", "!"});
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Удаление
            Console.WriteLine("Удаление:");
            array.Remove("ОАиП");//удаляем по значению
            array.RemoveAt(3); //удаляем по индексу
            foreach (var i in array)
            { 
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Переворачиваем коллекцию:");
            array.Reverse();
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Получаем элеент по индексу:");
            Console.WriteLine(array[9]);
            Console.ReadKey();
        }
    }
}
