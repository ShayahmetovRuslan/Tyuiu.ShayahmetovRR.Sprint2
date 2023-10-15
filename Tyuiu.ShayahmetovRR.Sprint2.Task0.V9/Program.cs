﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.Task0.V9.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task0.V9
{
	class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #2 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #2                                                                  *");
			Console.WriteLine("* Тема: Операции сравнения                                                   *");
			Console.WriteLine("* Задание #0                                                                 *");
			Console.WriteLine("* Вариант #9                                                                 *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* // Написать программу из операций сравнений и арифметических выражений,    *");
			Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться),  *");
			Console.WriteLine("* которая вернет логическую последовательность(массив):                      *");
			Console.WriteLine("* (True, True, True, True, True, False), при x = 1054, y = 375               *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int x = 1054;
			int y = 375;
			bool[] res = new bool[6];
			res = ds.GetCompareOperations(x, y);

			Console.WriteLine("X = " + x);
			Console.WriteLine("Y = " + y);


			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine(res[i]);
			}
			Console.ReadKey();
		}
	}
}