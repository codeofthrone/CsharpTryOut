using Gtk;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private int pCurrentImage;
        private string[] imageFiles;
        protected excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        protected excel.Workbook aBook1, newBook;
        protected excel.Worksheet aSheet1;
        protected excel.Range aRange;
        private int offset = 0;
        private int sqlimagecount = 1;
        string dbHost = "10.116.136.13";//資料庫位址
        string dbUser = "readDL";//資料庫使用者帳號
        string dbPass = "readDL";//資料庫使用者密碼
        string dbName = "DeepLearning";//資料庫名稱
        string tbName = "Original";//資料表名稱

        public Form1()
        {
            InitializeComponent();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
            SqlDataLoadFunction();
        }

        private void SqlDataLoadFunction()
        {
            sqlImageLabel1.Visible = false;
            sqlPBlabel1.Text = "PB_Cat";
            sqlPBlabel3.Text = "PB_Dog";
            sqlPBlabel5.Text = "PB_Flower";
            sqlPBlabel7.Text = "PB_Indoor";
            sqlPBlabel9.Text = "PB_Meal";
            sqlPBlabel11.Text = "PB_Person";
            if (sqlimagecount == 1)
            {
                SqlPrevImg.Enabled = false;
            }


            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            SqlDBinfo.Text = connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;

            string sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            sqlPBlabel2.Text = reader.GetString(5);
            sqlPBlabel4.Text = reader.GetString(6);
            sqlPBlabel6.Text = reader.GetString(7);
            sqlPBlabel8.Text = reader.GetString(8);
            sqlPBlabel10.Text = reader.GetString(9);
            sqlPBlabel12.Text = reader.GetString(10);

            //Console.WriteLine(reader.GetString(1));
            //Console.WriteLine(reader.GetString(2));
            string ImageURI = "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
            System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            Bitmap bitmap2 = new Bitmap(responseStream);

            sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            sqlpictureBox1.Image = bitmap2;
            reader.Close();

            sqlQueryString = "select count(SerialNumber) from " + tbName;
            cmd = new MySqlCommand(sqlQueryString, conn);
            reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            int sqltbsize = reader.GetInt16(0);
            reader.Close();
            sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);

            conn.Close();
        }


		private void SelectSource_Click(object sender, EventArgs e)
		{
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            string programFiles = Path.GetDirectoryName("C:\\Users\\Owen_Ko\\Documents\\p+\\");
            ///System.Environment.SpecialFolder.MyPictures);
            dlg.SelectedPath = programFiles;
            String folder;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                folder = Path.GetFullPath(dlg.SelectedPath);
                imageFiles = Directory.GetFiles(folder, "*.jpg", SearchOption.AllDirectories);
                pCurrentImage = 0;
                pictureBox1.Enabled = true;
                ShowCurrentImage();
            }
        }       
		private void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}
        public void SaveCoordinates(int offset, string injectString)
		{
			String currentFileName = imageFiles[pCurrentImage];
			string ExcelFile = Directory.GetCurrentDirectory() + "\\YourWorkbook.xlsx";


			xlApp.Visible = false;
			xlApp.DisplayAlerts = false;


			if (System.IO.File.Exists(ExcelFile) == false)
			{
				xlApp.Workbooks.Add(Type.Missing);
				aBook1 = xlApp.Workbooks[1];
				aBook1.Activate();
			}
			else
			{
				aBook1 = xlApp.Workbooks.Open(ExcelFile);
			}
			aSheet1 = (excel.Worksheet)aBook1.Sheets[1];


			aRange = (excel.Range)aSheet1.Cells[1, 1];
			aRange.Value2 = "FileName";
			aRange = (excel.Range)aSheet1.Cells[1, 1+offset];
			aRange.Value2 = "Point"+offset;

			excel.Range last = aSheet1.Cells.SpecialCells(excel.XlCellType.xlCellTypeLastCell, Type.Missing);
			excel.Range range = aSheet1.get_Range("A1", last);

			int lastUsedRow = last.Row;
			int lastUsedColumn = last.Column;

			if (offset == 1 )
			{
				lastUsedRow++;
			}
			System.Console.WriteLine("last row {0} ,offset {1}", aSheet1.UsedRange.Rows.Count, offset);

			aRange = (excel.Range)aSheet1.Cells[lastUsedRow, 1];
			aRange.Value2 = Path.GetFileName(currentFileName);

			aRange = (excel.Range)aSheet1.Cells[lastUsedRow, ++offset];
			aRange.Value2 = injectString;

			aSheet1.Application.DisplayAlerts = false;
			aSheet1.Application.AlertBeforeOverwriting = false;

			if (System.IO.File.Exists(ExcelFile) == false)
			{
				aBook1.SaveAs(ExcelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			}
			else
			{
				aBook1.Save();
			}

			releaseObject(aSheet1);
			releaseObject(aBook1);
			releaseObject(xlApp);

			xlApp.Quit();

	}
		public void ShowCurrentImage()
		{
			///pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			pictureBox1.Image  = System.Drawing.Image.FromFile(imageFiles[pCurrentImage]);
			FileNameLabel.Text = imageFiles[pCurrentImage];
		}
        private void PrevImg_Click(object sender, EventArgs e)
		{
            --pCurrentImage;
            offset = 0;
            if (imageFiles.Length > 0)
            {
                pCurrentImage = pCurrentImage < 0 ? imageFiles.Length - 1 : pCurrentImage;
                ShowCurrentImage();
            }
        }
        private void NextImg_Click(object sender, EventArgs e)
		{
            ++pCurrentImage;
            offset = 0;

            if (imageFiles.Length > 0)
            {
                pCurrentImage = pCurrentImage >= imageFiles.Length ? 0 : pCurrentImage;
                ShowCurrentImage();
            }
        }
		private void pictureBox1_Click(object sender, EventArgs e)
		{

			Point controlRelative = pictureBox1.PointToClient(MousePosition);
			// Size of the image inside the picture box
			Size imageSize = pictureBox1.Image.Size;
			// Size of the picture box
			Size boxSize = pictureBox1.Size;

			Point imagePosition = new Point((imageSize.Width / boxSize.Width) * controlRelative.X,
											(imageSize.Height / boxSize.Height) * controlRelative.Y);

			offset++;
			String pointrecord = imagePosition.X + "," + imagePosition.Y;
			PointLabel.Text = pointrecord;
			System.Console.WriteLine(DateTime.Now.ToLongTimeString() + "  " + pointrecord);
			SaveCoordinates(offset, pointrecord);

		}
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                switch (e.KeyCode)
                {
                    case Keys.F4:
                        NextImg.PerformClick();
                        break;
                    case Keys.F3:
                        PrevImg.PerformClick();
                        break;
                    case Keys.F2:
                        SelectSource.PerformClick();
                        break;
                }
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                switch (e.KeyCode)
                {
                    case Keys.OemPeriod:
                        SqlNextImg.PerformClick();
                        break;
                    case Keys.Oemcomma:
                        if (sqlimagecount > 1)
                        {
                            SqlPrevImg.PerformClick();
                        }
                        break;

                    case Keys.Q:
                        sqlExitbutton1.PerformClick();
                        break;
                    case Keys.NumPad1:
                        Console.WriteLine("number 1");
                        break;

                }
            }
        }
        
        private void SqlPrevImg_Click(object sender, EventArgs e)
        {
            sqlimagecount--;
            sqlImageLabel1.Visible = false;

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            SqlDBinfo.Text = connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            string sqlQueryString = "select count(SerialNumber) from " + tbName;
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            int sqltbsize = reader.GetInt16(0);
            Console.WriteLine("{0}  {1}", sqlimagecount, sqltbsize);
            reader.Close();

            if (sqlimagecount >= 0)
            {
                sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
                cmd = new MySqlCommand(sqlQueryString, conn);
                reader = cmd.ExecuteReader(); //execure the reader
                reader.Read();
                sqlPBlabel2.Text = reader.GetString(5);
                sqlPBlabel4.Text = reader.GetString(6);
                sqlPBlabel6.Text = reader.GetString(7);
                sqlPBlabel8.Text = reader.GetString(8);
                sqlPBlabel10.Text = reader.GetString(9);
                sqlPBlabel12.Text = reader.GetString(10);

                string ImageURI = "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
                System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmap2 = new Bitmap(responseStream);

                sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                sqlpictureBox1.Image = bitmap2;
                reader.Close();
                conn.Close();
            }
            else
            {
                sqlpictureBox1.Visible = false;
                sqlImageLabel1.Text = "Already at first image!!!";
                sqlImageLabel1.Show();
                SqlPrevImg.Enabled = false;
                sqlimagecount--;

            }
            sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);

        }

        private void SqlNextImg_Click(object sender, EventArgs e)
		{
            sqlimagecount++;
            SqlPrevImg.Enabled = true;

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            SqlDBinfo.Text = connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            string sqlQueryString = "select count(SerialNumber) from " + tbName;
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();

            int sqltbsize = reader.GetInt16(0);
            Console.WriteLine("{0}  {1}", sqlimagecount, sqltbsize);
            reader.Close();

            if (sqlimagecount <= sqltbsize)
            {
                sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
                cmd = new MySqlCommand(sqlQueryString, conn);
                reader = cmd.ExecuteReader(); //execure the reader
                reader.Read();
                sqlPBlabel2.Text = reader.GetString(5);
                sqlPBlabel4.Text = reader.GetString(6);
                sqlPBlabel6.Text = reader.GetString(7);
                sqlPBlabel8.Text = reader.GetString(8);
                sqlPBlabel10.Text = reader.GetString(9);
                sqlPBlabel12.Text = reader.GetString(10);
                string ImageURI = "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
                System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmap2 = new Bitmap(responseStream);

                sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                sqlpictureBox1.Image = bitmap2;
                reader.Close();
                conn.Close();

            }
            else
            {
                sqlpictureBox1.Visible = false;
                sqlImageLabel1.Text = "No more image!!!";
                sqlImageLabel1.Show();
                SqlNextImg.Enabled = false;
                sqlimagecount--;

            }
            sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlImageLabel1.Visible = false;
            //sqlPBlabel1.Text = "PB_Cat";
            //sqlPBlabel3.Text = "PB_Dog";
            //sqlPBlabel5.Text = "PB_Flower";
            //sqlPBlabel7.Text = "PB_Indoor";
            //sqlPBlabel9.Text = "PB_Meal";
            //sqlPBlabel11.Text = "PB_Person";
            //if (sqlimagecount == 1)
            //{
            //    SqlPrevImg.Enabled = false;
            //}

            //if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            //{
            //    string dbHost = "10.116.136.13";//資料庫位址
            //    string dbUser = "readDL";//資料庫使用者帳號
            //    string dbPass = "readDL";//資料庫使用者密碼
            //    string dbName = "DeepLearning";//資料庫名稱
            //    string tbName = "Original";//資料表名稱

            //    string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            //    SqlDBinfo.Text = connStr;
            //    MySqlConnection conn = new MySqlConnection(connStr);
            //    MySqlCommand command = conn.CreateCommand();
            //    conn.Open();

            //    sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;

            //    string sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
            //    MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            //    MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            //    reader.Read();
            //    sqlPBlabel2.Text = reader.GetString(5);
            //    sqlPBlabel4.Text = reader.GetString(6);
            //    sqlPBlabel6.Text = reader.GetString(7);
            //    sqlPBlabel8.Text = reader.GetString(8);
            //    sqlPBlabel10.Text = reader.GetString(9);
            //    sqlPBlabel12.Text = reader.GetString(10);

            //    //Console.WriteLine(reader.GetString(1));
            //    //Console.WriteLine(reader.GetString(2));
            //    string ImageURI= "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
            //    System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
            //    System.Net.WebResponse response = request.GetResponse();
            //    System.IO.Stream responseStream = response.GetResponseStream();
            //    Bitmap bitmap2 = new Bitmap(responseStream);

            //    sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //    sqlpictureBox1.Image = bitmap2;
            //    reader.Close();

            //    sqlQueryString = "select count(SerialNumber) from " + tbName ;
            //    cmd = new MySqlCommand(sqlQueryString, conn);
            //    reader = cmd.ExecuteReader(); //execure the reader
            //    reader.Read();
            //    int sqltbsize = reader.GetInt16(0);
            //    Console.WriteLine(sqltbsize);
            //    reader.Close();
            //    sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            //    sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);

            //    conn.Close();

            //}

        }

        private void sqlpictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point sqlcontrolRelative = sqlpictureBox1.PointToClient(MousePosition);
            //// Size of the image inside the picture box
            //Size sqlimageSize = sqlpictureBox1.Image.Size;
            //// Size of the picture box
            //Size sqlboxSize = sqlpictureBox1.Size;

            //Point sqlimagePosition = new Point((sqlimageSize.Width / sqlboxSize.Width) * sqlcontrolRelative.X,
            //                                (sqlimageSize.Height / sqlboxSize.Height) * sqlcontrolRelative.Y);
            //sqlPointlabel1.Text = string.Format("X: {0}, Y: {1}", (int)sqlimagePosition.X, (int)sqlimagePosition.Y);
        }

        private void sqlExitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			Point controlRelative = pictureBox1.PointToClient(MousePosition);
			// Size of the image inside the picture box
			Size imageSize = pictureBox1.Image.Size;
			// Size of the picture box
			Size boxSize = pictureBox1.Size;

			Point imagePosition = new Point((imageSize.Width / boxSize.Width) * controlRelative.X,
											(imageSize.Height / boxSize.Height) * controlRelative.Y);
			PointLabel.Text = string.Format("X: {0}, Y: {1}", (int)imagePosition.X, (int)imagePosition.Y);
		}
	}
}
