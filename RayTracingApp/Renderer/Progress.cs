using System;

namespace Renderer
{
	public class Progress
	{
		public long LinesCount { get; set; }
		public long ExpectedLines { get; set; }

		public void Count()
		{
			LinesCount++;
		}

		public void WriteCurrentPercentage()
		{
			Console.Write("\r{0}", Calculate());
		}

		public long Calculate()
		{
			return (LinesCount * 100) / ExpectedLines;
		}
	}
}
