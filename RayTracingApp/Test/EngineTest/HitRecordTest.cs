using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Engine;

namespace Test.EngineTest
{
	[TestClass]
	public class HitRecordTest
	{
		private HitRecord _hitRecord;

		[TestInitialize]
		public void TestInitialize()
		{
			_hitRecord = new HitRecord();
		}

		[TestMethod]
		public void CreateHitRecord_OkTest()
		{
			HitRecord hitRecord = new HitRecord();
		}

		[TestMethod]
		public void SetT_OkTest()
		{
			_hitRecord.T = 1;

			Assert.AreEqual(1, _hitRecord.T);
		}

		[TestMethod]
		public void SetT_double_OkTest()
		{
			_hitRecord.T = 1.5;

			Assert.AreEqual(1.5, _hitRecord.T);
		}

		[TestMethod]
		public void SetIntersection_OkTest()
		{
			Vector expected = new Vector();
			_hitRecord.Intersection = expected;

			Assert.AreEqual(expected, _hitRecord.Intersection);
		}

		[TestMethod]
		public void SetNormal_OkTest()
		{
			Vector expected = new Vector();
			_hitRecord.Normal = expected;

			Assert.AreEqual(expected, _hitRecord.Normal);
		}

		[TestMethod]
		public void SetAttenuation_OkTest()
		{
			Vector expected = new Vector();
			_hitRecord.Attenuation = expected;

			Assert.AreEqual(expected, _hitRecord.Attenuation);
		}
	}
}
