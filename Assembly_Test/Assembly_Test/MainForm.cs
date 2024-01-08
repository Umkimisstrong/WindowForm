using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembly_Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly obj = System.Reflection.Assembly.LoadFrom("D:\\Source\\2024\\WinformTest\\WindowForm\\Assembly_Test\\Assembly\\bin\\Assembly.dll");
            var frm = (Form)obj.CreateInstance("Assembly.newForm");

            if (frm != null)
            {
                //frm.Show();
                frm.TopLevel = false;
                frm.TopMost = true;
                
                panel1.Controls.Add(frm);
                frm.Show();
                
            }

        }
    }
}
