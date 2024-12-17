using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtchungchi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table;
            string sql;
            sql = "";
            if (checkBox1.Checked == true)
            {
                sql = "insert ChungChi_5 values (N'" + txtchungchi.Text + "' ,N'" + cbbmaloaicc.Text  '" + N'" + cbbmanv.Text
                            
            }
        }
        private void upLoadData()
        {
            dtgv1.DataSource =Class1.Query("select * from LoaiChungChi_7");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if(checkBox1.Checked == true)
                {
                    cbbmaloaicc.Enabled = true; 
                }
                else
                {
                    cbbmaloaicc.Enabled = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) 
            {
                cbbmanv.Enabled = true;
            }
            else
            {
                cbbmanv.Enabled = false;
            }
        }
    }

   

    }
