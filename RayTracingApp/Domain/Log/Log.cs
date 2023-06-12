using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Log
    {
        public int Id { get; set; }
        public int RenderTime { get; set; }
        public string Username { get; set; }
        public string RenderDate { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public string SceneName { get; set; }
        public int RenderedElements { get; set; }
    }
}
