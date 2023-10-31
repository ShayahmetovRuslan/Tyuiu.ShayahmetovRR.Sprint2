using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using Tyuiu.ShayahmetovRR.Sprint2.Task4.V9.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task4.V9.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate()
		{
			DataService ds = new DataService();

			int x = 1, y = 2;

			double res = ds.Calculate(x, y);
			Assert.AreEqual(res, -0.5);
		}
	}
}
