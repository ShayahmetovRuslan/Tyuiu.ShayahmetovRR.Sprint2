using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task2.V6.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task2.V6.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCheckDotInShadedArea()
		{
			DataService ds = new DataService();

			int x = 5, y = 12;

			bool res = ds.CheckDotInShadedArea(x, y);

			bool wait = false;

			Assert.AreEqual(wait, res);
		}
	}
}
