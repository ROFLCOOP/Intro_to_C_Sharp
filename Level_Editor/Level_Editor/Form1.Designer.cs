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
            this.ButtonTestPlay = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // ButtonTestPlay
            // 
            this.ButtonTestPlay.Location = new System.Drawing.Point(12, 12);
            this.ButtonTestPlay.Name = "ButtonTestPlay";
            this.ButtonTestPlay.Size = new System.Drawing.Size(150, 47);
            this.ButtonTestPlay.TabIndex = 2;
            this.ButtonTestPlay.Text = "Test Play";
            this.ButtonTestPlay.UseVisualStyleBackColor = true;
            this.ButtonTestPlay.Click += new System.EventHandler(this.Test_Click);
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
            this.comboBoxColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Yellow",
            "Green",
            "Red",
            "Orange",
            "Purple"});
            this.comboBoxColour.Location = new System.Drawing.Point(68, 65);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(90, 21);
            this.comboBoxColour.TabIndex = 4;
            this.comboBoxColour.SelectedIndexChanged += new System.EventHandler(this.comboBoxColour_SelectedIndexChanged);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(12, 93);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(75, 23);
            this.ButtonNew.TabIndex = 5;
            this.ButtonNew.Text = "New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click and drag on the 10 x10\r\ngrid to create a picross level";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 52);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Colour:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ButtonTestPlay);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.gameEditor);
            this.Name = "Form1";
            this.Text = "Picross Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel gameEditor;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonTestPlay;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ComboBox comboBoxColour;
		private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

