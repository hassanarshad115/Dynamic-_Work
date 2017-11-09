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
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Method();

        }

        private void Method()
        {
            Form2 o = new Form2();
            o.Text = textBox1.Text;            
            o.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

                AddNewForm();
            
        }

        private void AddNewForm() //HASSAN MALIK
        {
            Form obj = new Form();
            obj.Text = "Create By Button";
            obj.StartPosition = FormStartPosition.CenterScreen;
            //obj.BackColor = Color.Red;
           

            TextBox t = TextBoxOne(obj); // txtbox k lye
            t.Text = textBox1.Text; //txtbox k lye


            TextBox t1 = new TextBox(); // for txtbox
            obj.Controls.Add(t1);

            Point p1 = new Point(30, 100);
            t1.Location = p1;
            t1.Width = 150;
            t1.Text = textBox2.Text;

            Point loc = new Point(0, 32); // for label
            Label l = new Label();
            obj.Controls.Add(l);
            l.Text = "First Name Is =";
            l.Location = loc;

            
            

            // HASSAN MALIK


            obj.Show();
        }

        private static TextBox TextBoxOne(Form obj)
        {
            TextBox t = new TextBox();
            obj.Controls.Add(t); //nzr ay
            Point p = new Point(30, 50);
            t.Location = p; // side with left right r up down
            t.Width = 150; // width txtbox ki

            Point loc = new Point(0, 73);
            Label l = new Label();
            obj.Controls.Add(l);
            l.Text = "Second Name Is =";
            l.Location = loc;
            return t;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                MessageBox.Show("You can Enter only Sting values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
