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

namespace simple_hwid_lock // made by Mr Virus
{
    public partial class Form1 : Form // made by Mr Virus
    {
        public Form1()
        {
            InitializeComponent(); // made by Mr Virus
            check(); // made by Mr Virus
        }

        string hwid; // made by Mr Virus

        private void Form1_Load(object sender, EventArgs e) // made by Mr Virus
        {
            hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value; // made by Mr Virus
            textBox1.Text = hwid;
            textBox1.ReadOnly = true; // made by Mr Virus

        }

        private void button1_Click(object sender, EventArgs e) // made by Mr Virus
        {
            WebClient wb = new WebClient();
            string HWIDLIST = wb.DownloadString("http://127.0.0.1/hwid.txt"); // hwid list where u saving hwid's
            if (HWIDLIST.Contains(textBox1.Text))
            {
                MessageBox.Show("Your HWID is found on the system"); // made by Mr Virus
            }
            else
            {
                MessageBox.Show("hwid was not found in the system"); // made by Mr Virus
            }
        }

        private void button2_Click(object sender, EventArgs e) // made by Mr Virus
        {
            Clipboard.SetText(hwid); // made by Mr Virus
            button2.Enabled = false; // made by Mr Virus
            button2.Text = "Copied"; // made by Mr Virus
        }

        private void check() // made by Mr Virus
        {
            try
            {
                using (var client = new WebClient()) // made by Mr Virus
                {
                    using (client.OpenRead("http://127.0.0.1/hwid.txt")) // made by Mr Virus
                    {
                        label3.ForeColor = Color.Green; // made by Mr Virus
                        label3.Text = ("Online"); // made by Mr Virus
                    }
                }
            }
            catch
            {
                label3.ForeColor = Color.Red; // made by Mr Virus
                label3.Text = ("Offline"); // made by Mr Virus
            }
        }

        private void label3_Click(object sender, EventArgs e) // made by Mr Virus
        {

        } // made by Mr Virus
    } // made by Mr Virus
} // made by Mr Virus
