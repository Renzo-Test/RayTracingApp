using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.Exceptions;
using Engine.Exporter;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace GUI
{
    public partial class ExportPage : UserControl
    {
        public SceneHome _sceneHome;
        public Image _img;
        public string _imgName;

        private const string EmptyPathErrorMessage = "Path must not be empty!";
        public ExportPage(SceneHome sceneHome, Image img, string name)
        {
            _sceneHome = sceneHome;
            _img = img;
            _imgName = name;
            InitializeComponent();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath.Text = dialog.FileName;
            }
        }

        private void ExportImage(IExporter exporter, string format)
        {
            if (String.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show(EmptyPathErrorMessage);
                return;
            }

            try
            {
                string path = Path.Combine(txtPath.Text, _imgName + "." + format);
                exporter.Export(path, _img);
                _sceneHome.GoToSceneList();
            }
            catch (ExporterException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picIconBack_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToSceneList();
        }

        private void lblPPM_Click(object sender, EventArgs e)
        {
            IExporter exporter = new PPMExporter();
            ExportImage(exporter, "ppm");
        }

        private void picBGPPM_Click(object sender, EventArgs e)
        {
            IExporter exporter = new PPMExporter();
            ExportImage(exporter, "ppm");
        }

        private void lblPNG_Click(object sender, EventArgs e)
        {
            IExporter exporter = new PNGExporter();
            ExportImage(exporter, "png");
        }

        private void picBGPNG_Click(object sender, EventArgs e)
        {
            IExporter exporter = new PNGExporter();
            ExportImage(exporter, "png");
        }

        private void lblJPG_Click(object sender, EventArgs e)
        {
            IExporter exporter = new JPGExporter();
            ExportImage(exporter, "jpg");
        }

        private void picBGJPG_Click(object sender, EventArgs e)
        {
            IExporter exporter = new JPGExporter();
            ExportImage(exporter, "jpg");
        }

    }
}
