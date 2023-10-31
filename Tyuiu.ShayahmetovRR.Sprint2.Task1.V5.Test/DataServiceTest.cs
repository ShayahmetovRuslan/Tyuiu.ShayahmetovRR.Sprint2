using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task1.V5.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task1.V5.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetLogicOperations()
		{
			DataService ds = new DataService();

			bool[] wait = new bool[6];

			int a = 154, b = 163, c = 134, d = 137;
			wait[0] = true;
			wait[1] = false;
			wait[2] = false;
			wait[3] = false;
			wait[4] = true;
			wait[5] = false;

			bool[] res = ds.GetLogicOperations(a, b, c, d);

			CollectionAssert.AreEqual(wait, res);
		}
	}
}
