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
            this.components = new System.ComponentModel.Container();
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
            this.sqlLastlabel1 = new System.Windows.Forms.Label();
            this.sqlcheckBox5 = new System.Windows.Forms.CheckBox();
            this.sqlcheckBox6 = new System.Windows.Forms.CheckBox();
            this.sqlcheckBox3 = new System.Windows.Forms.CheckBox();
            this.sqlcheckBox4 = new System.Windows.Forms.CheckBox();
            this.sqlcheckBox2 = new System.Windows.Forms.CheckBox();
            this.sqlcheckBox1 = new System.Windows.Forms.CheckBox();
            this.sqlPointlabel1 = new System.Windows.Forms.Label();
            this.sqlCurrentlabel2 = new System.Windows.Forms.Label();
            this.sqlCurrentlabel1 = new System.Windows.Forms.Label();
            this.sqlExitbutton1 = new System.Windows.Forms.Button();
            this.sqlImageLabel1 = new System.Windows.Forms.Label();
            this.SqlDBinfo = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.SqlNextImg = new System.Windows.Forms.Button();
            this.SqlPrevImg = new System.Windows.Forms.Button();
            this.sqlpictureBox1 = new System.Windows.Forms.PictureBox();
            this.JIRA = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.JIRA_button1 = new System.Windows.Forms.Button();
            this.jiralabel3 = new System.Windows.Forms.Label();
            this.jiratextBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.JIRAtoolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.jiralabel2 = new System.Windows.Forms.Label();
            this.jiralabel1 = new System.Windows.Forms.Label();
            this.jiratextBox2 = new System.Windows.Forms.TextBox();
            this.jiratextBox1 = new System.Windows.Forms.TextBox();
            this.jsonConvertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jArrayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jValueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jsonConverterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JIRAtoolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlpictureBox1)).BeginInit();
            this.JIRA.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jsonConvertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jArrayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jValueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonConverterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.JIRA);
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
            this.tabPage2.Controls.Add(this.sqlLastlabel1);
            this.tabPage2.Controls.Add(this.sqlcheckBox5);
            this.tabPage2.Controls.Add(this.sqlcheckBox6);
            this.tabPage2.Controls.Add(this.sqlcheckBox3);
            this.tabPage2.Controls.Add(this.sqlcheckBox4);
            this.tabPage2.Controls.Add(this.sqlcheckBox2);
            this.tabPage2.Controls.Add(this.sqlcheckBox1);
            this.tabPage2.Controls.Add(this.sqlPointlabel1);
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
            this.tabPage2.Text = "Mysql";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlLastlabel1
            // 
            this.sqlLastlabel1.AutoSize = true;
            this.sqlLastlabel1.Location = new System.Drawing.Point(533, 44);
            this.sqlLastlabel1.Name = "sqlLastlabel1";
            this.sqlLastlabel1.Size = new System.Drawing.Size(0, 12);
            this.sqlLastlabel1.TabIndex = 28;
            // 
            // sqlcheckBox5
            // 
            this.sqlcheckBox5.AutoSize = true;
            this.sqlcheckBox5.Location = new System.Drawing.Point(533, 269);
            this.sqlcheckBox5.Name = "sqlcheckBox5";
            this.sqlcheckBox5.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox5.TabIndex = 27;
            this.sqlcheckBox5.Text = "checkBox5";
            this.sqlcheckBox5.UseVisualStyleBackColor = true;
            // 
            // sqlcheckBox6
            // 
            this.sqlcheckBox6.AutoSize = true;
            this.sqlcheckBox6.Location = new System.Drawing.Point(533, 289);
            this.sqlcheckBox6.Name = "sqlcheckBox6";
            this.sqlcheckBox6.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox6.TabIndex = 26;
            this.sqlcheckBox6.Text = "checkBox6";
            this.sqlcheckBox6.UseVisualStyleBackColor = true;
            // 
            // sqlcheckBox3
            // 
            this.sqlcheckBox3.AutoSize = true;
            this.sqlcheckBox3.Location = new System.Drawing.Point(533, 229);
            this.sqlcheckBox3.Name = "sqlcheckBox3";
            this.sqlcheckBox3.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox3.TabIndex = 25;
            this.sqlcheckBox3.Text = "checkBox3";
            this.sqlcheckBox3.UseVisualStyleBackColor = true;
            // 
            // sqlcheckBox4
            // 
            this.sqlcheckBox4.AutoSize = true;
            this.sqlcheckBox4.Location = new System.Drawing.Point(533, 248);
            this.sqlcheckBox4.Name = "sqlcheckBox4";
            this.sqlcheckBox4.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox4.TabIndex = 24;
            this.sqlcheckBox4.Text = "checkBox4";
            this.sqlcheckBox4.UseVisualStyleBackColor = true;
            // 
            // sqlcheckBox2
            // 
            this.sqlcheckBox2.AutoSize = true;
            this.sqlcheckBox2.Location = new System.Drawing.Point(533, 206);
            this.sqlcheckBox2.Name = "sqlcheckBox2";
            this.sqlcheckBox2.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox2.TabIndex = 23;
            this.sqlcheckBox2.Text = "checkBox2";
            this.sqlcheckBox2.UseVisualStyleBackColor = true;
            // 
            // sqlcheckBox1
            // 
            this.sqlcheckBox1.AutoSize = true;
            this.sqlcheckBox1.Location = new System.Drawing.Point(533, 183);
            this.sqlcheckBox1.Name = "sqlcheckBox1";
            this.sqlcheckBox1.Size = new System.Drawing.Size(77, 16);
            this.sqlcheckBox1.TabIndex = 22;
            this.sqlcheckBox1.Text = "checkBox1";
            this.sqlcheckBox1.UseVisualStyleBackColor = true;
            this.sqlcheckBox1.CheckedChanged += new System.EventHandler(this.sqlcheckBox1_CheckedChanged);
            // 
            // sqlPointlabel1
            // 
            this.sqlPointlabel1.AutoSize = true;
            this.sqlPointlabel1.Location = new System.Drawing.Point(7, 400);
            this.sqlPointlabel1.Name = "sqlPointlabel1";
            this.sqlPointlabel1.Size = new System.Drawing.Size(70, 12);
            this.sqlPointlabel1.TabIndex = 21;
            this.sqlPointlabel1.Text = "sqlPointlabel1";
            // 
            // sqlCurrentlabel2
            // 
            this.sqlCurrentlabel2.AutoSize = true;
            this.sqlCurrentlabel2.Location = new System.Drawing.Point(533, 154);
            this.sqlCurrentlabel2.Name = "sqlCurrentlabel2";
            this.sqlCurrentlabel2.Size = new System.Drawing.Size(41, 12);
            this.sqlCurrentlabel2.TabIndex = 8;
            this.sqlCurrentlabel2.Text = "Remain";
            // 
            // sqlCurrentlabel1
            // 
            this.sqlCurrentlabel1.AutoSize = true;
            this.sqlCurrentlabel1.Location = new System.Drawing.Point(531, 128);
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
            this.sqlpictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqlpictureBox1.Location = new System.Drawing.Point(6, 6);
            this.sqlpictureBox1.Name = "sqlpictureBox1";
            this.sqlpictureBox1.Size = new System.Drawing.Size(521, 387);
            this.sqlpictureBox1.TabIndex = 0;
            this.sqlpictureBox1.TabStop = false;
            this.sqlpictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sqlpictureBox1_MouseClick);
            this.sqlpictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sqlpictureBox1_MouseMove);
            // 
            // JIRA
            // 
            this.JIRA.Controls.Add(this.listView1);
            this.JIRA.Controls.Add(this.JIRA_button1);
            this.JIRA.Controls.Add(this.jiralabel3);
            this.JIRA.Controls.Add(this.jiratextBox3);
            this.JIRA.Controls.Add(this.statusStrip3);
            this.JIRA.Controls.Add(this.jiralabel2);
            this.JIRA.Controls.Add(this.jiralabel1);
            this.JIRA.Controls.Add(this.jiratextBox2);
            this.JIRA.Controls.Add(this.jiratextBox1);
            this.JIRA.Location = new System.Drawing.Point(4, 22);
            this.JIRA.Name = "JIRA";
            this.JIRA.Size = new System.Drawing.Size(738, 421);
            this.JIRA.TabIndex = 2;
            this.JIRA.Text = "JIRA";
            this.JIRA.UseVisualStyleBackColor = true;
            this.JIRA.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 364);
            this.listView1.TabIndex = 9;
            this.listView1.TileSize = new System.Drawing.Size(10, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // JIRA_button1
            // 
            this.JIRA_button1.Location = new System.Drawing.Point(476, 4);
            this.JIRA_button1.Name = "JIRA_button1";
            this.JIRA_button1.Size = new System.Drawing.Size(75, 23);
            this.JIRA_button1.TabIndex = 8;
            this.JIRA_button1.Text = "Search";
            this.JIRA_button1.UseVisualStyleBackColor = true;
            this.JIRA_button1.Click += new System.EventHandler(this.JIRA_button1_Click);
            // 
            // jiralabel3
            // 
            this.jiralabel3.AutoSize = true;
            this.jiralabel3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jiralabel3.Location = new System.Drawing.Point(283, 4);
            this.jiralabel3.Name = "jiralabel3";
            this.jiralabel3.Size = new System.Drawing.Size(60, 16);
            this.jiralabel3.TabIndex = 7;
            this.jiralabel3.Text = "JIRA ID";
            // 
            // jiratextBox3
            // 
            this.jiratextBox3.HideSelection = false;
            this.jiratextBox3.Location = new System.Drawing.Point(349, 4);
            this.jiratextBox3.Name = "jiratextBox3";
            this.jiratextBox3.Size = new System.Drawing.Size(100, 22);
            this.jiratextBox3.TabIndex = 6;
            this.jiratextBox3.Text = "UT-75";
            this.jiratextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jiratextBox3_KeyDown);
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JIRAtoolStripStatusLabel1,
            this.JIRAtoolStripStatusLabel2});
            this.statusStrip3.Location = new System.Drawing.Point(0, 399);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(738, 22);
            this.statusStrip3.TabIndex = 5;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // JIRAtoolStripStatusLabel1
            // 
            this.JIRAtoolStripStatusLabel1.Name = "JIRAtoolStripStatusLabel1";
            this.JIRAtoolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // jiralabel2
            // 
            this.jiralabel2.AutoSize = true;
            this.jiralabel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jiralabel2.Location = new System.Drawing.Point(141, 4);
            this.jiralabel2.Name = "jiralabel2";
            this.jiralabel2.Size = new System.Drawing.Size(30, 16);
            this.jiralabel2.TabIndex = 4;
            this.jiralabel2.Text = "PW";
            // 
            // jiralabel1
            // 
            this.jiralabel1.AutoSize = true;
            this.jiralabel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jiralabel1.Location = new System.Drawing.Point(5, 4);
            this.jiralabel1.Name = "jiralabel1";
            this.jiralabel1.Size = new System.Drawing.Size(24, 16);
            this.jiralabel1.TabIndex = 3;
            this.jiralabel1.Text = "ID";
            // 
            // jiratextBox2
            // 
            this.jiratextBox2.Location = new System.Drawing.Point(177, 4);
            this.jiratextBox2.Name = "jiratextBox2";
            this.jiratextBox2.PasswordChar = '*';
            this.jiratextBox2.Size = new System.Drawing.Size(100, 22);
            this.jiratextBox2.TabIndex = 2;
            this.jiratextBox2.Text = "Th1nkSl@w";
            // 
            // jiratextBox1
            // 
            this.jiratextBox1.Location = new System.Drawing.Point(35, 4);
            this.jiratextBox1.Name = "jiratextBox1";
            this.jiratextBox1.Size = new System.Drawing.Size(100, 22);
            this.jiratextBox1.TabIndex = 1;
            this.jiratextBox1.Text = "owen_ko";
            // 
            // jsonConvertBindingSource
            // 
            this.jsonConvertBindingSource.DataSource = typeof(Newtonsoft.Json.JsonConvert);
            // 
            // jArrayBindingSource
            // 
            this.jArrayBindingSource.DataSource = typeof(Newtonsoft.Json.Linq.JArray);
            // 
            // jObjectBindingSource
            // 
            this.jObjectBindingSource.DataSource = typeof(Newtonsoft.Json.Linq.JObject);
            // 
            // jValueBindingSource
            // 
            this.jValueBindingSource.DataSource = typeof(Newtonsoft.Json.Linq.JValue);
            // 
            // jValueBindingSource1
            // 
            this.jValueBindingSource1.DataSource = typeof(Newtonsoft.Json.Linq.JValue);
            // 
            // jsonConverterBindingSource
            // 
            this.jsonConverterBindingSource.DataSource = typeof(Newtonsoft.Json.JsonConverter);
            // 
            // JIRAtoolStripStatusLabel2
            // 
            this.JIRAtoolStripStatusLabel2.Name = "JIRAtoolStripStatusLabel2";
            this.JIRAtoolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
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
            this.JIRA.ResumeLayout(false);
            this.JIRA.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jsonConvertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jArrayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jValueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonConverterBindingSource)).EndInit();
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
		private System.Windows.Forms.Label FileNameLabel;
		private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox sqlcheckBox5;
        private System.Windows.Forms.CheckBox sqlcheckBox6;
        private System.Windows.Forms.CheckBox sqlcheckBox3;
        private System.Windows.Forms.CheckBox sqlcheckBox4;
        private System.Windows.Forms.CheckBox sqlcheckBox2;
        private System.Windows.Forms.CheckBox sqlcheckBox1;
        private System.Windows.Forms.Label sqlPointlabel1;
        private System.Windows.Forms.Label sqlCurrentlabel2;
        private System.Windows.Forms.Label sqlCurrentlabel1;
        private System.Windows.Forms.Button sqlExitbutton1;
        private System.Windows.Forms.Label sqlImageLabel1;
        private System.Windows.Forms.Label SqlDBinfo;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Button SqlNextImg;
        private System.Windows.Forms.Button SqlPrevImg;
        private System.Windows.Forms.PictureBox sqlpictureBox1;
        private System.Windows.Forms.Label sqlLastlabel1;
        private System.Windows.Forms.TabPage JIRA;
        private System.Windows.Forms.TextBox jiratextBox2;
        private System.Windows.Forms.TextBox jiratextBox1;
        private System.Windows.Forms.Label jiralabel2;
        private System.Windows.Forms.Label jiralabel1;
        private System.Windows.Forms.Label jiralabel3;
        private System.Windows.Forms.TextBox jiratextBox3;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.Button JIRA_button1;
        private System.Windows.Forms.BindingSource jArrayBindingSource;
        private System.Windows.Forms.BindingSource jValueBindingSource;
        private System.Windows.Forms.BindingSource jObjectBindingSource;
        private System.Windows.Forms.BindingSource jValueBindingSource1;
        private System.Windows.Forms.BindingSource jsonConverterBindingSource;
        private System.Windows.Forms.BindingSource jsonConvertBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripStatusLabel JIRAtoolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel JIRAtoolStripStatusLabel2;
    }
}

