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
        private const int SecondSplittedOption = 1;
        private const char SplittingSeparator = '-';

        public LogItem(Log log)
        {
            InitializeComponent();
            InitializeAttributes(log);
        }

        private void InitializeAttributes(Log log)
        {
            lblLogName.Text = $"{log.SceneName} - {log.Owner.Username}";
            lblRenderWindow.Text = $"Render Window: {log.TimeSpan}";
            lblRenderTime.Text = $"Render Time: {log.RenderTime} seconds";
            lblRenderDate.Text = $"Render Date: {GetFormatedRenderDate(log)}";
            lblRenderedObjects.Text = $"Rendered Objects: {log.RenderedElements}";
        }

        private static string GetFormatedRenderDate(Log log)
        {
            return log.RenderDate.Split(SplittingSeparator)[SecondSplittedOption];
        }
    }
}
