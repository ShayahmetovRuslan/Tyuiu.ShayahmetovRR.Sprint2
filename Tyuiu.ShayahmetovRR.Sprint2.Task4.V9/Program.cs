using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint2.Task4.V9.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task4.V9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #2 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #2                                                                  *");
			Console.WriteLine("* Тема: Операции сравнения                                                   *");
			Console.WriteLine("* Задание #0                                                                 *");
			Console.WriteLine("* Вариант #3                                                                 *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* // Написать программу из операций сравнений и арифметических выражений,    *");
			Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться),  *");
			Console.WriteLine("* которая вернет логическую последовательность(массив):                      *");
			Console.WriteLine("* (False, True, False, True, False, True), при x = 45, y = 127               *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int x, y;
			x = Convert.ToInt32(Console.ReadLine());
			y = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("z = " + ds.Calculate(x, y));
			Console.ReadKey();
		}
	}
}
