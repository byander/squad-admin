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

            Clipboard.SetText(sendCommand);
        }
    }
}
