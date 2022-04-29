using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SquadAdmin.Forms
{
    public partial class FormLayers : Form
    {
        string sendCommand;
        string currentLayer = "";
        DataTable dataTable;

        public FormLayers()
        {
            InitializeComponent();
        }

        private void FormLayers_Load(object sender, EventArgs e)
        {
            setToolTips();

            dgv.DataSource = MainForm.loadData.mapLayers;

            List<string> mapsNames = MainForm.loadData.mapsNames;
            for (int i = 0; i < mapsNames.Count; i++)
            {
                ListViewItem item = new ListViewItem(mapsNames[i]);
                cboMaps.Items.Add(item.Text);
            }

            dataTable = MainForm.loadData.mapLayers;

            currentLayer = SquadAdmin.Load.currentLayer;

            cboMaps.Text = currentLayer;
        }

        private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();
                       
            toolTip.SetToolTip(cboMaps, "Filtrar o mapa.");
            toolTip.SetToolTip(txtCommandRule, "Comando para enviar.");
            toolTip.SetToolTip(dgv, "Clique em qualquer célula da linha de interesse para enviar o layer no comando.");

        }

        private void cboMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selMap = cboMaps.Text.Replace("'", "''");
            string filterMap = "Map";

            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterMap, selMap);

            currentLayer = selMap;
            SquadAdmin.Load.currentLayer = currentLayer;
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string layer = "";
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgv.CurrentCell.OwningRow;
                layer = row.Cells["Rotation Name"].Value.ToString();
            }

            sendCommand = "AdminSetNextLayer " + layer;
            txtCommandRule.Text = sendCommand;

            Clipboard.SetText(sendCommand);

        }
    }
}
