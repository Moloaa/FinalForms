using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalForms
{
    public partial class Fom1 : Form
    {
        public Fom1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("Wholesale");
        }
        /// limit user to number only (needs to be currency)
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.stdBusiness = textBox1.Text;
            form.pName = textBox2.Text;
            form.style = listBox1.Text;
            form.price = textBox4.Text;
            form.sr = listBox2.Text;
            form.email = textBox3.Text;
            form.ShowDialog();
        }
    }
}
