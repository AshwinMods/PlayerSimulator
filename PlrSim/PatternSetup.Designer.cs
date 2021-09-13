
namespace PlrSim
{
	partial class PatternSetup
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
			this.TargetImage = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.WidthNumber = new System.Windows.Forms.NumericUpDown();
			this.XOffset = new System.Windows.Forms.NumericUpDown();
			this.HeightNumber = new System.Windows.Forms.NumericUpDown();
			this.YOffset = new System.Windows.Forms.NumericUpDown();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.CaptureButton = new System.Windows.Forms.Button();
			this.DoneButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TargetImage)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YOffset)).BeginInit();
			this.SuspendLayout();
			// 
			// TargetImage
			// 
			this.TargetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.TargetImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TargetImage.Location = new System.Drawing.Point(6, 19);
			this.TargetImage.Name = "TargetImage";
			this.TargetImage.Size = new System.Drawing.Size(130, 131);
			this.TargetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TargetImage.TabIndex = 0;
			this.TargetImage.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.WidthNumber);
			this.groupBox1.Controls.Add(this.XOffset);
			this.groupBox1.Controls.Add(this.HeightNumber);
			this.groupBox1.Controls.Add(this.YOffset);
			this.groupBox1.Controls.Add(this.BrowseButton);
			this.groupBox1.Controls.Add(this.CaptureButton);
			this.groupBox1.Controls.Add(this.TargetImage);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 158);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Setup";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(234, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "H";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(153, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "W";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(234, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Y";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(153, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "X";
			// 
			// WidthNumber
			// 
			this.WidthNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.WidthNumber.Location = new System.Drawing.Point(173, 45);
			this.WidthNumber.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.WidthNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WidthNumber.Name = "WidthNumber";
			this.WidthNumber.Size = new System.Drawing.Size(50, 20);
			this.WidthNumber.TabIndex = 9;
			this.WidthNumber.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.WidthNumber.ValueChanged += new System.EventHandler(this.WidthNumber_ValueChanged);
			// 
			// XOffset
			// 
			this.XOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.XOffset.Location = new System.Drawing.Point(173, 19);
			this.XOffset.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.XOffset.Name = "XOffset";
			this.XOffset.Size = new System.Drawing.Size(50, 20);
			this.XOffset.TabIndex = 8;
			this.XOffset.ValueChanged += new System.EventHandler(this.XOffset_ValueChanged);
			// 
			// HeightNumber
			// 
			this.HeightNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HeightNumber.Location = new System.Drawing.Point(254, 45);
			this.HeightNumber.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.HeightNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HeightNumber.Name = "HeightNumber";
			this.HeightNumber.Size = new System.Drawing.Size(50, 20);
			this.HeightNumber.TabIndex = 7;
			this.HeightNumber.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.HeightNumber.ValueChanged += new System.EventHandler(this.HeightNumber_ValueChanged);
			// 
			// YOffset
			// 
			this.YOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.YOffset.Location = new System.Drawing.Point(254, 19);
			this.YOffset.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.YOffset.Name = "YOffset";
			this.YOffset.Size = new System.Drawing.Size(50, 20);
			this.YOffset.TabIndex = 6;
			this.YOffset.ValueChanged += new System.EventHandler(this.YOffset_ValueChanged);
			// 
			// BrowseButton
			// 
			this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseButton.Location = new System.Drawing.Point(229, 127);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(75, 23);
			this.BrowseButton.TabIndex = 5;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			// 
			// CaptureButton
			// 
			this.CaptureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CaptureButton.Location = new System.Drawing.Point(148, 127);
			this.CaptureButton.Name = "CaptureButton";
			this.CaptureButton.Size = new System.Drawing.Size(75, 23);
			this.CaptureButton.TabIndex = 4;
			this.CaptureButton.Text = "Capture";
			this.CaptureButton.UseVisualStyleBackColor = true;
			this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
			// 
			// DoneButton
			// 
			this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DoneButton.Location = new System.Drawing.Point(166, 176);
			this.DoneButton.Name = "DoneButton";
			this.DoneButton.Size = new System.Drawing.Size(75, 23);
			this.DoneButton.TabIndex = 2;
			this.DoneButton.Text = "Done";
			this.DoneButton.UseVisualStyleBackColor = true;
			this.DoneButton.Click += new System.EventHandler(this.Done_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Location = new System.Drawing.Point(247, 176);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveButton.Location = new System.Drawing.Point(18, 176);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// PatternSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 211);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.DoneButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PatternSetup";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Pattern Setup";
			((System.ComponentModel.ISupportInitialize)(this.TargetImage)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YOffset)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox TargetImage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Button CaptureButton;
		private System.Windows.Forms.Button DoneButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown WidthNumber;
		private System.Windows.Forms.NumericUpDown XOffset;
		private System.Windows.Forms.NumericUpDown HeightNumber;
		private System.Windows.Forms.NumericUpDown YOffset;
		private System.Windows.Forms.Button SaveButton;
	}
}