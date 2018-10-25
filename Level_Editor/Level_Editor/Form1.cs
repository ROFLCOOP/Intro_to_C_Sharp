using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Level_Editor;
using System.Xml.Serialization;
using System.IO;

namespace Level_Editor
{ 

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			panelGrid = new PicrossGrid[10, 10];
			gridCountsY = new Label[10, 5];
			gridCountsX = new Label[5, 10];
			for (int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 10; j++)
				{
					panelGrid[i, j] = new PicrossGrid(); // this loop creates and sets the positions of the panels in the editor
					panelGrid[i, j].panel.Parent = gameEditor;
					panelGrid[i, j].panel.Name = i.ToString() + " " + j.ToString();
					int posX = (j * 16) + 60;
					int posY = (i * 16) + 60;
					panelGrid[i, j].panel.Location = new Point(posX, posY);
					panelGrid[i, j].panel.Size = new Size(15, 15);
					panelGrid[i, j].panel.BorderStyle = BorderStyle.FixedSingle;
					panelGrid[i, j].itX = j;
					panelGrid[i, j].itY = i;
					panelGrid[i, j].panel.BringToFront();
					panelGrid[i, j].panel.Click += Panel_Click;
					panelGrid[i, j].panel.MouseMove += panel_MouseMove;
					//panelGrid[i, j].panel.MouseLeave += panel_MouseLeave;
					panelGrid[i, j].panel.MouseDown += delegate (object sender, MouseEventArgs e)
					{
						gameEditor_MouseDown(sender, e);
					};
					panelGrid[i, j].panel.MouseUp += delegate (object sender, MouseEventArgs e)
					{
						gameEditor_MouseUp(sender, e);
					};
				}
				for (int j = 0; j < 5; j++)
				{
					gridCountsY[i, j] = new Label(); // this loop creates the numbers used to count up the 
					gridCountsY[i, j].Parent = gameEditor;
					gridCountsY[i, j].Text = "0";
					int posY = (j * 12);
					int posX = (i * 16) + 57;
					gridCountsY[i, j].Location = new Point(posX, posY);
					gridCountsY[i, j].Width = 20;
					gridCountsY[i, j].Height = 12;
					gridCountsX[j, i] = new Label();
					gridCountsX[j, i].Parent = gameEditor;
					gridCountsX[j, i].Text = "0";
					posY = (i * 16) + 61;
					posX = (j * 10);
					gridCountsX[j, i].Location = new Point(posX, posY);
					gridCountsX[j, i].Width = 19;
					gridCountsX[j, i].Height = 12;
					
					gridCountsY[i, j].TextAlign = ContentAlignment.MiddleRight;
					gridCountsX[j, i].BringToFront();
					gridCountsY[i, j].BringToFront();
				}
			}

			for (int i = 0; i < 10; i++)
			{
				ClearColCount(i);
				ClearRowCount(i);
			}
		}
		//class PicrossGrid
		//{
		//	public Panel panel = new Panel();
		//	public int itX;
		//	public int itY;
		//	public Color color = DefaultBackColor;
		//}


		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Panel_Click(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			if (panel.BackColor == selectedColour)
			{
				panel.BackColor = DefaultBackColor;
			}
			else
			{
				panel.BackColor = selectedColour;
			}
			int[] iterators = GetIterators(panel);
			if(iterators == null)
			{
				
			}
			CheckRow(iterators[0]);
			CheckCol(iterators[1]);

		}

		private void CheckRow(int it)
		{
			ClearRowCount(it);
			int counter = 0;
			bool prev = false;
			for(int i = 0; i < 10; i++)
			{
				if (panelGrid[it, i].panel.BackColor != DefaultBackColor && i == 9)
				{
					counter++;
					PushBackRow(it, "" + counter);
				}
				else if (panelGrid[it, i].panel.BackColor != DefaultBackColor)
				{
					counter++;
					prev = true;
				}
				else if (panelGrid[it, i].panel.BackColor == DefaultBackColor && prev)
				{
					if (counter != 0)
					{
						PushBackRow(it, "" + counter);
					}
					counter = 0;
					prev = false;
				}
			}
		}
		private void CheckCol(int it)
		{
			ClearColCount(it);
			int counter = 0;
			bool prev = false;
			for (int i = 0; i < 10; i++)
			{
				if (panelGrid[i, it].panel.BackColor != DefaultBackColor && i == 9)
				{
					counter++;
					PushBackCol(it, "" + counter);
				}
				else if (panelGrid[i, it].panel.BackColor != DefaultBackColor) 
				{
					counter++;
					prev = true;
				}
				else if (panelGrid[i, it].panel.BackColor == DefaultBackColor && prev)
				{
					if (counter != 0)
					{
						PushBackCol(it, "" + counter);
					}
					counter = 0;
					prev = false;
				}
			}
		}

		private void ClearRowCount(int it)
		{
			for (int i = 0; i < 5; i++)
			{
				gridCountsX[i, it].Text = "0";
				gridCountsX[i, it].Visible = false;
			}
		}
		private void ClearColCount(int it)
		{
			for (int i = 0; i < 5; i++)
			{
				gridCountsY[it, i].Text = "0";
				gridCountsY[it, i].Visible = false;
			}
		}
		private int[] GetIterators(Panel panel)
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (panel == panelGrid[i, j].panel)
					{
						int[] its = new int[2] { i, j };
						return its;
					}
				}
			}
			

			return null;
		}

		private void PushBackRow(int it, String value)
		{
			for (int i = 0; i < 5; i++)
			{
				if (gridCountsX[i, it].Text != "0")
				{
					gridCountsX[i - 1, it].Text = gridCountsX[i, it].Text;
					gridCountsX[i - 1, it].Visible = true;
				}
			}
			gridCountsX[4, it].Text = value;
			gridCountsX[4, it].Visible = true;
		}
		private void PushBackCol(int it, String value)
		{
			for (int i = 1; i < 5; i++)
			{
				if (gridCountsY[it, i].Text != "0")
				{
					gridCountsY[it, i - 1].Text = gridCountsY[it, i].Text;
					gridCountsY[it, i - 1].Visible = true;
				}
			}
			gridCountsY[it, 4].Text = value;
			gridCountsY[it, 4].Visible = true;
		}

		Color			selectedColour = Color.Black;
		PicrossGrid[,]	panelGrid;
		Label[,]		gridCountsY;
		Label[,]		gridCountsX;
		bool			mouseDown = false;
		Panel			prevPanel;
		//public string			SaveName;


		[Serializable]
		public class SaveData
		{
			public List<int> colors = new List<int>();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			SaveForm saveForm = new SaveForm(this);

		}
		

		

		private void panel_MouseMove(object sender, MouseEventArgs e)
		{
			Panel panel = (Panel)sender;

			Point screenPoint = panel.PointToScreen(e.Location);

			if (mouseDown)
			{
				//panel.BackColor = selectedColour;
				//panelGrid[x, y].panel.BackColor = Color.Red;
				for(int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 10; j++)
					{
					Rectangle panelRect = panelGrid[i, j].panel.RectangleToScreen(panelGrid[i, j].panel.DisplayRectangle);
						if (panelRect.Contains(screenPoint))
						{
							if (prevPanel != panelGrid[i, j].panel)
							{
								if (panelGrid[i, j].panel.BackColor != DefaultBackColor)
								{
									panelGrid[i, j].panel.BackColor = DefaultBackColor;
								}
								else
								{
									panelGrid[i, j].panel.BackColor = selectedColour;
								}
								CheckRow(i); CheckCol(j);
								prevPanel = panelGrid[i, j].panel;
							}
						}
					}
				}
			}
			
		}

		private void gameEditor_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
		}

		private void gameEditor_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			//MessageBox.Show("Dropped");

			string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
			XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
			TextReader reader = new StreamReader(file[0]);
			SaveData loadData = (SaveData)serializer.Deserialize(reader);

			for(int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 10; j++)
				{
					Color c = Color.FromArgb(loadData.colors[j + (i * 10)]);
					if(c.Name == "fff0f0f0") // "fff0f0f0 is code for DefaultBackColor, but is not names defaultbackcolor, so it needs to be assigned properly
					{
						panelGrid[i, j].panel.BackColor = DefaultBackColor;
					}
					else
					{
					panelGrid[i, j].panel.BackColor = Color.Black;
					}
				}
			}
			for(int i = 0; i < 10; i++)
			{
				CheckCol(i);
				CheckRow(i);
			}
		}
		public bool SaveOutput(string fileName)
		{

			if (fileName != "" && fileName != " ")
			{
				SaveData data = new SaveData();
				for (int i = 0; i < 100; i++) data.colors.Add(0);
				for(int i = 0; i < 10; i++)
				{
					for(int j = 0; j < 10; j++)
					{
						int r = panelGrid[i, j].panel.BackColor.R;
						int g = panelGrid[i, j].panel.BackColor.G;
						int b = panelGrid[i, j].panel.BackColor.B;
						Color c = Color.FromArgb(r, g, b);
						data.colors[j + (i * 10)] = c.ToArgb();
					}
				}
				XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
				TextWriter writer = new StreamWriter(fileName + ".xml");

				//SaveLoader colors = new SaveLoader(panelGrid);
				serializer.Serialize(writer, data);
				writer.Close();
				fileName = null;
				return true;
			}
			else
			{
				return false;
			}
		}

		private void ButtonNew_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 10; i++)
				for(int j = 0; j < 10; j++)
				{
					panelGrid[i, j].panel.BackColor = DefaultBackColor;
				}

			for (int i = 0; i < 10; i++)
			{
				ClearColCount(i);
				ClearRowCount(i);
			}
		}

		private void Test_Click(object sender, EventArgs e)
		{
			TestPlay test = new TestPlay(panelGrid, gridCountsX, gridCountsY, this);
			test.Show();
			//Hide();
		}

        private void comboBoxColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox colour = (ComboBox)sender;

            if(colour.Text == "Black")
            {
                selectedColour = Color.Black;
            }
            else if(colour.Text == "Blue")
            {
                selectedColour = Color.Blue;
            }
            else if (colour.Text == "Yellow")
            {
                selectedColour = Color.Yellow;
            }
            else if (colour.Text == "Green")
            {
                selectedColour = Color.Green;
            }
            else if (colour.Text == "Red")
            {
                selectedColour = Color.Red;
            }
            else if (colour.Text == "Orange")
            {
                selectedColour = Color.Orange;
            }
            else if (colour.Text == "Purple")
            {
                selectedColour = Color.Purple;
            }
        }
    }
	
}
