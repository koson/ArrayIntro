using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a  = new int [10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }

            foreach (var item in a)
            {
                textBox1.AppendText(a[item].ToString()+Environment.NewLine);
            }

        }
    }
}
