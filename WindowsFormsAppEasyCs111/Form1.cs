using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs111
{
    public partial class Form1 : Form
    {
        private Label lb1, lb2;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Display Your Machine's IP";
            this.Width = 300;
            this.Height = 100;

            string hn = Dns.GetHostName();
            IPHostEntry ih = Dns.GetHostEntry(hn);

            IPAddress ia = ih.AddressList[0];

            lb1 = new Label();
            lb2 = new Label();

            lb1.Width = 300;
            lb1.Top = 0;
            lb1.Text = "Host Name: " + hn;

            lb2.Width = 300;
            lb2.Top = lb1.Bottom;
            lb2.Text = "IP Address: " + ia.ToString();

            lb1.Parent = this;
            lb2.Parent = this;
        }
    }
}