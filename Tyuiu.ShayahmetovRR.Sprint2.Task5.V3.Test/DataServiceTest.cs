using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task5.V3.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task5.V3.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();

			int value = 1;

			string wait = "Понедельник";
			string res = ds.FindDayName(value);

			Assert.AreEqual(res, wait);
		}
	}
}
