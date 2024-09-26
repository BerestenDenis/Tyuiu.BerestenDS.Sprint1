using System.Runtime.InteropServices;
using Tyuiu.BerestenDS.Sprint1.Task5.V2.Lib;
    class Program
    {
        static void Main(string[] args)
        {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.Определить значение     *");
        Console.WriteLine("* этой  же температуры в градусах Цельсия.                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение температуры");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
        Console.WriteLine(res);

        Console.ReadKey();


        }
    }