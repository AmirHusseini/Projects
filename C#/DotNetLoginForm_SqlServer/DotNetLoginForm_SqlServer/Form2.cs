using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotNetLoginForm_SqlServer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM sys.database", MyConnection.con);
            //comboBox1.Items.Add(cmd);
            using (IDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.CloseConnection();    
        }
    }
}
