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
    public partial class FormMaps2 : Form
    {
        string sendCommand;
        string map = "";
        string mode = "";

        public FormMaps2()
        {
            InitializeComponent();
        }

        private void FormMaps2_Load(object sender, EventArgs e)
        {
            setToolTips();

            List<string> mapsNames = MainForm.loadData.mapsNames;
            for (int i = 0; i < mapsNames.Count; i++)
            {
                checkedListBox1.Items.Add(mapsNames[i]);
            }

            List<string> gameModes = MainForm.loadData.gameModes;
            for (int i = 0; i < gameModes.Count; i++)
            {
                checkedListBox2.Items.Add(gameModes[i]);
            }


        }
                private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(checkedListBox1, "Permitido selecionar no máximo 3 mapas. 1 mapa selecionado significa o vencedor.");
            toolTip.SetToolTip(checkedListBox2, "Permitido selecionar todos. 1 modo selecionado significa o vencedor.");
            toolTip.SetToolTip(txtCommandRule, "Comando para enviar.");
            toolTip.SetToolTip(button2, "Clique para enviar as sugestões de mapas e/ou enviar o mapa vencedor (quando selecionado apenas 1).");
            toolTip.SetToolTip(button3, "Clique para enviar se desejam votação de mapa.");
            toolTip.SetToolTip(button1, "Clique para enviar as sugestões de modo de jogo.");
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
            txtCommandRule.Text = "";

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

            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendCommand = "adminbroadcast Sugestões para o próximo mapa?";
            txtCommandRule.Text = sendCommand;
            Clipboard.SetText(sendCommand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCommandRule.Text = "";

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

            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        
    }
}
