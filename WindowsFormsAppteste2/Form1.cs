using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppteste2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntsomar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            int resultado = n1 + n2;

            txt3.Text = resultado.ToString();
        }

        private void bntlimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        private void bntfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
