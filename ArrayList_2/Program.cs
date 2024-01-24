using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан список с именами друзей Ильназа Алмазовича. Добавить ещё три имени которые пользователь вводит с клавиатуры и выполнить поиск по имени, затем удалить найденное имя
            ArrayList s = new ArrayList();
            s.Add("Сева");
            s.Add("Ильяс");
            s.Add("Макс");
            s.Add("Марсель");


            Console.WriteLine("Добавляем имена:");
            for (int i = 0; i<3; i++)
            {
                string fruct = Console.ReadLine();
                s.Add (fruct);
            }
            
            foreach (var i in s )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Поиск: ");
            string del = Console.ReadLine();

            if (s.Contains(del))
            {
                s.Remove(del);
                Console.WriteLine($"{del} удалён из друзей Ильназа Алмазовича");
            }
            else
            {
                Console.WriteLine($"такого человека в коллекции нет");
            }
            Console.ReadKey();
        }
    }
}
