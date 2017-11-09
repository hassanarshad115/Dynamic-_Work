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
    }
}
