
namespace ImageStreamTester {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.DisplayBox = new System.Windows.Forms.PictureBox();
			this.Camera0Btn = new System.Windows.Forms.Button();
			this.Camera1Btn = new System.Windows.Forms.Button();
			this.LoadBtn = new System.Windows.Forms.Button();
			this.ScreenshotBtn = new System.Windows.Forms.Button();
			this.PlayBtn = new System.Windows.Forms.Button();
			this.PauseBtn = new System.Windows.Forms.Button();
			this.StopBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
			this.SuspendLayout();
			// 
			// DisplayBox
			// 
			this.DisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DisplayBox.Location = new System.Drawing.Point(12, 12);
			this.DisplayBox.Name = "DisplayBox";
			this.DisplayBox.Size = new System.Drawing.Size(776, 331);
			this.DisplayBox.TabIndex = 0;
			this.DisplayBox.TabStop = false;
			// 
			// Camera0Btn
			// 
			this.Camera0Btn.Location = new System.Drawing.Point(12, 349);
			this.Camera0Btn.Name = "Camera0Btn";
			this.Camera0Btn.Size = new System.Drawing.Size(78, 29);
			this.Camera0Btn.TabIndex = 1;
			this.Camera0Btn.Text = "Camera 0";
			this.Camera0Btn.UseVisualStyleBackColor = true;
			// 
			// Camera1Btn
			// 
			this.Camera1Btn.Location = new System.Drawing.Point(96, 349);
			this.Camera1Btn.Name = "Camera1Btn";
			this.Camera1Btn.Size = new System.Drawing.Size(78, 29);
			this.Camera1Btn.TabIndex = 2;
			this.Camera1Btn.Text = "Camera 1";
			this.Camera1Btn.UseVisualStyleBackColor = true;
			// 
			// LoadBtn
			// 
			this.LoadBtn.Location = new System.Drawing.Point(180, 349);
			this.LoadBtn.Name = "LoadBtn";
			this.LoadBtn.Size = new System.Drawing.Size(78, 29);
			this.LoadBtn.TabIndex = 3;
			this.LoadBtn.Text = "Load";
			this.LoadBtn.UseVisualStyleBackColor = true;
			// 
			// ScreenshotBtn
			// 
			this.ScreenshotBtn.Location = new System.Drawing.Point(264, 349);
			this.ScreenshotBtn.Name = "ScreenshotBtn";
			this.ScreenshotBtn.Size = new System.Drawing.Size(78, 29);
			this.ScreenshotBtn.TabIndex = 4;
			this.ScreenshotBtn.Text = "Screenshot";
			this.ScreenshotBtn.UseVisualStyleBackColor = true;
			// 
			// PlayBtn
			// 
			this.PlayBtn.Location = new System.Drawing.Point(417, 349);
			this.PlayBtn.Name = "PlayBtn";
			this.PlayBtn.Size = new System.Drawing.Size(78, 29);
			this.PlayBtn.TabIndex = 5;
			this.PlayBtn.Text = "Play";
			this.PlayBtn.UseVisualStyleBackColor = true;
			// 
			// PauseBtn
			// 
			this.PauseBtn.Location = new System.Drawing.Point(501, 349);
			this.PauseBtn.Name = "PauseBtn";
			this.PauseBtn.Size = new System.Drawing.Size(78, 29);
			this.PauseBtn.TabIndex = 6;
			this.PauseBtn.Text = "Pause";
			this.PauseBtn.UseVisualStyleBackColor = true;
			// 
			// StopBtn
			// 
			this.StopBtn.Location = new System.Drawing.Point(585, 349);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(78, 29);
			this.StopBtn.TabIndex = 7;
			this.StopBtn.Text = "Stop";
			this.StopBtn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StopBtn);
			this.Controls.Add(this.PauseBtn);
			this.Controls.Add(this.PlayBtn);
			this.Controls.Add(this.ScreenshotBtn);
			this.Controls.Add(this.LoadBtn);
			this.Controls.Add(this.Camera1Btn);
			this.Controls.Add(this.Camera0Btn);
			this.Controls.Add(this.DisplayBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox DisplayBox;
		private System.Windows.Forms.Button Camera0Btn;
		private System.Windows.Forms.Button Camera1Btn;
		private System.Windows.Forms.Button LoadBtn;
		private System.Windows.Forms.Button ScreenshotBtn;
		private System.Windows.Forms.Button PlayBtn;
		private System.Windows.Forms.Button PauseBtn;
		private System.Windows.Forms.Button StopBtn;
	}
}

