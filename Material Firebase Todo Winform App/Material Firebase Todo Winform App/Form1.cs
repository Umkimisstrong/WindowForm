using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Firebase_Todo_Winform_App
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
            addItem(textBox1.Text, "0", false);
        }

        public void addItem(string Text, string Key, bool Checked)
        {
            todo_item item = new Material_Firebase_Todo_Winform_App.todo_item(Text, Key, Checked);
            panel2.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;

            item.Top = poss;
            poss = (item.Top + item.Height + 10);

        }

        private void Item_onDelete(object sender, EventArgs e)
        {
            MessageBox.Show("on delete test");
        }

        private void Item_onChange(object sender, EventArgs e)
        {
           
        }
    }
}
