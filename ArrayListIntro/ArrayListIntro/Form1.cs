using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListIntro
{
    public partial class Form1 : Form
    {
        ArrayList al; // เนื่องจากต้องการสร้าง al ให้เป็นตัวแปรที่เข้าถึงได้จากทุก method ในระดับ class  
        public Form1()
        {
            InitializeComponent();
            al = new ArrayList(); // ArrayList บรรจุสมาชิกที่เป็น ??
            propertyGrid1.SelectedObject = al;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            al.Add(new Random().Next().ToString());
            UpdateTextBox1();
        }

        private void UpdateTextBox1()
        {
            textBox1.Clear();
            foreach (var item in al)
            {
                textBox1.AppendText(string.Format("{0:N3}", item) + Environment.NewLine);
            }
            propertyGrid1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool found = al.Contains(textBox2.Text);
            MessageBox.Show(found == true ? "Found " + textBox2.Text : "String not found");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            al.Sort();
            UpdateTextBox1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            al.Reverse();
            UpdateTextBox1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            al.Remove(textBox3.Text);
            UpdateTextBox1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox4.Text);
            if (al.Count > 0)
                al.RemoveAt(i);
            UpdateTextBox1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            al.TrimToSize();
            UpdateTextBox1();
        }
    }
}

//https://msdn.microsoft.com/en-us/library/system.collections.arraylist(v=vs.110).aspx
//https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings