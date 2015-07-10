using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;


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
        string tbName = "Original_Small";//資料表名稱
        string tbWrite = "R_Owen";//資料表名稱

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
            sqlcheckBox1.Text = "PB_Cat";
            sqlcheckBox2.Text = "PB_Dog";
            sqlcheckBox3.Text = "PB_Flower";
            sqlcheckBox4.Text = "PB_Indoor";
            sqlcheckBox5.Text = "PB_Meal";
            sqlcheckBox6.Text = "PB_Person";
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

            string sqlQueryString = "select * from " + tbWrite + "  WHERE SourceSN='" + sqlimagecount + "'";
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader R_reader = cmd.ExecuteReader(); //execure the reader
            R_reader.Read();
            if (R_reader.HasRows)
            {
                sqlcheckBox1.Checked = R_reader.GetBoolean(6);
                sqlcheckBox2.Checked = R_reader.GetBoolean(7);
                sqlcheckBox3.Checked = R_reader.GetBoolean(8);
                sqlcheckBox4.Checked = R_reader.GetBoolean(9);
                sqlcheckBox5.Checked = R_reader.GetBoolean(10);
                sqlcheckBox6.Checked = R_reader.GetBoolean(11);
            }

            R_reader.Close();

             sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
             cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            sqlcheckBox1.Text = "PB_Cat      : " + reader.GetString(5);
            sqlcheckBox2.Text = "PB_Dog     :  " + reader.GetString(6);
            sqlcheckBox3.Text = "PB_Flower : " + reader.GetString(7);
            sqlcheckBox4.Text = "PB_Indoor : " + reader.GetString(8);
            sqlcheckBox5.Text = "PB_Meal    : " + reader.GetString(9);
            sqlcheckBox6.Text = "PB_Person : " + reader.GetString(10);

            //Console.WriteLine(reader.GetString(1));
            //Console.WriteLine(reader.GetString(2));
            try {
                string ImageURI = "http://10.116.136.13/~CL/IMAGES/IMG/" + reader.GetString(1) + "/" + reader.GetString(2);
                System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmap2 = new Bitmap(responseStream);

                sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                sqlpictureBox1.Image = bitmap2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        protected Point TranslateZoomMousePosition(Point coordinates)
        {
            // test to make sure our image is not null
            if (sqlpictureBox1.Image == null) return coordinates;
            // Make sure our control width and height are not 0 and our 
            // image width and height are not 0
            if (sqlpictureBox1.Width == 0 || sqlpictureBox1.Height == 0 || sqlpictureBox1.Image.Width == 0 || sqlpictureBox1.Image.Height == 0) return coordinates;
            // This is the one that gets a little tricky. Essentially, need to check 
            // the aspect ratio of the image to the aspect ratio of the control
            // to determine how it is being rendered
            float imageAspect = (float)sqlpictureBox1.Image.Width / sqlpictureBox1.Image.Height;
            float controlAspect = (float)sqlpictureBox1.Width / sqlpictureBox1.Height;
            float newX = coordinates.X;
            float newY = coordinates.Y;
            if (imageAspect > controlAspect)
            {
                // This means that we are limited by width, 
                // meaning the image fills up the entire control from left to right
                float ratioWidth = (float)sqlpictureBox1.Image.Width / sqlpictureBox1.Width;
                newX *= ratioWidth;
                float scale = (float)sqlpictureBox1.Width / sqlpictureBox1.Image.Width;
                float displayHeight = scale * sqlpictureBox1.Image.Height;
                float diffHeight = sqlpictureBox1.Height - displayHeight;
                diffHeight /= 2;
                newY -= diffHeight;
                newY /= scale;
                // > diff   <diff + image size    
                if (coordinates.Y  > (int)Math.Abs(diffHeight) && coordinates.Y < (int)Math.Abs(diffHeight)+ displayHeight)
                {
                    return new Point((int)newX, (int)newY);
                }

            }
            else
            {
                // This means that we are limited by height, 
                // meaning the image fills up the entire control from top to bottom
                float ratioHeight = (float)sqlpictureBox1.Image.Height / sqlpictureBox1.Height;
                newY *= ratioHeight;
                float scale = (float)sqlpictureBox1.Height / sqlpictureBox1.Image.Height;
                float displayWidth = scale * sqlpictureBox1.Image.Width;
                float diffWidth = sqlpictureBox1.Width - displayWidth;
                diffWidth /= 2;
                newX -= diffWidth;
                newX /= scale;
                if (coordinates.X > (int)Math.Abs(diffWidth) && coordinates.X < (int)Math.Abs(diffWidth) + displayWidth)
                {
                    return new Point((int)newX, (int)newY);
                }

            }
            return new Point();
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
                    case Keys.D1:
                        if (sqlcheckBox1.Checked)
                        {
                            sqlcheckBox1.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox1.Checked = true;
                        }
                        break;
                    case Keys.D2:
                        if (sqlcheckBox2.Checked)
                        {
                            sqlcheckBox2.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox2.Checked = true;
                        }
                        break;
                    case Keys.D3:
                        if (sqlcheckBox3.Checked)
                        {
                            sqlcheckBox3.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox3.Checked = true;
                        }
                        break;
                    case Keys.D4:
                        if (sqlcheckBox4.Checked)
                        {
                            sqlcheckBox4.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox4.Checked = true;
                        }
                        break;                  
                    case Keys.D5:
                        if (sqlcheckBox5.Checked)
                        {
                            sqlcheckBox5.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox5.Checked = true;
                        }
                        break;
                    case Keys.D6:
                        if (sqlcheckBox6.Checked)
                        {
                            sqlcheckBox6.Checked = false;
                        }
                        else
                        {
                            sqlcheckBox6.Checked = true;
                        }
                        break;

                }
            }
        }

        private void SqlPrevImg_Click(object sender, EventArgs e)
        {
            sqlimagecount--;
            sqlImageLabel1.Visible = false;
            SqlNextImg.Enabled = true;
            sqlcheckBox1.Checked = false;
            sqlcheckBox2.Checked = false;
            sqlcheckBox3.Checked = false;
            sqlcheckBox4.Checked = false;
            sqlcheckBox5.Checked = false;
            sqlcheckBox6.Checked = false;
            sqlLastlabel1.Text = "";


            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName+ ";Allow User Variables=True";
            SqlDBinfo.Text = connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            string sqlQueryString = "select count(SerialNumber) from " + tbName;
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            int sqltbsize = reader.GetInt16(0);
            if (sqlimagecount <= 0)
            {
                sqlimagecount =sqltbsize;
            }
            //Console.WriteLine("{0}  {1}", sqlimagecount, sqltbsize);
            reader.Close();
            SqlDataLoadFunction();
            //if (sqlimagecount >= 1 || sqlimagecount == sqltbsize )
            //{
            //    sqlQueryString = "select * from " + tbWrite + "  WHERE SourceSN='" + sqlimagecount + "'";
            //    cmd = new MySqlCommand(sqlQueryString, conn);
            //    MySqlDataReader R_reader = cmd.ExecuteReader(); //execure the reader
            //    R_reader.Read();
            //    if (R_reader.HasRows)
            //    {
            //        sqlcheckBox1.Checked = R_reader.GetBoolean(6);
            //        sqlcheckBox2.Checked = R_reader.GetBoolean(7);
            //        sqlcheckBox3.Checked = R_reader.GetBoolean(8);
            //        sqlcheckBox4.Checked = R_reader.GetBoolean(9);
            //        sqlcheckBox5.Checked = R_reader.GetBoolean(10);
            //        sqlcheckBox6.Checked = R_reader.GetBoolean(11);
            //    }

            //    R_reader.Close();

            //    sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
            //    cmd = new MySqlCommand(sqlQueryString, conn);
            //    reader = cmd.ExecuteReader(); //execure the reader
            //    reader.Read();

            //    sqlcheckBox1.Text = "PB_Cat      : " + reader.GetString(5);
            //    sqlcheckBox2.Text = "PB_Dog     :  " + reader.GetString(6);
            //    sqlcheckBox3.Text = "PB_Flower : " + reader.GetString(7);
            //    sqlcheckBox4.Text = "PB_Indoor : " + reader.GetString(8);
            //    sqlcheckBox5.Text = "PB_Meal    : " + reader.GetString(9);
            //    sqlcheckBox6.Text = "PB_Person : " + reader.GetString(10);
            //    string ImageURI = "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
            //    System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
            //    System.Net.WebResponse response = request.GetResponse();
            //    System.IO.Stream responseStream = response.GetResponseStream();
            //    Bitmap bitmap2 = new Bitmap(responseStream);

            //    sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //    sqlpictureBox1.Image = bitmap2;
            //    reader.Close();
            //    conn.Close();
            //}
            //else
            //{
            //    sqlpictureBox1.Visible = false;
            //    sqlImageLabel1.Text = "Already at first image!!!";
            //    sqlImageLabel1.Show();
            //    SqlPrevImg.Enabled = false;
            //    sqlimagecount--;

            //}
            //sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            //sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);

        }

        private void SqlNextImg_Click(object sender, EventArgs e)
		{
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            SqlDBinfo.Text = connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            //MySqlConnection MyConn4 = new MySqlConnection(connStr);
            //string sqlQueryString1 = "select * from " + tbWrite + "  WHERE SerialNumber='" + sqlimagecount + "'";
            //MySqlCommand cmd = new MySqlCommand(sqlQueryString1, MyConn4);
            //MyConn4.Open();
            //MySqlDataReader readerquery = cmd.ExecuteReader(); //execure the reader

            //readerquery.Read();
            //if (!readerquery.HasRows)
            //{
                sqlLastlabel1.Text = "Cat :" + sqlcheckBox1.Checked + "             " +
    "Dog : " + sqlcheckBox2.Checked + "\n" +
    "Flower : " + sqlcheckBox3.Checked + "      " +
    "Indoor : " + sqlcheckBox4.Checked + "\n" +
    "Meal : " + sqlcheckBox5.Checked + "          " +
    "Person : " + sqlcheckBox6.Checked + "\n";
            //}
            //readerquery.Close();
            //MyConn4.Close();

            try
            {
                var selectString = "SELECT * FROM " + tbWrite + " WHERE `SourceSN` =  '"+ sqlimagecount+"' ";
                var myCommand = new MySqlCommand(selectString, conn);
                MySqlDataReader exist_reader = myCommand.ExecuteReader();

                if (!exist_reader.HasRows)
                {
                    exist_reader.Close();
                    try
                    {
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        MySqlConnection MyConn3 = new MySqlConnection(connStr);
                        string sqlQueryStringinsert = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
                        MySqlCommand cmdinsert = new MySqlCommand(sqlQueryStringinsert, MyConn3);
                        MyConn3.Open();
                        MySqlDataReader readerinsert = cmdinsert.ExecuteReader(); //execure the reader

                        readerinsert.Read();

                        //This is my insert query in which i am taking input from the user through windows forms
                        string insert_sql = "INSERT INTO R_Owen(`SourceSN`, `Folder`, `FileName`, `Threshold`,  "+
                            "`Cat_Result`, `Dog_Result`, `Flower_Result`, `Indoor_Result`, `Meal_Result`, `Person_Result`) VALUES(" +
                            "@SN ,@Folder,@FileName,@Threshold,@Cat,@Dog,@Flower,@Indoor,@Meal,@Person   )";
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        MySqlConnection MyConn2 = new MySqlConnection(connStr);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand2 = new MySqlCommand(insert_sql, MyConn2);
                        MyCommand2.Parameters.AddWithValue("@SN", sqlimagecount);
                        MyCommand2.Parameters.AddWithValue("@Folder", readerinsert.GetString(1));
                        MyCommand2.Parameters.AddWithValue("@FileName", readerinsert.GetString(2));
                        MyCommand2.Parameters.AddWithValue("@Threshold", sqlimagecount);
                        readerinsert.Close();
                        MyConn3.Close();
                        MyCommand2.Parameters.AddWithValue("@Cat", sqlcheckBox1.Checked);
                        MyCommand2.Parameters.AddWithValue("@Dog", sqlcheckBox2.Checked);
                        MyCommand2.Parameters.AddWithValue("@Flower", sqlcheckBox3.Checked);
                        MyCommand2.Parameters.AddWithValue("@Indoor", sqlcheckBox4.Checked);
                        MyCommand2.Parameters.AddWithValue("@Meal", sqlcheckBox5.Checked);
                        MyCommand2.Parameters.AddWithValue("@Person", sqlcheckBox6.Checked);


                        MyConn2.Open();
                        MyCommand2.ExecuteNonQuery();   // Here our query will be executed and data saved into the database.
                        //MessageBox.Show("Save Data");
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {

                    try
                    {

                        //This is my update query in which i am taking input from the user through windows forms and update the record.

                        string sqlupdate = "UPDATE `DeepLearning`.`R_Owen` SET " +
                            " `Cat_Result` = @Cat, `Dog_Result` = @Dog, `Flower_Result` = @Flower, "+
                            " `Indoor_Result` = @Indoor, `Meal_Result` = @Meal, `Person_Result` = @Person "+
                            " WHERE `R_Owen`.`SourceSN` = @SN;";
                        MySqlConnection MyConn2 = new MySqlConnection(connStr);
                        MySqlCommand MyCommand2 = new MySqlCommand(sqlupdate, MyConn2);
                        MyCommand2.Parameters.AddWithValue("@SN", sqlimagecount);
                        MyCommand2.Parameters.AddWithValue("@Cat", sqlcheckBox1.Checked);
                        MyCommand2.Parameters.AddWithValue("@Dog", sqlcheckBox2.Checked);
                        MyCommand2.Parameters.AddWithValue("@Flower", sqlcheckBox3.Checked);
                        MyCommand2.Parameters.AddWithValue("@Indoor", sqlcheckBox4.Checked);
                        MyCommand2.Parameters.AddWithValue("@Meal", sqlcheckBox5.Checked);
                        MyCommand2.Parameters.AddWithValue("@Person", sqlcheckBox6.Checked);

                        MyConn2.Open();
                        MyCommand2.ExecuteNonQuery();   // Here our query will be executed and data saved into the database.
                        //MessageBox.Show("Data Updated");
                        MyConn2.Close();//Connection closed here
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            sqlcheckBox1.Checked = false;
            sqlcheckBox2.Checked = false;
            sqlcheckBox3.Checked = false;
            sqlcheckBox4.Checked = false;
            sqlcheckBox5.Checked = false;
            sqlcheckBox6.Checked = false;
            sqlpictureBox1.Visible = true;
            SqlPrevImg.Enabled = true;
            sqlimagecount++;


            conn.Open();            
            string sqlQueryString = "select count(SerialNumber) from " + tbName;
            //Console.WriteLine(sqlQueryString);
            MySqlCommand cmd = new MySqlCommand(sqlQueryString, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader
            reader.Read();
            int sqltbsize = reader.GetInt16(0);
            reader.Close();

            if (sqlimagecount > sqltbsize)
            {
                sqlimagecount=1;
            }
            // inser or update latest
            SqlDataLoadFunction();
            //if (sqlimagecount >= 1 || sqlimagecount <= sqltbsize)
            //{
            //    sqlQueryString = "select * from " + tbWrite + "  WHERE SourceSN='" + sqlimagecount + "'";
            //    cmd = new MySqlCommand(sqlQueryString, conn);
            //    MySqlDataReader R_reader = cmd.ExecuteReader(); //execure the reader
            //    R_reader.Read();
            //    if (R_reader.HasRows)
            //    {
            //        sqlcheckBox1.Checked = R_reader.GetBoolean(6);
            //        sqlcheckBox2.Checked = R_reader.GetBoolean(7);
            //        sqlcheckBox3.Checked = R_reader.GetBoolean(8);
            //        sqlcheckBox4.Checked = R_reader.GetBoolean(9);
            //        sqlcheckBox5.Checked = R_reader.GetBoolean(10);
            //        sqlcheckBox6.Checked = R_reader.GetBoolean(11);
            //    }

            //    R_reader.Close();

            //    sqlQueryString = "select * from " + tbName + "  WHERE SerialNumber='" + sqlimagecount + "'";
            //    cmd = new MySqlCommand(sqlQueryString, conn);
            //    reader = cmd.ExecuteReader(); //execure the reader
            //    reader.Read();

            //    sqlcheckBox1.Text = "PB_Cat      : " + reader.GetString(5);
            //    sqlcheckBox2.Text = "PB_Dog     :  " + reader.GetString(6);
            //    sqlcheckBox3.Text = "PB_Flower : " + reader.GetString(7);
            //    sqlcheckBox4.Text = "PB_Indoor : " + reader.GetString(8);
            //    sqlcheckBox5.Text = "PB_Meal    : " + reader.GetString(9);
            //    sqlcheckBox6.Text = "PB_Person : " + reader.GetString(10);
            //    string ImageURI = "http://10.116.136.13/~CL/IMAGES/" + reader.GetString(1) + "/" + reader.GetString(2);
            //    System.Net.WebRequest request = System.Net.WebRequest.Create(ImageURI);
            //    System.Net.WebResponse response = request.GetResponse();
            //    System.IO.Stream responseStream = response.GetResponseStream();
            //    Bitmap bitmap2 = new Bitmap(responseStream);

            //    sqlpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //    sqlpictureBox1.Image = bitmap2;
            //    reader.Close();
            //    conn.Close();

            //}
            //else
            //{
            //    sqlpictureBox1.Visible = false;
            //    sqlImageLabel1.Text = "No more image!!!";
            //    sqlImageLabel1.Show();
            //    SqlNextImg.Enabled = false;
            //    sqlimagecount=1;
            //}
            //sqlCurrentlabel1.Text = "Current image : " + sqlimagecount;
            //sqlCurrentlabel2.Text = "Remain image : " + (sqltbsize - sqlimagecount);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void sqlpictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point sqlcontrolRelative = sqlpictureBox1.PointToClient(MousePosition);
            if (TranslateZoomMousePosition(sqlcontrolRelative).X != 0 || TranslateZoomMousePosition(sqlcontrolRelative).Y != 0)
            {
                sqlPointlabel1.Text = string.Format("X: {0}, Y: {1}", TranslateZoomMousePosition(sqlcontrolRelative).X, TranslateZoomMousePosition(sqlcontrolRelative).Y);
            }
            else
            {
                sqlPointlabel1.Text = "";
            }
        }

        private void sqlExitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sqlpictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void sqlcheckBox1_CheckedChanged(object sender, EventArgs e)
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

