﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint2.Task1.V18.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint2.Task1.V18.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetLogicOperation()
		{
			DataService ds = new DataService();
			int a = 155;
			int b = 696;
			int c = 242;
			int d = 541;
			bool[] res = new bool[6];
			res = ds.GetLogicOperations(a, b, c, d);
			bool[] wait = new bool[6] { true, true, true, false, true, false };

			CollectionAssert.AreEqual(res, wait);
		}
	}
}
