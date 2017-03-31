using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication3.ServiceReference3;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=GEDDA;Initial Catalog=Cronus;Integrated Security=True");
        WebService2SoapClient service = new WebService2SoapClient();


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
            richTextBox1.Text = service.GetWebsiteHtml(load);
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
            dataGridView1.DataSource = service.sqlstring();
        }
    }
}
