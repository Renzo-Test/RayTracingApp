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
    public partial class SignUp : UserControl
    {
        private MainForm _mainForm;

        public SignUp(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
    }
}
