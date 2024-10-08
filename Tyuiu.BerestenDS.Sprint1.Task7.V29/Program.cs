﻿using System.Runtime.InteropServices;
using Tyuiu.BerestenDS.Sprint1.Task7.V29.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать программу,которая вычисляет математическое выражение по исходным*");
Console.WriteLine("* значениям данных,вводимых пользователем.                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(" z = x - cos(x)^3/xy-3 + sin(x)^5/xy+5                                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double x, y;
Console.WriteLine("Введите значение x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.Calculate(x, y));
Console.ReadKey();
