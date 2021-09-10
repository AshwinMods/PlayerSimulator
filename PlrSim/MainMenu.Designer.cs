
namespace PlrSim
{
	partial class MainMenu
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
			this.NewGameBtn = new System.Windows.Forms.Button();
			this.SaveGameBtn = new System.Windows.Forms.Button();
			this.LoadGameBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.AddTask = new System.Windows.Forms.Button();
			this.RemoveTask = new System.Windows.Forms.Button();
			this.RemovePattern = new System.Windows.Forms.Button();
			this.AddPattern = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.TaskList = new System.Windows.Forms.ListBox();
			this.PatternList = new System.Windows.Forms.ListBox();
			this.ActionList = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// NewGameBtn
			// 
			this.NewGameBtn.Location = new System.Drawing.Point(12, 12);
			this.NewGameBtn.Name = "NewGameBtn";
			this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
			this.NewGameBtn.TabIndex = 0;
			this.NewGameBtn.Text = "New Game";
			this.NewGameBtn.UseVisualStyleBackColor = true;
			this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
			// 
			// SaveGameBtn
			// 
			this.SaveGameBtn.Location = new System.Drawing.Point(93, 12);
			this.SaveGameBtn.Name = "SaveGameBtn";
			this.SaveGameBtn.Size = new System.Drawing.Size(75, 23);
			this.SaveGameBtn.TabIndex = 1;
			this.SaveGameBtn.Text = "Save Game";
			this.SaveGameBtn.UseVisualStyleBackColor = true;
			this.SaveGameBtn.Click += new System.EventHandler(this.SaveGameBtn_Click);
			// 
			// LoadGameBtn
			// 
			this.LoadGameBtn.Location = new System.Drawing.Point(174, 12);
			this.LoadGameBtn.Name = "LoadGameBtn";
			this.LoadGameBtn.Size = new System.Drawing.Size(75, 23);
			this.LoadGameBtn.TabIndex = 2;
			this.LoadGameBtn.Text = "Load Game";
			this.LoadGameBtn.UseVisualStyleBackColor = true;
			this.LoadGameBtn.Click += new System.EventHandler(this.LoadGameBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.ActionList);
			this.groupBox1.Location = new System.Drawing.Point(672, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 500);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Action List";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.PatternList);
			this.groupBox2.Location = new System.Drawing.Point(466, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 500);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Subtaks";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.TaskList);
			this.groupBox3.Location = new System.Drawing.Point(260, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 500);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Main Tasks";
			// 
			// AddTask
			// 
			this.AddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddTask.Location = new System.Drawing.Point(291, 519);
			this.AddTask.Name = "AddTask";
			this.AddTask.Size = new System.Drawing.Size(80, 30);
			this.AddTask.TabIndex = 6;
			this.AddTask.Text = "Add New";
			this.AddTask.UseVisualStyleBackColor = true;
			// 
			// RemoveTask
			// 
			this.RemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveTask.Location = new System.Drawing.Point(377, 519);
			this.RemoveTask.Name = "RemoveTask";
			this.RemoveTask.Size = new System.Drawing.Size(80, 30);
			this.RemoveTask.TabIndex = 7;
			this.RemoveTask.Text = "Remove";
			this.RemoveTask.UseVisualStyleBackColor = true;
			// 
			// RemovePattern
			// 
			this.RemovePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RemovePattern.Location = new System.Drawing.Point(583, 519);
			this.RemovePattern.Name = "RemovePattern";
			this.RemovePattern.Size = new System.Drawing.Size(80, 30);
			this.RemovePattern.TabIndex = 9;
			this.RemovePattern.Text = "Remove";
			this.RemovePattern.UseVisualStyleBackColor = true;
			// 
			// AddPattern
			// 
			this.AddPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddPattern.Location = new System.Drawing.Point(497, 519);
			this.AddPattern.Name = "AddPattern";
			this.AddPattern.Size = new System.Drawing.Size(80, 30);
			this.AddPattern.TabIndex = 8;
			this.AddPattern.Text = "Add New";
			this.AddPattern.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(789, 519);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 30);
			this.button3.TabIndex = 11;
			this.button3.Text = "Remove";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(703, 519);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 30);
			this.button4.TabIndex = 10;
			this.button4.Text = "Add New";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// TaskList
			// 
			this.TaskList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TaskList.FormattingEnabled = true;
			this.TaskList.Location = new System.Drawing.Point(3, 16);
			this.TaskList.Name = "TaskList";
			this.TaskList.Size = new System.Drawing.Size(194, 481);
			this.TaskList.TabIndex = 12;
			// 
			// PatternList
			// 
			this.PatternList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PatternList.FormattingEnabled = true;
			this.PatternList.Location = new System.Drawing.Point(3, 16);
			this.PatternList.Name = "PatternList";
			this.PatternList.Size = new System.Drawing.Size(194, 481);
			this.PatternList.TabIndex = 13;
			// 
			// ActionList
			// 
			this.ActionList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ActionList.FormattingEnabled = true;
			this.ActionList.Location = new System.Drawing.Point(3, 16);
			this.ActionList.Name = "ActionList";
			this.ActionList.Size = new System.Drawing.Size(194, 481);
			this.ActionList.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(53, 211);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 106);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.RemovePattern);
			this.Controls.Add(this.AddPattern);
			this.Controls.Add(this.RemoveTask);
			this.Controls.Add(this.AddTask);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LoadGameBtn);
			this.Controls.Add(this.SaveGameBtn);
			this.Controls.Add(this.NewGameBtn);
			this.Name = "MainMenu";
			this.Text = "Player Simulator";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewGameBtn;
		private System.Windows.Forms.Button SaveGameBtn;
		private System.Windows.Forms.Button LoadGameBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox ActionList;
		private System.Windows.Forms.ListBox PatternList;
		private System.Windows.Forms.ListBox TaskList;
		private System.Windows.Forms.Button AddTask;
		private System.Windows.Forms.Button RemoveTask;
		private System.Windows.Forms.Button RemovePattern;
		private System.Windows.Forms.Button AddPattern;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

