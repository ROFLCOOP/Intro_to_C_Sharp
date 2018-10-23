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
			this.buttonSave = new System.Windows.Forms.Button();
			this.comboBoxColour = new System.Windows.Forms.ComboBox();
			this.ButtonNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gameEditor
			// 
			this.gameEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gameEditor.Location = new System.Drawing.Point(170, 12);
			this.gameEditor.Name = "gameEditor";
			this.gameEditor.Size = new System.Drawing.Size(249, 232);
			this.gameEditor.TabIndex = 0;
			this.gameEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameEditor_MouseDown);
			this.gameEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gameEditor_MouseUp);
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
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(12, 122);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.Save_Click);
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
			// 
			// ButtonNew
			// 
			this.ButtonNew.Location = new System.Drawing.Point(13, 93);
			this.ButtonNew.Name = "ButtonNew";
			this.ButtonNew.Size = new System.Drawing.Size(75, 23);
			this.ButtonNew.TabIndex = 5;
			this.ButtonNew.Text = "New";
			this.ButtonNew.UseVisualStyleBackColor = true;
			this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 256);
			this.Controls.Add(this.ButtonNew);
			this.Controls.Add(this.comboBoxColour);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.gameEditor);
			this.Name = "Form1";
			this.Text = "Picross Editor";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel gameEditor;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ComboBox comboBoxColour;
		private System.Windows.Forms.Button ButtonNew;
	}
}

