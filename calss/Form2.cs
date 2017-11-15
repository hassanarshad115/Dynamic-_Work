using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calss
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        object a = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                DialogResult resullt = MessageBox.Show("Do you want to Delete Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resullt == DialogResult.Yes)
                {
                    MessageBox.Show(" Successfully hogya yra");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) )
            {
                e.Handled = true;
                MessageBox.Show("Enter Only String Data", "Warninng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtbox pr dbl click kr k
        {
            Control c =(Control) sender;
            c.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox2.Text =Convert.ToString( a);
        }
    }
}
