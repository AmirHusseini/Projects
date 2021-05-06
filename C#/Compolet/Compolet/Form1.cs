using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using OMRON.Compolet.CIP;

namespace Compolet
{
    public partial class Form1 : Form
    {
        private NJCompolet myCJ2 = new NJCompolet();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myCJ2.UseRoutePath = false;
                myCJ2.PeerAddress = "192.168.250.1";
                myCJ2.LocalPort = 2;
                myCJ2.Active = true;
                Label2.Text = myCJ2.UnitName;
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
            string[] variableNames = myCJ2.VariableNames;
            listBox1.Items.Clear();
            foreach (var item in variableNames)
            {
                listBox1.Items.Add(item);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCJ2.WriteVariable(listBox1.SelectedItem.ToString(), textBox1.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = myCJ2.ReadVariable(listBox1.SelectedItem.ToString()).ToString();


        }
        private void update()
        {
            string[] variableNames = myCJ2.VariableNames;
            listBox2.Items.Clear();
            foreach (var item in variableNames)
            {

                if (item == "Temp2")
                {
                    string var = myCJ2.ReadVariable(item).ToString();
                    var = var.Insert((var.Length - 1), ",");
                    listBox2.Items.Add(var);
                }
                else
                {
                    listBox2.Items.Add(myCJ2.ReadVariable(item));
                }

            }

        }

        private void trueButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "True";
            myCJ2.WriteVariable(listBox1.SelectedItem.ToString(), textBox1.Text);
        }

        private void falseButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "False";
            myCJ2.WriteVariable(listBox1.SelectedItem.ToString(), textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
            //button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] variableNames = myCJ2.VariableNames;
            if (myCJ2.ReadVariable("OD00").ToString() == "True" && myCJ2.ReadVariable("OD02").ToString() == "False")
            {
                myCJ2.WriteVariable("OD00", "False");
                myCJ2.WriteVariable("OD02", "True");
            }
            else
            {
                myCJ2.WriteVariable("OD00", "True");
                myCJ2.WriteVariable("OD02", "False");
            }
        }
    }
}
