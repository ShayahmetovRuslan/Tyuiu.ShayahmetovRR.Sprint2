using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task3.V13.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task3.V13.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate1()
		{
			DataService ds = new DataService();

			int x = 2;

			double res = ds.Calculate(x);

			Assert.AreEqual(-7, res);
		}
		[TestMethod]
		public void ValidCalculate2()
		{
			DataService ds = new DataService();

			int x = 0;

			double res = ds.Calculate(x);

			Assert.AreEqual(0.75, res);
		}
		[TestMethod]
		public void ValidCalculate3()
		{
			DataService ds = new DataService();

			int x = 1;

			double res = ds.Calculate(x);

			Assert.AreEqual(11, res);
		}
		[TestMethod]
		public void ValidCalculate4()
		{
			DataService ds = new DataService();

			int x = -20;

			double res = ds.Calculate(x);

			Assert.AreEqual(-219.95, res);
		}
	}
}
