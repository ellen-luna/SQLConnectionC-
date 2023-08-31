using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace ConnectingToMySQL
{

    internal class ClsCommom
    {

        public static string sqlCon="";

        public static void MySQLC()
        {
            //string sqlCon= "server=localhost;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
            //sqlCon ="server=10.10.10.3;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
            sqlCon = "server=30.30.30.1;database=iot;uid=root;pwd=;";


            // return sqlCon;
        }

        public void MyConnOpen() 
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            
        }


    public static string PingIP(string str_ip_id,string strIP, string prev_status) 
        {


            string strStatus = "Close";
            int stat = 0;

            try {

                Ping ping = new Ping();
                PingReply pingresult = ping.Send(strIP);//ping.Send("81.2.199.57");
               // PingReply pingresult = ping.Send("30.30.30.1");
                if (pingresult.Status.ToString() == "Success")
                {
                    strStatus = "Open";
                }

            }
            catch 
            { 
                
            }



            //Ping ping = new Ping();
            //PingReply pingresult = ping.Send(strIP);//ping.Send("81.2.199.57");
           //PingReply pingresult = ping.Send("30.30.30.1");


            //if (pingresult.Status.ToString() == "Success")
            //{
            //    strStatus= "Open";
            //}

            if (strStatus != prev_status)
            {
                // Is

                

                if (strStatus == "Open")
                {
                    stat = 1;
                }

                else
                {
                    stat = 0;
                }


                //string connString = ClsCommom.MySQLC();//ConfigurationManager.ConnectionStrings["default"].ConnectionString;

                // string connString = "server=30.30.30.2;database=iot;uid=AdminUser;pwd=P@ssw0rd01;";
                string connString = "server=30.30.30.1;database=iot;uid=root;pwd=;";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO tbl_ip_trans(ref_id,status,trans_date) VALUES('" + str_ip_id.ToString() + "','" + stat + "','" + DateTime.Now.ToString() + "')";
                comm.ExecuteNonQuery();
                conn.Close();
            }

            return strStatus;
        }


     public static void ExportToCsv()
        {
            // Create a new CSV file
            using (var writer = new StreamWriter("export.csv"))
            {
                // Write the headers
                writer.WriteLine("Name,Age,Email");

                // Write some sample data
                writer.WriteLine("John Doe,30,john@example.com");
                writer.WriteLine("Jane Smith,25,jane@example.com");

                // Flush the writer to ensure data is written to the file
                writer.Flush();
            }
        }

    }


}
