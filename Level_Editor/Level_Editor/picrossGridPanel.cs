using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Level_Editor
{
	class picrossGridPanel
	{
		public picrossGridPanel(Panel parent, int posX, int posY)
		{
			m_panel = new Panel();
			m_panel.Name = ("picrossGrid" + ((posY - 95) / 21)) + ((posX - 125) / 21);
			m_panel.Size = new System.Drawing.Size(20, 20);
			m_panel.Parent = parent;
			m_panel.Location = new System.Drawing.Point(posX, posY);
			m_panel.BorderStyle = BorderStyle.FixedSingle;

		}
		


		Panel m_panel;
	}
}
