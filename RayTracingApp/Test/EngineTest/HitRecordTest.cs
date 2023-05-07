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

		[TestMethod]
		public void SetT_OkTest()
		{
			HitRecord hitRecord = new HitRecord();
			hitRecord.T = 1;

			Assert.AreEqual(1, hitRecord.T);
		}

		[TestMethod]
		public void SetT_double_OkTest()
		{
			HitRecord hitRecord = new HitRecord();
			hitRecord.T = 1.5;

			Assert.AreEqual(1.5, hitRecord.T);
		}
	}
}
