using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task6.V14.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();

			int k = 1, d = 7;

			string res = ds.FindDayName(k, d);
			string wait = "Воскресенье";

			Assert.AreEqual(res, wait);
		}
	}
}
