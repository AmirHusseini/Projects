
namespace Compolet
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
            this.components = new System.ComponentModel.Container();
            this.cJ2Compolet1 = new OMRON.Compolet.CIP.CJ2Compolet(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trueButton = new System.Windows.Forms.Button();
            this.falseButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cJ2Compolet1
            // 
            this.cJ2Compolet1.Active = false;
            this.cJ2Compolet1.ConnectionType = OMRON.Compolet.CIP.ConnectionType.UCMM;
            this.cJ2Compolet1.HeartBeatTimer = 0;
            this.cJ2Compolet1.LocalPort = 2;
            this.cJ2Compolet1.PeerAddress = "";
            this.cJ2Compolet1.ReceiveTimeLimit = ((long)(750));
            this.cJ2Compolet1.RoutePath = "";
            this.cJ2Compolet1.UseRoutePath = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(360, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(315, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 196);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // trueButton
            // 
            this.trueButton.Location = new System.Drawing.Point(315, 332);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(75, 23);
            this.trueButton.TabIndex = 4;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            this.trueButton.Click += new System.EventHandler(this.trueButton_Click);
            // 
            // falseButton
            // 
            this.falseButton.Location = new System.Drawing.Point(415, 332);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(75, 23);
            this.falseButton.TabIndex = 5;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            this.falseButton.Click += new System.EventHandler(this.falseButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(527, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 196);
            this.listBox2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.trueButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OMRON.Compolet.CIP.CJ2Compolet cJ2Compolet1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.Button falseButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

