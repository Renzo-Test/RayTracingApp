using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Engine;

namespace Test.EngineTest
{
	[TestClass]
	public class HitRecordTest
	{
		[TestMethod]
		public void CreateHitRecord_OkTest()
		{
			HitRecord hitRecord = new HitRecord();
		}
	}
}
