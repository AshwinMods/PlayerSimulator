
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
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 622);
			this.Controls.Add(this.LoadGameBtn);
			this.Controls.Add(this.SaveGameBtn);
			this.Controls.Add(this.NewGameBtn);
			this.Name = "MainMenu";
			this.Text = "Player Simulator";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewGameBtn;
		private System.Windows.Forms.Button SaveGameBtn;
		private System.Windows.Forms.Button LoadGameBtn;
	}
}

