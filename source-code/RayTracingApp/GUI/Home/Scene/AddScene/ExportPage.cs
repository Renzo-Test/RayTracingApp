using Engine.Exceptions;
using Engine.Exporter;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GUI
{
	public partial class ExportPage : UserControl
	{
		public SceneHome _sceneHome;
		public Image _img;
		public string _imgName;

		private const string EmptyPathErrorMessage = "Path must not be empty!";
        private const string PpmFormat = "ppm";
        private const string PngFormat = "png";
        private const string JpgFormat = "jpg";

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
			ExportImage(exporter, PpmFormat);
		}

		private void picBGPPM_Click(object sender, EventArgs e)
		{
			IExporter exporter = new PPMExporter();
			ExportImage(exporter, PpmFormat);
		}

		private void lblPNG_Click(object sender, EventArgs e)
		{
			IExporter exporter = new PNGExporter();
			ExportImage(exporter, PngFormat);
		}

		private void picBGPNG_Click(object sender, EventArgs e)
		{
			IExporter exporter = new PNGExporter();
			ExportImage(exporter, PngFormat);
		}

		private void lblJPG_Click(object sender, EventArgs e)
		{
			IExporter exporter = new JPGExporter();
			ExportImage(exporter, JpgFormat);
		}

		private void picBGJPG_Click(object sender, EventArgs e)
		{
			IExporter exporter = new JPGExporter();
			ExportImage(exporter, JpgFormat);
		}

	}
}
