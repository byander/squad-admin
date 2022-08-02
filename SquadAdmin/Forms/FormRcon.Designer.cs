namespace SquadAdmin.Forms
{
    partial class FormRcon
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
            this.lblCommand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomReason = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCommandRule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
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
            this.lblCommand.Size = new System.Drawing.Size(784, 30);
            this.lblCommand.TabIndex = 13;
            this.lblCommand.Text = "Comando:";
            this.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCustomReason);
            this.panel2.Controls.Add(this.numLength);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboReason);
            this.panel2.Controls.Add(this.opt2);
            this.panel2.Controls.Add(this.opt1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 144);
            this.panel2.TabIndex = 16;
            // 
            // txtCustomReason
            // 
            this.txtCustomReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.txtCustomReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomReason.Enabled = false;
            this.txtCustomReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomReason.ForeColor = System.Drawing.Color.White;
            this.txtCustomReason.Location = new System.Drawing.Point(403, 84);
            this.txtCustomReason.Name = "txtCustomReason";
            this.txtCustomReason.Size = new System.Drawing.Size(305, 21);
            this.txtCustomReason.TabIndex = 25;
            this.txtCustomReason.TextChanged += new System.EventHandler(this.txtCustomReason_TextChanged);
            // 
            // numLength
            // 
            this.numLength.Enabled = false;
            this.numLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLength.Location = new System.Drawing.Point(102, 81);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(64, 22);
            this.numLength.TabIndex = 24;
            this.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLength.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(207, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tempo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Enabled = false;
            this.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(210, 80);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(98, 23);
            this.cboTime.TabIndex = 22;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(99, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(342, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Motivo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboReason
            // 
            this.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Location = new System.Drawing.Point(403, 56);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(305, 23);
            this.cboReason.TabIndex = 18;
            this.cboReason.SelectedIndexChanged += new System.EventHandler(this.cboReason_SelectedIndexChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opt2.FlatAppearance.BorderSize = 0;
            this.opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt2.ForeColor = System.Drawing.Color.White;
            this.opt2.Location = new System.Drawing.Point(21, 84);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(54, 19);
            this.opt2.TabIndex = 17;
            this.opt2.Text = "Banir";
            this.opt2.UseVisualStyleBackColor = true;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt2_CheckedChanged);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Checked = true;
            this.opt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opt1.FlatAppearance.BorderSize = 0;
            this.opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt1.ForeColor = System.Drawing.Color.White;
            this.opt1.Location = new System.Drawing.Point(21, 56);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(48, 19);
            this.opt1.TabIndex = 16;
            this.opt1.TabStop = true;
            this.opt1.Text = "Kick";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Colar do Rcon";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.White;
            this.txtFilter.Location = new System.Drawing.Point(103, 25);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(257, 21);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Procurar jogador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(784, 347);
            this.listBox1.TabIndex = 17;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
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
            this.txtCommandRule.Size = new System.Drawing.Size(784, 40);
            this.txtCommandRule.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(341, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Outro:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(784, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lista do RCON";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormRcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCommandRule);
            this.Controls.Add(this.lblCommand);
            this.Name = "FormRcon";
            this.Text = "Rcon";
            this.Load += new System.EventHandler(this.FormRcon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCommandRule;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}