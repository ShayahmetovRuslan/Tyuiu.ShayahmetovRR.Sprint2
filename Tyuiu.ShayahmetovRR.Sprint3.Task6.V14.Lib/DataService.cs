using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task6.V14.Lib
{
	public class DataService : ISprint2Task6V14
	{
		public string FindDayName(int k, int d)
		{
			string str;
			switch (k % 7 + d)
			{
				case 2: return "Понедельник";
				case 3: return "Вторник";
				case 4: return "Среда";
				case 5: return "Четверг";
				case 6: return "Пятница";
				case 7: return "Суббота";
				case 8: return "Воскресенье";
				case 9: return "Понедельник";
				case 10: return "Вторник";
				case 11: return "Среда";
				case 12: return "Четверг";
				case 13: return "Пятница";
				case 14: return "Суббота";
				case 15: return "Воскресенье";
				default: throw new ArgumentException($"Дней не больше семи");
			}
		}
	}
}
