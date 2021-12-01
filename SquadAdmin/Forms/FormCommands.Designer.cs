namespace SquadAdmin.Forms
{
    partial class FormCommands
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
            this.txtCommandRule = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.txtCommandRule.TabIndex = 16;
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
            this.lblCommand.TabIndex = 15;
            this.lblCommand.Text = "Comando:";
            this.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt2.ForeColor = System.Drawing.Color.White;
            this.opt2.Location = new System.Drawing.Point(189, 5);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(143, 19);
            this.opt2.TabIndex = 20;
            this.opt2.Text = "Warning para usuário";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Checked = true;
            this.opt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opt1.FlatAppearance.BorderSize = 0;
            this.opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt1.ForeColor = System.Drawing.Color.White;
            this.opt1.Location = new System.Drawing.Point(103, 5);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(73, 19);
            this.opt1.TabIndex = 19;
            this.opt1.TabStop = true;
            this.opt1.Text = "Brodcast";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 70);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.Size = new System.Drawing.Size(800, 380);
            this.dgv.TabIndex = 21;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // FormCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtCommandRule);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt1);
            this.Name = "FormCommands";
            this.Text = "Comandos úteis";
            this.Load += new System.EventHandler(this.FormCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommandRule;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.DataGridView dgv;
    }
}