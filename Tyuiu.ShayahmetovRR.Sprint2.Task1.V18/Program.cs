namespace Tyuiu.ShayahmetovRR.Sprint2.Task1.V18;
using Tyuiu.ShayahmetovRR.Sprint2.Task1.V18.Lib;

	internal class Program
	{
		static void Main(string[] args)
		{
			{
				DataService ds = new DataService();
				Console.Title = "Спринт #2 | Выполнил: Шаяхметов Р.Р. | АСОиУб 23-1";
				Console.WriteLine("******************************************************************************");
				Console.WriteLine("* Спринт #2                                                                  *");
				Console.WriteLine("* Тема: Логические операции                                                  *");
				Console.WriteLine("* Задание #1                                                                 *");
				Console.WriteLine("* Вариант #18                                                                *");
				Console.WriteLine("* Выполнил: Шаяхметов Р.Р. | АСОиУб 23-1                                     *");
				Console.WriteLine("******************************************************************************");
				Console.WriteLine("* УСЛОВИЕ:                                                                   *");
				Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,            *");
				Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) *");
				Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не  *");
				Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет       *");
				Console.WriteLine("* логическую последовательность(массив):                                     *");
				Console.WriteLine("* (True, False, False, False, False, False),                                 *");
				Console.WriteLine("* при a = 155, b = 696, c = 242, d = 541                                     *");
				Console.WriteLine("******************************************************************************");
				Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
				Console.WriteLine("******************************************************************************");

				int a = 155;
				int b = 696;
				int c = 242;
				int d = 541;

				bool[] res = new bool[6];
				res = ds.GetLogicOperations(a, b, c, d);

				Console.WriteLine("a = " + a);
				Console.WriteLine("b = " + b);
				Console.WriteLine("c = " + c);
				Console.WriteLine("d = " + d);


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