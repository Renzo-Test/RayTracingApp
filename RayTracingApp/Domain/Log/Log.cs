using System;

namespace Domain
{
	public class Log
	{
		public int Id { get; set; }
		public int RenderTime { get; set; }
		public Client Owner { get; set; }
		public string RenderDate { get; set; }
		public TimeSpan TimeSpan { get; set; }
		public string SceneName { get; set; }
		public int RenderedElements { get; set; }
	}
}
