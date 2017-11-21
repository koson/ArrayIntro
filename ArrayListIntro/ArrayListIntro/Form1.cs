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
            al.Add(new Random().NextDouble());
            propertyGrid1.Refresh();
            textBox1.Clear();
            foreach (var item in al)
            {
                textBox1.AppendText( string.Format("{0:N3}", item)  + Environment.NewLine);
            }
        }
    }
}


//https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings