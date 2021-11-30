namespace SquadAdmin.Forms
{
    partial class FormLayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtCommandRule = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cboMaps = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMaps);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblRules);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(89, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mapa: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRules
            // 
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRules.Location = new System.Drawing.Point(12, 4);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(71, 40);
            this.lblRules.TabIndex = 10;
            this.lblRules.Text = "Regras";
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommandRule
            // 
            this.txtCommandRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.txtCommandRule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCommandRule.ForeColor = System.Drawing.Color.White;
            this.txtCommandRule.Location = new System.Drawing.Point(0, 30);
            this.txtCommandRule.Multiline = true;
            this.txtCommandRule.Name = "txtCommandRule";
            this.txtCommandRule.Size = new System.Drawing.Size(800, 40);
            this.txtCommandRule.TabIndex = 13;
            // 
            // lblCommand
            // 
            this.lblCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.ForeColor = System.Drawing.Color.White;
            this.lblCommand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCommand.Location = new System.Drawing.Point(0, 0);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(800, 30);
            this.lblCommand.TabIndex = 12;
            this.lblCommand.Text = "Comando:";
            this.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 120);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.Size = new System.Drawing.Size(800, 330);
            this.dgv.TabIndex = 16;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // cboMaps
            // 
            this.cboMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaps.FormattingEnabled = true;
            this.cboMaps.Location = new System.Drawing.Point(153, 15);
            this.cboMaps.Name = "cboMaps";
            this.cboMaps.Size = new System.Drawing.Size(253, 21);
            this.cboMaps.TabIndex = 13;
            this.cboMaps.SelectedIndexChanged += new System.EventHandler(this.cboMaps_SelectedIndexChanged);
            // 
            // FormLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCommandRule);
            this.Controls.Add(this.lblCommand);
            this.Name = "FormLayers";
            this.Text = "FormLayers";
            this.Load += new System.EventHandler(this.FormLayers_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtCommandRule;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cboMaps;
    }
}