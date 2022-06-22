using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trickey_Question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I knew it! ;)", "AHA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int inX = random.Next(1, 700);
            int inY = random.Next(1, 400);

            var point = new Point();

            point.X = inX;
            point.Y = inY;

            btnNo.Location = point;
        }
    }
}
