using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task0.V3.Lib;
namespace Tyuiu.ShayahmetovRR.Sprint2.Task0.V3.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetLogicOperation()
		{
			DataService ds = new DataService();
			int x = 45;
			int y = 127;
			var res = ds.GetCompareOperations(x, y);
			bool[] wait = new bool[6] { false, true, false, true, false, true };
			CollectionAssert.AreEqual(wait, res);
		}
	}
}
