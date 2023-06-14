using Controller;
using Domain;
using GUI.LogsView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LogList : UserControl
    {
        private LogController _logController;
        private MainForm _mainForm;
        
        private List<Log> _logs;

        private int _averageRenderTime = 0;
        private int _totalRenderTime = 0;
        private string _userWithMaxAccumulatedRenderTime = String.Empty; 


        public LogList(MainForm mainForm, LogController logController)
        {
            _logController = logController;
            _mainForm = mainForm;

            _logs = _logController.ListLogs();

            InitializeAttributes();
            InitializeComponent();
            PopulateItems();
        }

        private void InitializeAttributes()
        {
            if(_logs.Count() == 0) 
            {
                return;
            }

            _averageRenderTime = _logController.GetAverageRenderTimeInSeconds();
            _totalRenderTime = _logController.GetTotalRenderTimeInMinutes();
            _userWithMaxAccumulatedRenderTime = _logController.GetUserWithMaxAccumulatedRenderTime().Username;
        }

        public void PopulateItems()
        {
            if (_logs.Count() == 0)
            {
                return;
            }


            flyLogList.Controls.Clear();

            foreach (Log log in _logs)
            {
                LogItem item = new LogItem(log);
                flyLogList.Controls.Add(item);
            }

            lblRenderTimeRes.Text = $"{_averageRenderTime} seconds";
            lblTotalRenderTimeRes.Text = $"{_totalRenderTime} minutes";
            lblTopRenderTimeRes.Text = $"{_userWithMaxAccumulatedRenderTime}";

        }

        private void picIconBack_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }

        private void LogList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
        }


    }
}
