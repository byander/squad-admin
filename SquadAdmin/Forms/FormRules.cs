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
        List<string> listRules = new List<string>();

        public FormRules()
        {
            InitializeComponent();
            listRules.Clear();            
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

        private void FormRules_Load(object sender, EventArgs e)
        {
            setToolTips();

            List<string> rules = MainForm.loadData.rules;
            for (int i = 0; i < rules.Count; i++)
            {
                //ListViewItem item = new ListViewItem(rules[i]);
                listBox1.Items.Add(rules[i]);
                listRules.Add(rules[i]);
            }                       
        }

        private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(listBox1, "Clique na regra para copiar o texto.");
            toolTip.SetToolTip(txtFilter, "Digite para filtrar as regras.");
            toolTip.SetToolTip(opt1, "Marque esta opção para enviar no Brodcast.");
            toolTip.SetToolTip(opt2, "Marque esta opção para enviar um aviso ao usuário. É necessário colar o ID do usuário.");
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
            if (opt1.Checked)
            {
                sendCommand = "adminbroadcast " + listBox1.Text;
            }
            else if (opt2.Checked)
            {
                sendCommand = "adminwarn JOGADOR " + listBox1.Text;
            }
            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        
    }
}
