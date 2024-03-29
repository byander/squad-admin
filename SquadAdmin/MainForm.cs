/*
 * Created by SharpDevelop.
 * User: Ander_Desktop
 * Date: 26/11/2021
 * Time: 08:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Hotkeys;
using System.Reflection;

namespace SquadAdmin
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private Hotkeys.GlobalHotkey ghk;
        private bool onTop = false;

        private Button currentButton;
        private Form activeForm;

        public static Load loadData = new Load();


        public MainForm()
        {
            InitializeComponent();

            //Configuração do atalho
            ghk = new Hotkeys.GlobalHotkey(Constants.ALT, Keys.V, this);

        }
        void MainFormLoad(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            this.Text = $"Squad Admin - v{version.Major}.{version.Minor}";
            if (loadData.checkSheet() == false)
            {
                MessageBox.Show("Planilha contendo os dados não existe");
                return;
            }
            loadSettings();

            setToolTips();

            button4.PerformClick();

            if (ghk.Register())
            {

            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
            {
                HandleHotkey();
            }
            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            if (onTop == false)
            {
                this.TopMost = true;
                this.Opacity = 0.7;
                onTop = true;
                this.BringToFront();
                this.Focus();
                this.Activate();
            }
            else
            {
                this.TopMost = false;
                this.Opacity = 1;
                onTop = false;
                this.SendToBack();
            }
        }

        void loadSettings()
        {
            int location_x = Properties.Settings.Default.location_x;
            int location_y = Properties.Settings.Default.location_y;
            int width = Properties.Settings.Default.width;
            int height = Properties.Settings.Default.height;

            this.Location = new Point(location_x, location_y);
            this.Height = height;
            this.Width = width;
        }

        private void setToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(button4, "Enviar mensagens no jogo.");
            toolTip.SetToolTip(button5, "Enviar sugestões de mapa e modo no jogo.");
            toolTip.SetToolTip(button6, "Selecionar o próximo layer.");
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskop.Controls.Add(childForm);
            this.panelDeskop.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(56, 58, 64);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(47, 49, 54);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void event_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLayers(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRules(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMaps2(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCommands(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRcon(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBroadcast(), sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.location_x = this.Location.X;
            Properties.Settings.Default.location_y = this.Location.Y;
            Properties.Settings.Default.width = this.Width;
            Properties.Settings.Default.height = this.Height;

            if (this.Location.X < 0 || this.Location.Y < 0)
            {
                Properties.Settings.Default.location_x = 0;
                Properties.Settings.Default.location_y = 0;
            }    
        
            Properties.Settings.Default.Save();

            if (!ghk.Unregiser())
            {
            }
            
        }
        
    }
}
