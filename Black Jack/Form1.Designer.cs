namespace Black_Jack
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Oyuncu = new System.Windows.Forms.ListBox();
			this.Casino = new System.Windows.Forms.ListBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.btnBasla = new System.Windows.Forms.Button();
			this.btnTekrarOyna = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Oyuncu
			// 
			this.Oyuncu.BackColor = System.Drawing.Color.Navy;
			this.Oyuncu.ForeColor = System.Drawing.Color.White;
			this.Oyuncu.FormattingEnabled = true;
			this.Oyuncu.ItemHeight = 25;
			this.Oyuncu.Location = new System.Drawing.Point(1201, 342);
			this.Oyuncu.Name = "Oyuncu";
			this.Oyuncu.Size = new System.Drawing.Size(246, 279);
			this.Oyuncu.TabIndex = 25;
			this.Oyuncu.Tag = "";
			// 
			// Casino
			// 
			this.Casino.BackColor = System.Drawing.Color.Navy;
			this.Casino.ForeColor = System.Drawing.Color.White;
			this.Casino.FormattingEnabled = true;
			this.Casino.ItemHeight = 25;
			this.Casino.Location = new System.Drawing.Point(1201, 12);
			this.Casino.Name = "Casino";
			this.Casino.Size = new System.Drawing.Size(246, 279);
			this.Casino.TabIndex = 24;
			this.Casino.Tag = "";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl2.Location = new System.Drawing.Point(810, 560);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(24, 25);
			this.lbl2.TabIndex = 23;
			this.lbl2.Text = "0";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl1.Location = new System.Drawing.Point(810, 285);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(24, 25);
			this.lbl1.TabIndex = 22;
			this.lbl1.Text = "0";
			// 
			// btnBasla
			// 
			this.btnBasla.Location = new System.Drawing.Point(12, 74);
			this.btnBasla.Name = "btnBasla";
			this.btnBasla.Size = new System.Drawing.Size(159, 43);
			this.btnBasla.TabIndex = 21;
			this.btnBasla.Text = "Başla";
			this.btnBasla.UseVisualStyleBackColor = true;
			this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
			// 
			// btnTekrarOyna
			// 
			this.btnTekrarOyna.Location = new System.Drawing.Point(12, 12);
			this.btnTekrarOyna.Name = "btnTekrarOyna";
			this.btnTekrarOyna.Size = new System.Drawing.Size(159, 43);
			this.btnTekrarOyna.TabIndex = 20;
			this.btnTekrarOyna.Text = "Tekrar Oyna";
			this.btnTekrarOyna.UseVisualStyleBackColor = true;
			this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(645, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(349, 241);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(290, 878);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 25);
			this.label4.TabIndex = 18;
			this.label4.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(1729, 908);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 25);
			this.label3.TabIndex = 17;
			this.label3.Text = "1000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(1627, 908);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Balance:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(218, 878);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "Total:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(1924, 1061);
			this.Controls.Add(this.Oyuncu);
			this.Controls.Add(this.Casino);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btnBasla);
			this.Controls.Add(this.btnTekrarOyna);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox Oyuncu;
		private System.Windows.Forms.ListBox Casino;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnBasla;
		private System.Windows.Forms.Button btnTekrarOyna;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

