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
    public partial class FormBroadcast : Form
    {
        string sendCommand;
        List<string> listRules = new List<string>();

        public FormBroadcast()
        {
            InitializeComponent();
            listRules.Clear();            
        }

        private void FormBroadcast_Load(object sender, EventArgs e)
        {
            setToolTips();

            List<string> messages = MainForm.loadData.messages;
            for (int i = 0; i < messages.Count; i++)
            {
                listBox1.Items.Add(messages[i]);
                listRules.Add(messages[i]);
            }
                       
            txtCommandRule.Text = SquadAdmin.Load.lastRuleSended;
            if (!String.IsNullOrEmpty(txtCommandRule.Text))
            {
                Clipboard.SetText(txtCommandRule.Text);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            setMessage();
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            setMessage();
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            setMessage();
        }
              

        private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(listBox1, "Clique na regra para copiar o texto.");
            toolTip.SetToolTip(txtFilter, "Digite para filtrar as regras.");
            toolTip.SetToolTip(txtCommandRule, "Comando para enviar.");
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

        private void setMessage()
        {
            txtCommandRule.Text = "";
          
            sendCommand = "adminbroadcast " + listBox1.Text;
                  
            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        private void txtCommandRule_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCommandRule.Text))
            {
                SquadAdmin.Load.lastRuleSended = txtCommandRule.Text;
            }
            //Clipboard.SetText(txtCommandRule.Text);
        }

       
    }
}
