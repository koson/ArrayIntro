using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueIntro
{
    public partial class Form1 : Form
    {
        Queue queue;
        public Form1()
        {
            InitializeComponent();
            queue = new Queue();
            propertyGrid1.SelectedObject = queue;
            txtEnQ.Text = string.Format("{0}", new Random().Next()).Substring(0,3); 
        }

        private void btnEnQ_Click(object sender, EventArgs e)
        {
            queue.Enqueue(txtEnQ.Text);
            UpdateView();
            txtEnQ.Text = string.Format("{0}", new Random().Next()).Substring(0, 3);
        }

        private void UpdateView()
        {
            propertyGrid1.Refresh();
            txtQueue.Clear();
            foreach (var item in queue)
            {
                txtQueue.AppendText(item + Environment.NewLine);
            }
        }

        private void btnDeQ_Click(object sender, EventArgs e)
        {
            try
            {
                string deq = queue.Dequeue() as string;
                txtDeQ.Text = deq;
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
