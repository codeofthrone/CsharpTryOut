namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PointLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.NextImg = new System.Windows.Forms.Button();
            this.PrevImg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SelectSource = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sqlPointlabel1 = new System.Windows.Forms.Label();
            this.sqlPBlabel9 = new System.Windows.Forms.Label();
            this.sqlPBlabel10 = new System.Windows.Forms.Label();
            this.sqlPBlabel11 = new System.Windows.Forms.Label();
            this.sqlPBlabel12 = new System.Windows.Forms.Label();
            this.sqlPBlabel5 = new System.Windows.Forms.Label();
            this.sqlPBlabel6 = new System.Windows.Forms.Label();
            this.sqlPBlabel7 = new System.Windows.Forms.Label();
            this.sqlPBlabel8 = new System.Windows.Forms.Label();
            this.sqlPBlabel3 = new System.Windows.Forms.Label();
            this.sqlPBlabel4 = new System.Windows.Forms.Label();
            this.sqlPBlabel2 = new System.Windows.Forms.Label();
            this.sqlPBlabel1 = new System.Windows.Forms.Label();
            this.sqlCurrentlabel2 = new System.Windows.Forms.Label();
            this.sqlCurrentlabel1 = new System.Windows.Forms.Label();
            this.sqlExitbutton1 = new System.Windows.Forms.Button();
            this.sqlImageLabel1 = new System.Windows.Forms.Label();
            this.SqlDBinfo = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.SqlNextImg = new System.Windows.Forms.Button();
            this.SqlPrevImg = new System.Windows.Forms.Button();
            this.sqlpictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 447);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PointLabel);
            this.tabPage1.Controls.Add(this.FileNameLabel);
            this.tabPage1.Controls.Add(this.NextImg);
            this.tabPage1.Controls.Add(this.PrevImg);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.SelectSource);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Location = new System.Drawing.Point(7, 404);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(55, 12);
            this.PointLabel.TabIndex = 7;
            this.PointLabel.Text = "PointLabel";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FileNameLabel.Location = new System.Drawing.Point(504, 404);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(75, 12);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "FileNameLabel";
            // 
            // NextImg
            // 
            this.NextImg.Location = new System.Drawing.Point(590, 350);
            this.NextImg.Name = "NextImg";
            this.NextImg.Size = new System.Drawing.Size(75, 23);
            this.NextImg.TabIndex = 5;
            this.NextImg.Text = "NextImg";
            this.NextImg.UseVisualStyleBackColor = true;
            // 
            // PrevImg
            // 
            this.PrevImg.Location = new System.Drawing.Point(590, 266);
            this.PrevImg.Name = "PrevImg";
            this.PrevImg.Size = new System.Drawing.Size(75, 23);
            this.PrevImg.TabIndex = 4;
            this.PrevImg.Text = "PrevImg";
            this.PrevImg.UseVisualStyleBackColor = true;
            this.PrevImg.Click += new System.EventHandler(this.PrevImg_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelectSource
            // 
            this.SelectSource.Location = new System.Drawing.Point(590, 14);
            this.SelectSource.Name = "SelectSource";
            this.SelectSource.Size = new System.Drawing.Size(75, 23);
            this.SelectSource.TabIndex = 2;
            this.SelectSource.Text = "SelectSource";
            this.SelectSource.UseVisualStyleBackColor = true;
            this.SelectSource.Click += new System.EventHandler(this.SelectSource_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 394);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sqlPointlabel1);
            this.tabPage2.Controls.Add(this.sqlPBlabel9);
            this.tabPage2.Controls.Add(this.sqlPBlabel10);
            this.tabPage2.Controls.Add(this.sqlPBlabel11);
            this.tabPage2.Controls.Add(this.sqlPBlabel12);
            this.tabPage2.Controls.Add(this.sqlPBlabel5);
            this.tabPage2.Controls.Add(this.sqlPBlabel6);
            this.tabPage2.Controls.Add(this.sqlPBlabel7);
            this.tabPage2.Controls.Add(this.sqlPBlabel8);
            this.tabPage2.Controls.Add(this.sqlPBlabel3);
            this.tabPage2.Controls.Add(this.sqlPBlabel4);
            this.tabPage2.Controls.Add(this.sqlPBlabel2);
            this.tabPage2.Controls.Add(this.sqlPBlabel1);
            this.tabPage2.Controls.Add(this.sqlCurrentlabel2);
            this.tabPage2.Controls.Add(this.sqlCurrentlabel1);
            this.tabPage2.Controls.Add(this.sqlExitbutton1);
            this.tabPage2.Controls.Add(this.sqlImageLabel1);
            this.tabPage2.Controls.Add(this.SqlDBinfo);
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.SqlNextImg);
            this.tabPage2.Controls.Add(this.SqlPrevImg);
            this.tabPage2.Controls.Add(this.sqlpictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlPointlabel1
            // 
            this.sqlPointlabel1.AutoSize = true;
            this.sqlPointlabel1.Location = new System.Drawing.Point(7, 400);
            this.sqlPointlabel1.Name = "sqlPointlabel1";
            this.sqlPointlabel1.Size = new System.Drawing.Size(33, 12);
            this.sqlPointlabel1.TabIndex = 21;
            this.sqlPointlabel1.Text = "label1";
            // 
            // sqlPBlabel9
            // 
            this.sqlPBlabel9.AutoSize = true;
            this.sqlPBlabel9.Location = new System.Drawing.Point(546, 216);
            this.sqlPBlabel9.Name = "sqlPBlabel9";
            this.sqlPBlabel9.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel9.TabIndex = 20;
            this.sqlPBlabel9.Text = "sqlPBlabel9";
            // 
            // sqlPBlabel10
            // 
            this.sqlPBlabel10.AutoSize = true;
            this.sqlPBlabel10.Location = new System.Drawing.Point(612, 216);
            this.sqlPBlabel10.Name = "sqlPBlabel10";
            this.sqlPBlabel10.Size = new System.Drawing.Size(66, 12);
            this.sqlPBlabel10.TabIndex = 19;
            this.sqlPBlabel10.Text = "sqlPBlabel10";
            // 
            // sqlPBlabel11
            // 
            this.sqlPBlabel11.AutoSize = true;
            this.sqlPBlabel11.Location = new System.Drawing.Point(545, 239);
            this.sqlPBlabel11.Name = "sqlPBlabel11";
            this.sqlPBlabel11.Size = new System.Drawing.Size(66, 12);
            this.sqlPBlabel11.TabIndex = 18;
            this.sqlPBlabel11.Text = "sqlPBlabel11";
            // 
            // sqlPBlabel12
            // 
            this.sqlPBlabel12.AutoSize = true;
            this.sqlPBlabel12.Location = new System.Drawing.Point(612, 239);
            this.sqlPBlabel12.Name = "sqlPBlabel12";
            this.sqlPBlabel12.Size = new System.Drawing.Size(66, 12);
            this.sqlPBlabel12.TabIndex = 17;
            this.sqlPBlabel12.Text = "sqlPBlabel12";
            // 
            // sqlPBlabel5
            // 
            this.sqlPBlabel5.AutoSize = true;
            this.sqlPBlabel5.Location = new System.Drawing.Point(546, 171);
            this.sqlPBlabel5.Name = "sqlPBlabel5";
            this.sqlPBlabel5.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel5.TabIndex = 16;
            this.sqlPBlabel5.Text = "sqlPBlabel5";
            // 
            // sqlPBlabel6
            // 
            this.sqlPBlabel6.AutoSize = true;
            this.sqlPBlabel6.Location = new System.Drawing.Point(612, 171);
            this.sqlPBlabel6.Name = "sqlPBlabel6";
            this.sqlPBlabel6.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel6.TabIndex = 15;
            this.sqlPBlabel6.Text = "sqlPBlabel6";
            // 
            // sqlPBlabel7
            // 
            this.sqlPBlabel7.AutoSize = true;
            this.sqlPBlabel7.Location = new System.Drawing.Point(546, 194);
            this.sqlPBlabel7.Name = "sqlPBlabel7";
            this.sqlPBlabel7.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel7.TabIndex = 14;
            this.sqlPBlabel7.Text = "sqlPBlabel7";
            // 
            // sqlPBlabel8
            // 
            this.sqlPBlabel8.AutoSize = true;
            this.sqlPBlabel8.Location = new System.Drawing.Point(612, 194);
            this.sqlPBlabel8.Name = "sqlPBlabel8";
            this.sqlPBlabel8.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel8.TabIndex = 13;
            this.sqlPBlabel8.Text = "sqlPBlabel8";
            // 
            // sqlPBlabel3
            // 
            this.sqlPBlabel3.AutoSize = true;
            this.sqlPBlabel3.Location = new System.Drawing.Point(546, 146);
            this.sqlPBlabel3.Name = "sqlPBlabel3";
            this.sqlPBlabel3.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel3.TabIndex = 12;
            this.sqlPBlabel3.Text = "sqlPBlabel3";
            // 
            // sqlPBlabel4
            // 
            this.sqlPBlabel4.AutoSize = true;
            this.sqlPBlabel4.Location = new System.Drawing.Point(612, 146);
            this.sqlPBlabel4.Name = "sqlPBlabel4";
            this.sqlPBlabel4.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel4.TabIndex = 11;
            this.sqlPBlabel4.Text = "sqlPBlabel4";
            // 
            // sqlPBlabel2
            // 
            this.sqlPBlabel2.AutoSize = true;
            this.sqlPBlabel2.Location = new System.Drawing.Point(612, 123);
            this.sqlPBlabel2.Name = "sqlPBlabel2";
            this.sqlPBlabel2.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel2.TabIndex = 10;
            this.sqlPBlabel2.Text = "sqlPBlabel2";
            // 
            // sqlPBlabel1
            // 
            this.sqlPBlabel1.AutoSize = true;
            this.sqlPBlabel1.Location = new System.Drawing.Point(545, 123);
            this.sqlPBlabel1.Name = "sqlPBlabel1";
            this.sqlPBlabel1.Size = new System.Drawing.Size(60, 12);
            this.sqlPBlabel1.TabIndex = 9;
            this.sqlPBlabel1.Text = "sqlPBlabel1";
            // 
            // sqlCurrentlabel2
            // 
            this.sqlCurrentlabel2.AutoSize = true;
            this.sqlCurrentlabel2.Location = new System.Drawing.Point(538, 65);
            this.sqlCurrentlabel2.Name = "sqlCurrentlabel2";
            this.sqlCurrentlabel2.Size = new System.Drawing.Size(41, 12);
            this.sqlCurrentlabel2.TabIndex = 8;
            this.sqlCurrentlabel2.Text = "Remain";
            // 
            // sqlCurrentlabel1
            // 
            this.sqlCurrentlabel1.AutoSize = true;
            this.sqlCurrentlabel1.Location = new System.Drawing.Point(538, 43);
            this.sqlCurrentlabel1.Name = "sqlCurrentlabel1";
            this.sqlCurrentlabel1.Size = new System.Drawing.Size(41, 12);
            this.sqlCurrentlabel1.TabIndex = 7;
            this.sqlCurrentlabel1.Text = "Current";
            // 
            // sqlExitbutton1
            // 
            this.sqlExitbutton1.Location = new System.Drawing.Point(658, 7);
            this.sqlExitbutton1.Name = "sqlExitbutton1";
            this.sqlExitbutton1.Size = new System.Drawing.Size(75, 23);
            this.sqlExitbutton1.TabIndex = 6;
            this.sqlExitbutton1.Text = "Exit";
            this.sqlExitbutton1.UseVisualStyleBackColor = true;
            this.sqlExitbutton1.Click += new System.EventHandler(this.sqlExitbutton1_Click);
            // 
            // sqlImageLabel1
            // 
            this.sqlImageLabel1.AutoSize = true;
            this.sqlImageLabel1.Location = new System.Drawing.Point(156, 160);
            this.sqlImageLabel1.Name = "sqlImageLabel1";
            this.sqlImageLabel1.Size = new System.Drawing.Size(63, 12);
            this.sqlImageLabel1.TabIndex = 5;
            this.sqlImageLabel1.Text = "Image Label";
            // 
            // SqlDBinfo
            // 
            this.SqlDBinfo.AutoSize = true;
            this.SqlDBinfo.Location = new System.Drawing.Point(366, 406);
            this.SqlDBinfo.Name = "SqlDBinfo";
            this.SqlDBinfo.Size = new System.Drawing.Size(0, 12);
            this.SqlDBinfo.TabIndex = 4;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(3, 396);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(732, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // SqlNextImg
            // 
            this.SqlNextImg.Location = new System.Drawing.Point(639, 315);
            this.SqlNextImg.Name = "SqlNextImg";
            this.SqlNextImg.Size = new System.Drawing.Size(93, 58);
            this.SqlNextImg.TabIndex = 2;
            this.SqlNextImg.Text = "Next";
            this.SqlNextImg.UseVisualStyleBackColor = true;
            this.SqlNextImg.Click += new System.EventHandler(this.SqlNextImg_Click);
            // 
            // SqlPrevImg
            // 
            this.SqlPrevImg.Location = new System.Drawing.Point(540, 315);
            this.SqlPrevImg.Name = "SqlPrevImg";
            this.SqlPrevImg.Size = new System.Drawing.Size(93, 58);
            this.SqlPrevImg.TabIndex = 1;
            this.SqlPrevImg.Text = "Prev";
            this.SqlPrevImg.UseVisualStyleBackColor = true;
            this.SqlPrevImg.Click += new System.EventHandler(this.SqlPrevImg_Click);
            // 
            // sqlpictureBox1
            // 
            this.sqlpictureBox1.Location = new System.Drawing.Point(6, 6);
            this.sqlpictureBox1.Name = "sqlpictureBox1";
            this.sqlpictureBox1.Size = new System.Drawing.Size(521, 387);
            this.sqlpictureBox1.TabIndex = 0;
            this.sqlpictureBox1.TabStop = false;
            this.sqlpictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sqlpictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button NextImg;
		private System.Windows.Forms.Button PrevImg;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button SelectSource;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label FileNameLabel;
		private System.Windows.Forms.Label PointLabel;
		private System.Windows.Forms.Button SqlPrevImg;
		private System.Windows.Forms.PictureBox sqlpictureBox1;
		private System.Windows.Forms.Button SqlNextImg;
		private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Label SqlDBinfo;
        private System.Windows.Forms.Label sqlImageLabel1;
        private System.Windows.Forms.Button sqlExitbutton1;
        private System.Windows.Forms.Label sqlCurrentlabel2;
        private System.Windows.Forms.Label sqlCurrentlabel1;
        private System.Windows.Forms.Label sqlPBlabel9;
        private System.Windows.Forms.Label sqlPBlabel10;
        private System.Windows.Forms.Label sqlPBlabel11;
        private System.Windows.Forms.Label sqlPBlabel12;
        private System.Windows.Forms.Label sqlPBlabel5;
        private System.Windows.Forms.Label sqlPBlabel6;
        private System.Windows.Forms.Label sqlPBlabel7;
        private System.Windows.Forms.Label sqlPBlabel8;
        private System.Windows.Forms.Label sqlPBlabel3;
        private System.Windows.Forms.Label sqlPBlabel4;
        private System.Windows.Forms.Label sqlPBlabel2;
        private System.Windows.Forms.Label sqlPBlabel1;
        private System.Windows.Forms.Label sqlPointlabel1;
    }
}

