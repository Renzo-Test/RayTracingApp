using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LogsView
{
    public partial class LogItem : UserControl
    {
        public LogItem(Log log)
        {
            InitializeComponent();
            InitializeAttributes(log);
        }

        private void InitializeAttributes(Log log)
        {
            lblLogName.Text = $"{log.SceneName} - {log.Owner}";
            lblRenderWindow.Text = $"Render Window: {log.TimeSpan}";
            lblRenderTime.Text = $"Render Time: {log.RenderTime}";
            lblRenderDate.Text = $"Render Date: {log.RenderDate}";
            lblRenderedObjects.Text = $"Rendered Objects: {log.RenderedElements}";
        }
    }
}
