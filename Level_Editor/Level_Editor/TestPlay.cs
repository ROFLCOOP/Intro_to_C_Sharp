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
	public partial class TestPlay : Form
	{
		public TestPlay(PicrossGrid[,] grid, Label[,] xLabels, Label[,] yLabels, Form1 origin)
		{
			InitializeComponent();
			original = origin;
			Location = original.Location;
			original.Hide();
			otherGrid = grid;

			picrossGrid = new PicrossGrid[10, 10];
			gridCountsX = new Label[5, 10];
			gridCountsY = new Label[10, 5];

			for (int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 10; j++)
				{
					picrossGrid[i, j] = new PicrossGrid();
					//picrossGrid[i, j].panel = new Panel();
					picrossGrid[i, j].panel.Parent = this;
					int posX = (j * 16) + 80;
					int posY = (i * 16) + 60;
					picrossGrid[i, j].panel.Location = new Point(posX, posY);
					picrossGrid[i, j].panel.Size = new Size(15, 15);
					picrossGrid[i, j].panel.BorderStyle = BorderStyle.FixedSingle;
					crossed[i, j] = new Label();
					crossed[i, j].Text = "x";
					crossed[i, j].Parent = picrossGrid[i, j].panel;
					crossed[i, j].Visible = false;
					crossed[i, j].Click += Label_Click;

					picrossGrid[i, j].panel.Click += Panel_Click;
					picrossGrid[i, j].panel.MouseMove += panel_MouseMove;
					//panelGrid[i, j].panel.MouseLeave += panel_MouseLeave;
					picrossGrid[i, j].panel.MouseDown += delegate (object sender, MouseEventArgs e)
					{
						gameEditor_MouseDown(sender, e);
					};
					picrossGrid[i, j].panel.MouseUp += delegate (object sender, MouseEventArgs e)
					{
						gameEditor_MouseUp(sender, e);
					};
				}
				for(int j = 0; j < 5; j++)
				{
					gridCountsX[j, i] = new Label();
					gridCountsX[j, i].Parent = this;
					int posY = (i * 16) + 61;
					int posX = (j * 15);
					gridCountsX[j, i].Location = new Point(posX, posY);
					gridCountsX[j, i].Width = 19;
					gridCountsX[j, i].Height = 12;
					gridCountsX[j, i].Text = xLabels[j, i].Text;
					gridCountsX[j, i].Visible = xLabels[j, i].Visible;

					if (gridCountsX[j, i].Text != "0")
						gridCountsX[j, i].Visible = true;

					gridCountsY[i, j] = new Label();
					gridCountsY[i, j].Parent = this;
					posY = (j * 12);
					posX = (i * 16) + 77;
					gridCountsY[i, j].Location = new Point(posX, posY);
					gridCountsY[i, j].Width = 20;
					gridCountsY[i, j].Height = 12;
					gridCountsY[i, j].Text = yLabels[i, j].Text;
					gridCountsY[i, j].Visible = yLabels[i, j].Visible;

                    if (gridCountsY[i, j].Text != "0")
                        gridCountsY[i, j].Visible = true;
                }
			}
		}

		private PicrossGrid[,]	otherGrid;
		private PicrossGrid[,]	picrossGrid;
		private Label[,]		gridCountsX;
		private Label[,]		gridCountsY;
		private Form1			original;

		private bool			leftMouseDown = false;
		private bool			rightMouseDown = false;
		private Panel			prevPanel;
		private Label[,]		crossed = new Label[10,10];

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			original.Show();
			Close();
		}

		private void panel_MouseMove(object sender, MouseEventArgs e)
		{
			Panel panel = (Panel)sender;

			Point screenPoint = panel.PointToScreen(e.Location);

			if (leftMouseDown && !rightMouseDown)
			{
				for (int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 10; j++)
					{
						Rectangle panelRect = picrossGrid[i, j].panel.RectangleToScreen(picrossGrid[i, j].panel.DisplayRectangle);
						if (panelRect.Contains(screenPoint))
						{
							if (prevPanel != picrossGrid[i, j].panel && !crossed[i, j].Visible)
							{
								if (picrossGrid[i, j].panel.BackColor != DefaultBackColor)
								{
									picrossGrid[i, j].panel.BackColor = DefaultBackColor;
								}
								else
								{
									picrossGrid[i, j].panel.BackColor = Color.Black;
								}
								prevPanel = picrossGrid[i, j].panel;
							}
						}
					}
				}
			}
			else if (rightMouseDown && !leftMouseDown)
			{
				for (int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 10; j++)
					{
						Rectangle panelRect = picrossGrid[i, j].panel.RectangleToScreen(picrossGrid[i, j].panel.DisplayRectangle);
						if (panelRect.Contains(screenPoint))
						{
							if (prevPanel != picrossGrid[i, j].panel && picrossGrid[i, j].panel.BackColor == DefaultBackColor)
							{
								if (crossed[i, j].Visible)
								{
									crossed[i, j].Visible = false;
								}
								else
								{
									crossed[i, j].Visible = true;
								}
								prevPanel = picrossGrid[i, j].panel;
							}
						}
					}
				}
			}
		checkWin();
		}

		private void gameEditor_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				leftMouseDown = true;
			else if (e.Button == MouseButtons.Right)
				rightMouseDown = true;
		}

		private void gameEditor_MouseUp(object sender, MouseEventArgs e)
		{
			leftMouseDown = false;
			rightMouseDown = false;
		}


		private void Panel_Click(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			if (leftMouseDown)
			{
				if (panel.BackColor == Color.Black)
				{
					panel.BackColor = DefaultBackColor;
				}
				else
				{
					panel.BackColor = Color.Black;
				}
				checkWin();
			}
			else if(rightMouseDown && panel.BackColor == DefaultBackColor)
			{
				int[] its = GetIterators(panel);
				if(crossed[its[0], its[1]].Visible)
				{
					crossed[its[0], its[1]].Visible = false;
				}
				else if (!crossed[its[0], its[1]].Visible)
				{
					crossed[its[0], its[1]].Visible = true;
				}
			}
		}

		private void Label_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			label.Visible = false;
		}

		private int[] GetIterators(Panel panel)
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (panel == picrossGrid[i, j].panel)
					{
						int[] its = new int[2] { i, j };
						return its;
					}
				}
			}


			return null;
		}

		private void checkWin()
		{
			bool gameWon = true;
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if((picrossGrid[i, j].panel.BackColor == Color.Black && otherGrid[i, j].panel.BackColor == DefaultBackColor) ||
                        (picrossGrid[i, j].panel.BackColor == DefaultBackColor && otherGrid[i, j].panel.BackColor != DefaultBackColor))
					{
						gameWon = false;
					}
				}
			}
			if(gameWon)
			{
                RecolourGrid();
				MessageBox.Show("WIN");
				original.Show();
				Close();
			}
		}
        
        private void RecolourGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    picrossGrid[i, j].panel.BackColor = otherGrid[i, j].panel.BackColor;
                }
            }
        }
	}
}
