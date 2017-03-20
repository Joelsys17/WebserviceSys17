using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        localhost.WebService1 obj = new localhost.WebService1();

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void SearchButton_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string load = SearchButton.Text;
            richTextBox1.Text = obj.GetWebsiteHtml(load);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Select_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void uppgift2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(81, 31);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Object[] fisk = obj.javaobjects();
            dataGridView1.DataSource = fisk;
        }
    }
}
