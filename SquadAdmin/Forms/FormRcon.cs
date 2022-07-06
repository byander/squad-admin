using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquadAdmin.Forms
{
    public partial class FormRcon : Form
    {
        List<string> listPlayers = new List<string>();
        string steamID = "";
        string allCommand = "";
        bool flagLoaded = false;

        public FormRcon()
        {
            InitializeComponent();
        }
        private void FormRcon_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SquadAdmin.Load.pastedText))
            {
                fillListBox(SquadAdmin.Load.pastedText);
            }
            txtCommandRule.Text = "AdminKick ";
            txtFilter.Text = SquadAdmin.Load.filterName;

            List<string> msgReasons = MainForm.loadData.msgReasons;
            for (int i = 0; i < msgReasons.Count; i++)
            {
                ListViewItem item = new ListViewItem(msgReasons[i]);
                cboReason.Items.Add(item.Text);
            }

            List<string> banLength = new List<string>();
            banLength.Add("Hora");
            banLength.Add("Dia");
            banLength.Add("Mês");
            foreach (string s in banLength)
            {
                cboTime.Items.Add(s);
            }
            cboTime.SelectedIndex = 1;

            flagLoaded = true;
        }            

        private void button2_Click(object sender, EventArgs e)
        {
            listPlayers.Clear();
            listBox1.Items.Clear();

            string pastedText = Clipboard.GetText();
            if (!string.IsNullOrEmpty(pastedText))
            {
                foreach (string s in Regex.Split(pastedText, "\n"))
                {
                    listBox1.Items.Add(s);
                    listPlayers.Add(s);
                }
                SquadAdmin.Load.pastedText = pastedText;
            }
        }

        private void fillListBox(string text)
        {
            foreach (string s in Regex.Split(text, "\n"))
            {
                listBox1.Items.Add(s);
                listPlayers.Add(s);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text) == false)
            {
                listBox1.Items.Clear();
                foreach (string str in listPlayers)
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
                foreach (string str in listPlayers)
                {
                    listBox1.Items.Add(str);
                }
            }
            SquadAdmin.Load.filterName = txtFilter.Text;
        }

        /// <summary>
        /// Evento ao clicar na lista
        /// </summary>
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            splitText();
            createAllCommand();
        }

        private void splitText()
        {
            try
            {
                string steamIDFull = Regex.Split(listBox1.Text, @"\|")[1];

                steamID = Regex.Split(steamIDFull, @"\:")[1].Trim();

                SquadAdmin.Load.steamID = steamID;

            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Kick
        /// </summary>
        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            enableDisableFiedls();
            createAllCommand();
        }

        /// <summary>
        /// Banir
        /// </summary>
        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            enableDisableFiedls();
            createAllCommand();
        }

        private void enableDisableFiedls()
        {
            if (opt1.Checked)
            {
                numLength.Enabled = false;
                cboTime.Enabled = false;

            }
            if (opt2.Checked)
            {
                numLength.Enabled = true;
                cboTime.Enabled = true;
            }
        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            createAllCommand();
        }

        /// <summary>
        /// Selecionar o tempo
        /// </summary>
        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flagLoaded == false)
            {
                return;
            }
            createAllCommand();
        }
        

        /// <summary>
        /// Motivo do kick/ban
        /// </summary>
        private void cboReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            createAllCommand();
        }

        private void createAllCommand()
        {
            if (opt1.Checked)
            {
                allCommand = "AdminKick " + steamID + " " + cboReason.Text;
            }
            if (opt2.Checked)
            {
                string banLength = setBanLength();
                allCommand = "AdminBan " + steamID + " " + banLength + " " + cboReason.Text;
            }
            txtCommandRule.Text = allCommand;
        }

        private string setBanLength()
        {
            string banLength = "";

            if (numLength.Value == 0)
            {
                banLength = numLength.Value.ToString();
            }
            else
            {
                banLength = numLength.Value.ToString() + getValueFromCombo(cboTime);
            }                        

            return banLength;
        }


        /// <summary>
        /// Converter valor do combo para unidade válida de comando
        /// </summary>
        private string getValueFromCombo(object sender)
        {
            string val = "";
            ComboBox combo = (ComboBox)sender;
            string text = combo.Text;

            switch (text)
            {
                case "Hora":
                    val = "h";
                    break;
                case "Dia":
                    val = "d";
                    break;
                case "Mês":
                    val = "m";
                    break;
            }

            return val;
        }
    }
}
