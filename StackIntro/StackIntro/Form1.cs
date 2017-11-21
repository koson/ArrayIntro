using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackIntro
{
    public partial class Form1 : Form
    {
        Stack stack;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack();  // Generic stack
            propertyGrid1.SelectedObject = stack;
            txtrandom.Text = new Random().Next().ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            stack.Push(stack.Count.ToString() +". "+ txtrandom.Text);
            UpdateView();
            txtrandom.Text = new Random().Next().ToString();
        }

        private void UpdateView()
        {
            txtStack.Clear();
            foreach (var item in stack)
            {
                txtStack.AppendText(item.ToString()+Environment.NewLine);
            }
            propertyGrid1.Refresh();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count == 0)
                return;
            string stackPop = stack.Pop() as string;
            txtPop.Text = stackPop;
            UpdateView();
        }
    }
}
