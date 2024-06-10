using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_giaithua1
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

        private void btntinhgiaithua_Click(object sender, EventArgs e)
        {
            double so;
            so = Convert.ToDouble(txtso.Text);
            int gt = 1;
            for(int i = 1; i <=so; i++) 
            {
                gt = gt * i;gt *= i;
            }
            lblkq.Text = gt.ToString();
        } 
    }
}
