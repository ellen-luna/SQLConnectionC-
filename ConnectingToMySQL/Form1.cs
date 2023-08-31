using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace ConnectingToMySQL
{
    public partial class FrmConnectionMonitor : Form
    {
        public FrmConnectionMonitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=30.30.30.1;database=iot;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            LoadSQLIP();
           
        }



        public void LoadSQLIP()
        {
            // InitializeComponent();

            //dtGridDevice.DataSource = null;
            //List<User> users = new List<User>();
            //users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            //users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            //users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            //  dtGridDevice.DataSource = users;

            //10.10.10.3
            //string constr = "server=localhost;database=iot;uid=AdminUser;pwd=P@ssw0rd01;"; //ConfigurationManager.ConnectionStrings["AppNameC"].ConnectionString;
            //string constr = "server=30.30.30.2;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
            string constr = "server=30.30.30.1;database=iot;uid=root;pwd=;";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_ip, ip, '' as Status FROM tb_ip"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //fill data in gridview in asp .net
                            dtGridDevice.DataSource = dt;
                           //dtGridDevice.DataBind();
                        }
                    }
                }
            }
        }


        public void IPCheck()
        {

            int dtCount =dtGridDevice.Rows.Count;
            int dtrow = 0;
            //dtGridDevice.Rows[0].Cells[1].Value = ClsCommom.PingIP("81.2.199.57");


            //for (int i = 0; i <= dtCount -1; i++)
            //{ // print numbers from 1 to 5

            //    object rowIP = dtGridDevice.Rows[dtrow].Cells[0].Value;
            //    object strIP = (dtGridDevice.Rows[dtrow].Cells[0].Value == null ? " " : dtGridDevice.Rows[dtrow].Cells[0].Value);
            //    dtGridDevice.Rows[i].Cells[1].Value = ClsCommom.PingIP(strIP.ToString());


            //}

            foreach (DataGridViewRow row in dtGridDevice.Rows)
            {
                // string a = row.Cells[0].Value.ToString();
                //currQty += row.Cells["qty"].Value;
                //dtGridDevice.Rows[dtrow].Cells[1].Value = ClsCommom.PingIP("81.2.199.57");

                if (dtCount - dtrow != 1)
                {
                    object strIP_ID = row.Cells[0].Value;
                    object strIP = (row.Cells[1].Value == null ? " " : row.Cells[1].Value);
                    object strIP_Sta = (row.Cells[2].Value == null ? " " : row.Cells[2].Value);
                    row.Cells[2].Value = ClsCommom.PingIP(strIP_ID.ToString(),strIP.ToString(), strIP_Sta.ToString());
                    row.Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Black, BackColor = Color.White };

                    if (row.Cells[2].Value.ToString() == "Open")
                    {
                        row.Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Green, BackColor = Color.White };
                    }
                    else
                    {
                        row.Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.Yellow };
                    }

                }


                dtrow++;

            }
        }



       

        private void button3_Click(object sender, EventArgs e)
        {
            //dtGridDevice.DataSource = null;
            IPCheck();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Insert to database
            label1.Text = "";
            //30.30.30.2
            //string connString = "server=localhost;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";//ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            //string connString = "server=30.30.30.2;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
            string connString = "server=30.30.30.1;database=iot;uid=root;pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO tb_ip(ip,tb_ipcol) VALUES('" + txtIP.Text.ToString() + "','" + DateTime.Now.ToString() + "')";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Done");
            // update datagrid

            LoadSQLIP();
            IPCheck();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //label1.Text = DateTime.Now.ToString("HH:mm:ss");
            //label1.Text = DateTime.Now.ToString("ss");

            //if (label1.Text == "01" )
            //{
            //    //MessageBox.Show("here");
            //    //LoadSQLIP();
            //    IPCheck();
            //}
            
        }

        private void FrmConnectionMonitor_Load(object sender, EventArgs e)
        {
            //LoadSQLIP();
            ConvertToDataTable("C:\\Users\\Ellen\\OneDrive\\Desktop\\Metropolia Notes\\IOT\\Exe\\IPDataSource.csv", 2);
        }

        public DataTable ConvertToDataTable(string filePath, int numberOfColumns)
        {
            DataTable tbl = new DataTable();

            for (int col = 0; col < numberOfColumns; col++)
                tbl.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split(',');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < 2; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }

            return tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=30.30.30.1;database=iot;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            //ClsEmailscs.SendEmail();
            ClsEmailscs.Email2();
        }

        private void bntExportToExcel_Click(object sender, EventArgs e)
        {
            ClsCommom.ExportToCsv();
        }
    }
}