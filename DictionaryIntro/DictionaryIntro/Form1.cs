using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryIntro
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> dictionary;

        public Form1()
        {
            InitializeComponent();
            dictionary = new Dictionary<int, string>();
            propertyGrid1.SelectedObject = dictionary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            dictionary.Add(id, name);
            UpdateView();
        }

        private void UpdateView()
        {
            propertyGrid1.Refresh();
            txtDictionary.Clear();
            foreach (var item in dictionary)
            {
                txtDictionary.AppendText(item + Environment.NewLine);
            }

        }

        private void btnFindByID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFindByID.Text);
            if (dictionary.ContainsKey(id))
            {
                string name = dictionary[id] as string;
                txtNameFound.Text = name;
            }
            else
                txtNameFound.Text = "Not Found!!";
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            string name = txtnameToFind.Text;
            var key = dictionary.Where(p => p.Value == name).Select(p => p.Key);

            txtIDFound.Clear();
            if (key.Count() == 0)
            {
                txtIDFound.Text = "Not found!!!";
                return;
            }
            else
            {
                foreach (var item in key)
                {
                    txtIDFound.AppendText(item.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
