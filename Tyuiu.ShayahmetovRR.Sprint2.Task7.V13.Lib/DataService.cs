using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task7.V13.Lib
{
	public class DataService : ISprint2Task7V13
	{
		public bool CheckDotInShadedArea(double x, double y)
		{
			bool res;
			if ((x >= 0) && (y <= 1) && (y >= x - 1))
			{
				 res = true;
			}
			else if ((x >= 0) && (y <= x - 1) &&(Math.Pow(y,2) + Math.Pow(x,2)) <= 1)
			{
				 res = true; 
			}
			else
			{
				 res = false;
			}
			return res;
		}
	}
}
