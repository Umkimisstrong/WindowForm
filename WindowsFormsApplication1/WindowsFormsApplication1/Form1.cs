using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int poss = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Text");
                return;
            }
            else
            {
                
            }

        }

        public void addItem(string Text, string Key, bool Checked)
        {
            todo_item item = new WindowsFormsApplication1.todo_item(Text, Key, Checked);
   
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
