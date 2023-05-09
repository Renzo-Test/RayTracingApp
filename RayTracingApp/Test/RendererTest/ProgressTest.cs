using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Test.EngineTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ProgressTest
	{
		private Progress _progress;

		[TestInitialize]
		public void TestInitialize()
		{
			_progress = new Progress();
		}

		[TestMethod]
		public void CreateProgress_OkTest()
		{
			Progress progress = new Progress();
		}

		[TestMethod]
		public void SetLinesCount_OkTest()
		{
			_progress.LinesCount = 0;

			Assert.AreEqual(0, _progress.LinesCount);
		}

		[TestMethod]
		public void SetLinesCount_uint_OkTest()
		{
			_progress.LinesCount = 2147483648;

			Assert.AreEqual(2147483648, _progress.LinesCount);
		}

		[TestMethod]
		public void SetLinesCount_long_OkTest()
		{
			_progress.LinesCount = 4294967296;

			Assert.AreEqual(4294967296, _progress.LinesCount);
		}

		[TestMethod]
		public void SetExpectedLines_OkTest()
		{
			_progress.ExpectedLines = 0;

			Assert.AreEqual(0, _progress.ExpectedLines);
		}

		[TestMethod]
		public void SetExpectedLines_uint_OkTest()
		{
			_progress.ExpectedLines = 2147483648;

			Assert.AreEqual(2147483648, _progress.ExpectedLines);
		}

		[TestMethod]
		public void SetExpectedLines_long_OkTest()
		{
			_progress.ExpectedLines = 4294967296;

			Assert.AreEqual(4294967296, _progress.ExpectedLines);
		}

		[TestMethod]
		public void Count_OkTest()
		{
			int linesToCount = 5000;
			for (int i = 0; i < linesToCount; i++)
			{
				_progress.Count();
			}

			Assert.AreEqual(5000, _progress.LinesCount);
		}

		[TestMethod]
		public void Count_otherValue_OkTest()
		{
			int linesToCount = 999999;
			for (int i = 0; i < linesToCount; i++)
			{
				_progress.Count();
			}

			Assert.AreEqual(999999, _progress.LinesCount);
		}

		[TestMethod]
		public void Calculate_OkTest()
		{
			_progress.LinesCount = 10;
			_progress.ExpectedLines = 20;

			Assert.AreEqual(50, _progress.Calculate());
		}

		[TestMethod]
		public void Calculate_otherValue_OkTest()
		{
			_progress.LinesCount = 20;
			_progress.ExpectedLines = 20;

			Assert.AreEqual(100, _progress.Calculate());
		}

		[TestMethod]
		public void Calculate_0_OkTest()
		{
			_progress.LinesCount = 0;
			_progress.ExpectedLines = 20;

			Assert.AreEqual(0, _progress.Calculate());
		}

		[TestMethod]
		public void WriteCurrentPercentage_OkTest()
		{
			_progress.ExpectedLines = 50;
			long linesToCount = _progress.ExpectedLines;

			for (int i = 0; i < linesToCount; i++)
			{
				_progress.Count();
				using (StringWriter stringWriter = new StringWriter())
				{
					Console.SetOut(stringWriter);

					_progress.WriteCurrentPercentage();

					string consoleOutput = stringWriter.ToString();
					string actual = "\r" + _progress.Calculate().ToString();
					Assert.AreEqual(actual, consoleOutput);
				}
			}
		}
	}
}
