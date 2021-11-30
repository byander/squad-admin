using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquadAdmin.Forms
{
    public partial class FormRules : Form
    {
        string sendCommand;
        static Load loadData = new Load();
        List<string> listRules = new List<string>();

        public FormRules()
        {
            InitializeComponent();
            listRules.Clear();            
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtCommandRule.Text = "";
            if(opt1.Checked)
            {
                sendCommand = "adminbroadcast " + listBox1.Text;
            } 
            else if (opt2.Checked)
            {
                sendCommand = "adminwarn PASTE_ID " + listBox1.Text;
            }

           
            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        private void FormRules_Load(object sender, EventArgs e)
        {
            string[] rules = loadData.rules;
            for (int i = 0; i < rules.Length; i++)
            {
                //ListViewItem item = new ListViewItem(rules[i]);
                listBox1.Items.Add(rules[i]);
                listRules.Add(rules[i]);
            }                       
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text) == false)
            {
                listBox1.Items.Clear();
                foreach (string str in listRules)
                {
                    if (str.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (txtFilter.Text == "")
            {
                listBox1.Items.Clear();
                foreach (string str in listRules)
                {
                    listBox1.Items.Add(str);
                }
            }
        }
    }
}
