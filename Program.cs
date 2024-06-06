using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Satelite[] satelite = new Satelite[10];
            int c, count = 0;
            double weight, height, speed;
            string name;
            while (true)
            {
                count = 0;
                foreach (var i in satelite)
                {
                    if (i != null)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Введите номер действия:\n1 - добавить\n2 - удалить\n3 - выход");
                Console.WriteLine("count: " + count);
                c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    if (count == 9) Console.WriteLine("К сожалению, у вас слишком много информации о спутниках, добавить новый не получится");
                    else
                    {
                        Console.Write("Введите название спутника: ");
                        name = Console.ReadLine();
                        Console.Write("Введите массу спутника: ");
                        weight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите высоту орбиты спутника: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите скорость спутника: ");
                        speed = Convert.ToDouble(Console.ReadLine());
                        satelite[count] = new Satelite { sateliteName = name, weight = weight, heightOrbit = height, speed = speed };
                        count++;
                        Console.WriteLine("Название спутника\tМасса спутника\tВысота орбиты\tСкорость\tДлина окружности земли");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        foreach (var i in satelite)
                        {
                            if (i!=null)
                            {
                                //Console.WriteLine($"Название спутника: {i.sateliteName}\tМасса спутника: {i.weight}\tВысота орбиты: {i.heightOrbit}\tСкорость: {i.speed}\tДлина окружности Земли: {Satelite.earthWidth}");
                                Console.WriteLine($"{i.sateliteName}\t\t\t{i.weight}\t\t{i.heightOrbit}\t\t{i.speed}\t\t{Satelite.earthWidth}");

                            }
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    }
                }
                if (c == 2)
                {
                    if (count == 0) Console.WriteLine("К сожалению, у вас нет информации о спутниках, удалить пустоту не получится");
                    else
                    {
                        if (count == 1) satelite[0] = null;
                        else
                        {
                            Console.Write("Какой спутник вы бы хотели удалить(нумерация начинается с 0)");
                            int deleteIndex = Convert.ToInt32(Console.ReadLine());
                            while (satelite[deleteIndex+1] != null)
                            {
                                satelite[deleteIndex] = satelite[deleteIndex + 1];
                                deleteIndex++;
                            }
                            satelite[deleteIndex] = null;
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                            foreach (var i in satelite)
                            {
                                if (i != null)
                                {
                                    Console.WriteLine($"Название спутника: {i.sateliteName}\tМасса спутника: {i.weight}\tВысота орбиты: {i.heightOrbit}\tСкорость: {i.speed}\tДлина окружности Земли: {Satelite.earthWidth}");
                                }
                            }
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                        }
                    }
                }
                if (c == 3) break;
            }
        }
    }
}
