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

namespace GUI
{
    public partial class AvailableModelItem : UserControl
    {
        private List<PosisionatedModel> _posisionatedModels;
        private Model _model;
        private ScenePage _scenePage;

        public AvailableModelItem(ScenePage scenePage, Model model, List<PosisionatedModel> posisionatedModels)
        {
            _posisionatedModels = posisionatedModels;
            _model = model;
            _scenePage = scenePage;

            InitializeComponent();
            lblModelName.Text = model.Name;

        }

        private void AvailableModelItem_Load(object sender, EventArgs e)
        {

        }

        private void picAddButton_Click(object sender, EventArgs e)
        {
            PosisionatedModel posisionatedModel = new PosisionatedModel()
            {
                Model = _model,
                Position = new Vector() { X = 0, Y = 0, Z = 0 },
            };

            _posisionatedModels.Add(posisionatedModel);
            _scenePage.PopulateUsedItems();
        }
    }
}
