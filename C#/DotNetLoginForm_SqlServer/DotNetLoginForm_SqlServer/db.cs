using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace DotNetLoginForm_SqlServer
{

    public static class MyConnection
    {
        public static SqlConnection con;
        public static SqlConnection GetConnection(string username, string password)
        {
            string info = (@"Data Source=LAPTOP-N7H58UUV\SQLEXPRESS;User ID=" + username + " ;Password=" + password + "");
            con = new SqlConnection(info);
            return con;
        }
        
    }
    public static class db
    {
        
        public static void OpenConection() {
            
            
            try
            {
 
                MyConnection.con.Open();           
                MessageBox.Show("Connection Open! Welcome ");
                
                Form2 myForm = new Form2();
                myForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
                
            }
            
        }

        public static void CloseConnection()
        {
            try
            {
   
                MyConnection.con.Close();
                MessageBox.Show("Connection Closed!");               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not close connection ! " + ex.Message);

            }
        }

        /* public static void ExecuteQueries(string Query_)
         {
             SqlCommand cmd = new SqlCommand(Query_, MyConnection.con);
             cmd.ExecuteNonQuery();
         }

          public SqlDataReader DataReader(string Query_)
          {
              SqlCommand cmd = new SqlCommand(Query_, con);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }

          public object ShowDataInGridView(string Query_)
          {
              SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
              DataSet ds = new DataSet();
              dr.Fill(ds);
              object dataum = ds.Tables[0];
              return dataum;
          }*/
    }
}
