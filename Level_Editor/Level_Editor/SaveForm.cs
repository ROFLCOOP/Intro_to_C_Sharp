using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor
{
	public partial class SaveForm : Form
	{
		public SaveForm(Form1 other)
		{
			InitializeComponent();
			Origin = other;
			Origin.Hide();
			Show();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{

			if (Origin.SaveOutput(textFileName.Text))
			{
				Origin.Show();
				Close();
			}
			else
			{
				MessageBox.Show("Please enter a name in the textbox.");
			}
		}
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Origin.Show();
			Close();
		}
		
		Form1 Origin;

	}
}
