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
        private MainForm _mainForm;
        public LogList(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        public void PopulateItems()
        {

            //List<Material> materials = _materialController.ListMaterials(_currentClient);

            flyLogList.Controls.Clear();

            for (int i = 0; i < 4; i++)
            {
                LogItem item = new LogItem();
                flyLogList.Controls.Add(item);
            }

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
