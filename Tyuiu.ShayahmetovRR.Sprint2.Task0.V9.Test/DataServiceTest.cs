using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task0.V9.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task0.V9.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public async void ValidException()
		{
			DataService ds = new DataService();
			int x = 1054;
			int y = 375;
			var res = ds.ValidException(x, y);
			bool[] wait = new bool[6] { true, true, true, true, true, false }
			CollectionAssert.AreEqual(wait, res);
		}
	}
}
