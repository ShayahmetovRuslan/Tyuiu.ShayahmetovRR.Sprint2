﻿using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task0.V9.Lib
{
	public class DataService : ISprint2Task0V9
	{
		public bool[] GetCompareOperations(int x, int y)
		{
			bool[] res = new bool[6];
			res[0] = x - 679 == y;
			res[1] = x != y;
			res[2] = x - 680 < y;
			res[3] = x > y;
			res[4] = x - 1000 <= y;
			res[5] = x + 1 >= y;
			return res;
		}
	}
}