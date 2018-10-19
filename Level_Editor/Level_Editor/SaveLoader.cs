using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Level_Editor
{
	class SaveLoader
	{
		public SaveLoader()
		{
			m_Colors = new Color[10, 10];
		}
		public SaveLoader(PicrossGrid[,] grid)
		{
			m_Colors = new Color[10, 10];
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					m_Colors[i, j] = grid[i, j].panel.BackColor;
				}
			}
		}

		public void SetColors(PicrossGrid[,] grid)
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					m_Colors[i, j] = grid[i, j].panel.BackColor;
				}
			}
		}

		//public Color[,] m_Colors { get; set; } = Control.DefaultBackColor;
		
		public Color[,] m_Colors { get;}
		
		
	}
}
