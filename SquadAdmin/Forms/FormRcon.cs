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
            txtCommandRule.Text = SquadAdmin.Load.steamID;
            txtFilter.Text = SquadAdmin.Load.filterName ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SquadAdmin.Load.steamID);
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

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            splitText();
        }

        private void splitText()
        {
            try
            {
                string steamIDFull = Regex.Split(listBox1.Text, @"\|")[1];
                string steamID = Regex.Split(steamIDFull, @"\:")[1].Trim();

                txtCommandRule.Text = steamID;
                SquadAdmin.Load.steamID = steamID;
            }
            catch (Exception ex)
            {
            }
        }

        
    }
}
