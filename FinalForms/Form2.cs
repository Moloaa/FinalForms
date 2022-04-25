using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalForms
{
    public partial class Form2 : Form
    {  public string stdBusiness { get; set; }
        public string pName { get; set; }
        public string style { get; set; }
        public string sr { get; set; }
        public string price { get; set; }
        public string email { get; set; }
        public Form2()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = stdBusiness;
            textBox2.Text = pName;
            textBox3.Text = style;
            textBox5.Text = price;
            textBox4.Text = sr;
            textBox6.Text = email;
        


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///can this be an email link ?
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {///form to file in partner folder
            //StreamWriter Partner = new StreamWriter(Application.StartupPath + "C:/Users/17197/OneDrive - UAT/PROGRAM_CONCEPTS/FinalForms/PartnerForms");
            //Partner.WriteLine(textBox1.Text);
            //Partner.WriteLine(textBox2.Text);
            //Partner.WriteLine(textBox3.Text);
            //Partner.WriteLine(textBox4.Text);
            //Partner.WriteLine(textBox5.Text);
            //Partner.WriteLine(textBox6.Text);
            //Partner.WriteLine(textBox7.Text);
            MessageBox.Show("Thank you! We will be in contact soon!");
        }
    }
}
