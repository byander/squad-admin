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
    public partial class FormCommands : Form
    {
        public FormCommands()
        {
            InitializeComponent();
        }

        private void FormCommands_Load(object sender, EventArgs e)
        {
            setToolTips();

            dgv.DataSource = MainForm.loadData.commands;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            txtCommandRule.Text = SquadAdmin.Load.lastCommandSended;
            //if (!String.IsNullOrEmpty(txtCommandRule.Text))
            //{
            //    Clipboard.SetText(txtCommandRule.Text);
            //}
        }

        private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(txtCommandRule, "Comando para enviar.");
            toolTip.SetToolTip(dgv, "Clique em qualquer célula da linha de interesse para enviar o comando.");
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sendCommand = "";
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgv.CurrentCell.OwningRow;
                sendCommand = row.Cells["Comando"].Value.ToString();
            }

            txtCommandRule.Text = sendCommand;
            SquadAdmin.Load.lastCommandSended = sendCommand;

            Clipboard.SetText(sendCommand);
        }

        private void txtCommandRule_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCommandRule.Text))
            {
                //    //Clipboard.SetText(txtCommandRule.Text);
                SquadAdmin.Load.lastCommandSended = txtCommandRule.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCommandRule.Text = txtCommandRule.Text + " " + SquadAdmin.Load.steamID;
        }
    }
}
