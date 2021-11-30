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
    public partial class FormMaps : Form
    {
        static Load loadData = new Load();
        string sendCommand;
        string map = "";
        string mode = "";

        public FormMaps()
        {
            InitializeComponent();
        }

        private void FormMaps_Load(object sender, EventArgs e)
        {
            List<string> mapsNames = loadData.mapsNames;
            for (int i = 0; i < mapsNames.Count; i++)
            {
                checkedListBox1.Items.Add(mapsNames[i]);
            }

            List<string> gameModes = loadData.gameModes;
            for (int i = 0; i < gameModes.Count; i++)
            {
                checkedListBox2.Items.Add(gameModes[i]);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 3)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSendMapVote.Text = "";

            List<string> mapSel = new List<string>();
            int count = 0;
            string maps = "";
            

            foreach (String s in checkedListBox1.CheckedItems)
            {
                map = s;
                count++;
                mapSel.Add(count + ") " + s);
            }

            foreach (String s in mapSel)
            {
                maps = maps + " " + s;
            }

            if (count == 1)
            {
                sendCommand = "adminbroadcast " + map + " venceu! Obrigado a todos pelo voto e bom jogo!";
            }
            else
            {
                sendCommand = "adminbroadcast Vote apenas uma vez:" + maps;
            }

            txtSendMapVote.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendCommand = "adminbroadcast Sugestões para o próximo mapa?";
            txtSendMapVote.Text = sendCommand;
            Clipboard.SetText(sendCommand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSendMapVote.Text = "";

            List<string> mapSel = new List<string>();
            int count = 0;
            string modes = "";
           

            foreach (String s in checkedListBox2.CheckedItems)
            {
                mode = s;
                count++;
                mapSel.Add(count + ") " + s);
            }

            foreach (String s in mapSel)
            {
                modes = modes + " " + s;
            }

            if (count == 1)
            {
                sendCommand = "adminbroadcast Mapa " + map + " modo " + mode + " venceu! Obrigado a todos pelo voto e bom jogo!";
            }
            else
            {
                sendCommand = "adminbroadcast Vote apenas uma vez no modo de jogo:" + modes;
            }

            txtSendMapVote.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }
    }
}
