using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Engine
{
	public class Progress
	{
		public ProgressBar ProgressBar { get; set; }
		public long LinesCount { get; set; } = 0;
		public long ExpectedLines { get; set; } = 0;

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

		[ExcludeFromCodeCoverage]
        public void UpdateProgressBar()
        {
			if (ProgressBar is object)
			{
				ProgressBar.BeginInvoke(
				new Action(() =>
				{
					int progress = (int)Calculate();

					if (progress <= 100)
					{
						ProgressBar.Value = progress;
					}
				}));
			}
		}
    }
}
