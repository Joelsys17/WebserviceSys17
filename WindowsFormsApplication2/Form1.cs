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
        public Form1()
        {
            InitializeComponent();
        }
        localhost.WebService1 obj = new localhost.WebService1();

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string textsearch = bunifuMetroTextbox1.Text;
            obj.txtFile(textsearch);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            /*string rand = getRandomString();
            textBox1.Text = rand;*/
            string rand = bunifuMetroTextbox1.Text;
            using (var sbr = new SolidBrush(Color.Black))
            {
                FontFamily fam = new FontFamily("Magneto");
                Font font = new System.Drawing.Font(fam, 24, FontStyle.Bold);
                g.DrawString(rand, font, sbr, new Point(20, 20));
            }
        }
    }
}
