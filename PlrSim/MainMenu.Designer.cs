
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.AddMainTaskButton = new System.Windows.Forms.Button();
			this.MainLoopListBox = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// NewGameBtn
			// 
			this.NewGameBtn.Location = new System.Drawing.Point(15, 15);
			this.NewGameBtn.Name = "NewGameBtn";
			this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
			this.NewGameBtn.TabIndex = 0;
			this.NewGameBtn.Text = "New Game";
			this.NewGameBtn.UseVisualStyleBackColor = true;
			this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
			// 
			// SaveGameBtn
			// 
			this.SaveGameBtn.Location = new System.Drawing.Point(96, 15);
			this.SaveGameBtn.Name = "SaveGameBtn";
			this.SaveGameBtn.Size = new System.Drawing.Size(75, 23);
			this.SaveGameBtn.TabIndex = 1;
			this.SaveGameBtn.Text = "Save Game";
			this.SaveGameBtn.UseVisualStyleBackColor = true;
			this.SaveGameBtn.Click += new System.EventHandler(this.SaveGameBtn_Click);
			// 
			// LoadGameBtn
			// 
			this.LoadGameBtn.Location = new System.Drawing.Point(177, 15);
			this.LoadGameBtn.Name = "LoadGameBtn";
			this.LoadGameBtn.Size = new System.Drawing.Size(75, 23);
			this.LoadGameBtn.TabIndex = 2;
			this.LoadGameBtn.Text = "Load Game";
			this.LoadGameBtn.UseVisualStyleBackColor = true;
			this.LoadGameBtn.Click += new System.EventHandler(this.LoadGameBtn_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.NewGameBtn);
			this.splitContainer1.Panel1.Controls.Add(this.LoadGameBtn);
			this.splitContainer1.Panel1.Controls.Add(this.SaveGameBtn);
			this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(6);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(12);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			this.splitContainer1.Panel1MinSize = 40;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(6);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(12);
			this.splitContainer1.Size = new System.Drawing.Size(531, 678);
			this.splitContainer1.SplitterDistance = 75;
			this.splitContainer1.TabIndex = 4;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(499, 543);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Screen Patterns";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.listBox2);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Location = new System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 531);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pattern Types";
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.Location = new System.Drawing.Point(84, 505);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(60, 20);
			this.button5.TabIndex = 2;
			this.button5.Text = "Remove";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.Location = new System.Drawing.Point(6, 505);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(60, 20);
			this.button4.TabIndex = 1;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// listBox2
			// 
			this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(6, 19);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(138, 472);
			this.listBox2.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.listView1);
			this.groupBox4.Controls.Add(this.button6);
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.Location = new System.Drawing.Point(162, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(331, 531);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Image Patterns";
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.Location = new System.Drawing.Point(265, 505);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(60, 20);
			this.button7.TabIndex = 2;
			this.button7.Text = "Remove";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Location = new System.Drawing.Point(187, 505);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(60, 20);
			this.button6.TabIndex = 1;
			this.button6.Text = "Add";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(6, 19);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(319, 472);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(499, 543);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main loop";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.MainLoopListBox);
			this.groupBox1.Controls.Add(this.AddMainTaskButton);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 531);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game Tasks";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(84, 505);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 20);
			this.button1.TabIndex = 2;
			this.button1.Text = "Remove";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// AddMainTaskButton
			// 
			this.AddMainTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddMainTaskButton.Location = new System.Drawing.Point(6, 505);
			this.AddMainTaskButton.Name = "AddMainTaskButton";
			this.AddMainTaskButton.Size = new System.Drawing.Size(60, 20);
			this.AddMainTaskButton.TabIndex = 1;
			this.AddMainTaskButton.Text = "Add";
			this.AddMainTaskButton.UseVisualStyleBackColor = true;
			// 
			// MainLoopListBox
			// 
			this.MainLoopListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.MainLoopListBox.FormattingEnabled = true;
			this.MainLoopListBox.Location = new System.Drawing.Point(6, 19);
			this.MainLoopListBox.Name = "MainLoopListBox";
			this.MainLoopListBox.Size = new System.Drawing.Size(138, 472);
			this.MainLoopListBox.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new System.Drawing.Point(161, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(332, 531);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Player Task Sequence";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(266, 505);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 20);
			this.button2.TabIndex = 5;
			this.button2.Text = "Remove";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(188, 505);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(60, 20);
			this.button3.TabIndex = 4;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(320, 472);
			this.listBox1.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(12, 6);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(507, 575);
			this.tabControl1.TabIndex = 3;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 678);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainMenu";
			this.Text = "Player Simulator";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewGameBtn;
		private System.Windows.Forms.Button SaveGameBtn;
		private System.Windows.Forms.Button LoadGameBtn;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox MainLoopListBox;
		private System.Windows.Forms.Button AddMainTaskButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

