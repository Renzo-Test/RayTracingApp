﻿using System;
using System.Windows.Forms;

namespace Engine
{
	public class Progress
	{
		public ProgressBar ProgressBar { get; set; }
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

        public void UpdateProgressBar()
        {
			ProgressBar.BeginInvoke(
			new Action(() =>
			{
				int progress = (int)Calculate();
				
				if(progress <= 100)
                {
					ProgressBar.Value = progress;
                }
			}));
		}
    }
}
