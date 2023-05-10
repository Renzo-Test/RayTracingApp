﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UsedModelItem : UserControl
    {
        private List<PosisionatedModel> _posisionatedModels;
        private PosisionatedModel _posisionatedModel;

        private ScenePage _scenePage;
		private bool isEditing = false;

		public UsedModelItem(ScenePage scenePage, PosisionatedModel posisionatedModel, List<PosisionatedModel> posisionatedModels)
        {
            _posisionatedModels = posisionatedModels;
            _posisionatedModel = posisionatedModel;

            _scenePage = scenePage;
            
            InitializeComponent();
            
            txtPosition.Text = GetPosisionatedModelString(posisionatedModel);
            lblName.Text = posisionatedModel.Model.Name;
        }

        private string GetPosisionatedModelString(PosisionatedModel posisionatedModel)
        {
            double X = posisionatedModel.Position.X;
            double Y = posisionatedModel.Position.Y;
            double Z = posisionatedModel.Position.Z;

            return X + "," + Y + "," + Z;
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            _posisionatedModels.Remove(_posisionatedModel);
            _scenePage.PopulateUsedItems();
        }

        public void UpdatePosisionatedModel()
        {

            string[] positionValues = txtPosition.Text.Trim().Split(',');
            _posisionatedModel.Position = new Vector()
            {
                X = Double.Parse(positionValues[0]),
                Y = Double.Parse(positionValues[1]),
                Z = Double.Parse(positionValues[2])
            };

            _scenePage.PopulateUsedItems();
        }

		private void picIconPencilTick_Click(object sender, EventArgs e)
		{
			isEditing = !isEditing;

			if (isEditing)
			{
				picIconPencilTick.Image = GUI.Properties.Resources.tick;
				txtPosition.Enabled = true;
				picXIcon.Visible = true;
			}
			else
			{
				picIconPencilTick.Image = GUI.Properties.Resources.pencil;
				txtPosition.Enabled = true;
				picXIcon.Visible = false;
				UpdatePosisionatedModel();
			}
		}

		private void picXIcon_Click(object sender, EventArgs e)
		{
			isEditing = false;
			picIconPencilTick.Image = GUI.Properties.Resources.pencil;

			txtPosition.Enabled = false;
			picXIcon.Visible = false;

			_scenePage.PopulateUsedItems();
		}
	}
}
