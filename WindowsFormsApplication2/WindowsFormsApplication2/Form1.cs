using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        public Form1()
        {
            Load += new EventHandler(Form1_Load);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlHelper helper = new SqlHelper();
            bindingSource1.DataSource = helper.getDataSet().Tables["TB_SAWON"];
            grid_sawon.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchKey = string.Empty;


            if (chk_bj.Checked)
            {
                searchKey = "bj";
            }
            else if (chk_cj.Checked)
            {
                searchKey = "cj";
            }
            else if (chk_dr.Checked)
            {
                searchKey = "dr";
            }
            else if (chk_gj.Checked)
            {
                searchKey = "gj";
            }
            else if (chk_jy.Checked)
            {
                searchKey = "jy";
            }
            else if (chk_sw.Checked)
            {
                searchKey = "sw";
            }
            else
            {
                searchKey = "";
            }

            SqlHelper helper = new SqlHelper();
            bindingSource1.DataSource = helper.getDataSet(searchKey).Tables["TB_SAWON"];
            grid_sawon.DataSource = bindingSource1;
        }

        #region events

        #endregion
        private void chk_bj_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cj.Checked)
                chk_cj.Checked = false;
            if (chk_dr.Checked)
                chk_dr.Checked = false;
            if (chk_gj.Checked)
                chk_gj.Checked = false;
            if (chk_jy.Checked)
                chk_jy.Checked = false;
            if (chk_sw.Checked)
                chk_sw.Checked = false;
        }

        private void chk_cj_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chk_bj.Checked)
                chk_bj.Checked = false;
            if (chk_dr.Checked)
                chk_dr.Checked = false;
            if (chk_gj.Checked)
                chk_gj.Checked = false;
            if (chk_jy.Checked)
                chk_jy.Checked = false;
            if (chk_sw.Checked)
                chk_sw.Checked = false;
        }

        private void chk_gj_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chk_bj.Checked)
                chk_bj.Checked = false;
            if (chk_dr.Checked)
                chk_dr.Checked = false;
            if (chk_cj.Checked)
                chk_cj.Checked = false;
            if (chk_jy.Checked)
                chk_jy.Checked = false;
            if (chk_sw.Checked)
                chk_sw.Checked = false;
        }

        private void chk_dr_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chk_bj.Checked)
                chk_bj.Checked = false;
            if (chk_gj.Checked)
                chk_gj.Checked = false;
            if (chk_cj.Checked)
                chk_cj.Checked = false;
            if (chk_jy.Checked)
                chk_jy.Checked = false;
            if (chk_sw.Checked)
                chk_sw.Checked = false;
        }

        private void chk_jy_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chk_bj.Checked)
                chk_bj.Checked = false;
            if (chk_gj.Checked)
                chk_gj.Checked = false;
            if (chk_cj.Checked)
                chk_cj.Checked = false;
            if (chk_dr.Checked)
                chk_dr.Checked = false;
            if (chk_sw.Checked)
                chk_sw.Checked = false;
        }

        private void chk_sw_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chk_bj.Checked)
                chk_bj.Checked = false;
            if (chk_gj.Checked)
                chk_gj.Checked = false;
            if (chk_cj.Checked)
                chk_cj.Checked = false;
            if (chk_dr.Checked)
                chk_dr.Checked = false;
            if (chk_jy.Checked)
                chk_jy.Checked = false;
        }
    }
}
