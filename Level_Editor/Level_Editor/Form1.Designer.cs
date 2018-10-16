namespace Level_Editor
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gameEditor = new System.Windows.Forms.Panel();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBoxColour = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gameEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// gameEditor
			// 
			this.gameEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gameEditor.Controls.Add(this.pictureBox1);
			this.gameEditor.Location = new System.Drawing.Point(170, 12);
			this.gameEditor.Name = "gameEditor";
			this.gameEditor.Size = new System.Drawing.Size(249, 232);
			this.gameEditor.TabIndex = 0;
			// 
			// ButtonExit
			// 
			this.ButtonExit.Location = new System.Drawing.Point(12, 210);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(75, 23);
			this.ButtonExit.TabIndex = 1;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "Test Play";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 103);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBoxColour
			// 
			this.comboBoxColour.FormattingEnabled = true;
			this.comboBoxColour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Yellow",
            "Green",
            "Red",
            "Orange",
            "Purple"});
			this.comboBoxColour.Location = new System.Drawing.Point(13, 66);
			this.comboBoxColour.Name = "comboBoxColour";
			this.comboBoxColour.Size = new System.Drawing.Size(90, 21);
			this.comboBoxColour.TabIndex = 4;
			this.comboBoxColour.Text = "Select Colour";
			this.comboBoxColour.SelectionChangeCommitted += new System.EventHandler(this.comboBoxColour_SelectionChangeCommitted);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(239, 222);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 256);
			this.Controls.Add(this.comboBoxColour);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.gameEditor);
			this.Name = "Form1";
			this.Text = "Picross Editor";
			this.gameEditor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel gameEditor;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBoxColour;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

