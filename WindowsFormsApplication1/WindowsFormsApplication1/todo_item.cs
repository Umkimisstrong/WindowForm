using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class todo_item : UserControl
    {
        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;

        public string key = null;
        public string value = null;


        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(String Text, string Key, bool isChecked)
        {
            key = Key;
            value = Text;
            InitializeComponent();
            lbl.Text = Text;
            chkBox.Checked = isChecked;
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox.Checked)
            {
                this.BackColor = Color.Green;
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                this.BackColor = Color.Gainsboro;
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);
            }

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }


        private void todo_item_Load(object sender, EventArgs e)
        {
            if (chkBox.Checked)
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            lbl.Text = "Deleted";
            chkBox.Enabled = btn_delete.Enabled = false;

            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }
    }
}
