using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Firebase_Todo_Winform_App
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(string Text, string Key, bool Checked)
        {
            key = Key;
            value = Text;
            InitializeComponent();
            label1.Text = Text;
            checkBox1.Checked = Checked;

        }

        private void checkBox1_OnChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            }

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private string key = null;
        private string value = null;
        public event EventHandler onChange= null;
        public event EventHandler onDelete = null;

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            label1.Text = "Deleted";
            checkBox1.Enabled = btn_delete.Enabled = false;

            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }
    }
}
