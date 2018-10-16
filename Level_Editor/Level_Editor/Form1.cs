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
					int posX = (j * 16) + 60;
					int posY = (i * 16) + 60;
					panelGrid[i, j].panel.Location = new Point(posX, posY);
					panelGrid[i, j].panel.Size = new Size(15, 15);
					panelGrid[i, j].panel.BorderStyle = BorderStyle.FixedSingle;
					panelGrid[i, j].panel.Click += panel_Click;
					panelGrid[i, j].itX = j;
					panelGrid[i, j].itY = i;
					panelGrid[i, j].panel.BringToFront();
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
					posY = (i * 15) + 61;
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
				clearColCount(i);
				clearRowCount(i);
			}
		}
		class PicrossGrid
		{
			public Panel panel = new Panel();
			public int itX;
			public int itY;
			public Color color = DefaultBackColor;
		}


		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel_Click(object sender, EventArgs e)
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
			int[] iterators = getIterators(panel);
			if(iterators == null)
			{
				
			}
			checkRow(iterators[0]);
			checkCol(iterators[1]);

		}

		private void checkRow(int it)
		{
			clearRowCount(it);
			int counter = 0;
			bool prev = false;
			for(int i = 0; i < 10; i++)
			{
				if (panelGrid[it, i].panel.BackColor != DefaultBackColor && i == 9)
				{
					counter++;
					pushBackRow(it, "" + counter);
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
						pushBackRow(it, "" + counter);
					}
					counter = 0;
					prev = false;
				}
			}
		}
		private void checkCol(int it)
		{
			clearColCount(it);
			int counter = 0;
			bool prev = false;
			for (int i = 0; i < 10; i++)
			{
				if (panelGrid[i, it].panel.BackColor != DefaultBackColor && i == 9)
				{
					counter++;
					pushBackCol(it, "" + counter);
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
						pushBackCol(it, "" + counter);
					}
					counter = 0;
					prev = false;
				}
			}
		}

		private void clearRowCount(int it)
		{
			for (int i = 0; i < 5; i++)
			{
				gridCountsX[i, it].Text = "0";
				gridCountsX[i, it].Visible = false;
			}
		}
		private void clearColCount(int it)
		{
			for (int i = 0; i < 5; i++)
			{
				gridCountsY[it, i].Text = "0";
				gridCountsY[it, i].Visible = false;
			}
		}
		private int[] getIterators(Panel panel)
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

		private void pushBackRow(int it, String value)
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
		private void pushBackCol(int it, String value)
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


		private void comboBoxColour_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if((String)comboBox.SelectedItem == "Black")
			{
				selectedColour = Color.Black;
			}
			else if((String)comboBox.SelectedItem == "Blue")
			{
				selectedColour = Color.Blue;
			}
			else if ((String)comboBox.SelectedItem == "Yellow")
			{
				selectedColour = Color.Yellow;
			}
			else if ((String)comboBox.SelectedItem == "Green")
			{
				selectedColour = Color.Green;
			}
			else if ((String)comboBox.SelectedItem == "Red")
			{
				selectedColour = Color.Red;
			}
			else if ((String)comboBox.SelectedItem == "Orange")
			{
				selectedColour = Color.Orange;
			}
			else if ((String)comboBox.SelectedItem == "Purple")
			{
				selectedColour = Color.Purple;
			}
		}

		Color selectedColour = Color.Black;
		PicrossGrid[,] panelGrid;
		Label[,] gridCountsY;
		Label[,] gridCountsX;

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
