namespace Level_Editor
{
	partial class TestPlay
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextInstruction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 230);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextInstruction
            // 
            this.TextInstruction.AutoSize = true;
            this.TextInstruction.Location = new System.Drawing.Point(3, 9);
            this.TextInstruction.Name = "TextInstruction";
            this.TextInstruction.Size = new System.Drawing.Size(100, 26);
            this.TextInstruction.TabIndex = 1;
            this.TextInstruction.Text = "Left-Click to fill box\r\nRight-Click to X box";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TextInstruction);
            this.panel1.Location = new System.Drawing.Point(140, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 44);
            this.panel1.TabIndex = 2;
            // 
            // TestPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonExit);
            this.Name = "TestPlay";
            this.Text = "Test Play";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label TextInstruction;
        private System.Windows.Forms.Panel panel1;
    }
}