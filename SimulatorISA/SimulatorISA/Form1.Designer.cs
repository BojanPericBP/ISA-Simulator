
namespace SimulatorISA
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgRegistri = new System.Windows.Forms.DataGridView();
            this.r1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.src = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMemorija = new System.Windows.Forms.DataGridView();
            this.column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenCode = new System.Windows.Forms.Button();
            this.btnSaveCode = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemorija)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(183, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCode.Location = new System.Drawing.Point(16, 218);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(833, 309);
            this.txtCode.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.dgRegistri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgMemorija);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 188);
            this.panel1.TabIndex = 2;
            // 
            // dgRegistri
            // 
            this.dgRegistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r1,
            this.r2,
            this.r3,
            this.r4,
            this.srb,
            this.srd,
            this.src});
            this.dgRegistri.Location = new System.Drawing.Point(19, 35);
            this.dgRegistri.Name = "dgRegistri";
            this.dgRegistri.Size = new System.Drawing.Size(1040, 45);
            this.dgRegistri.TabIndex = 11;
            // 
            // r1
            // 
            this.r1.HeaderText = "R1";
            this.r1.Name = "r1";
            // 
            // r2
            // 
            this.r2.HeaderText = "R2";
            this.r2.Name = "r2";
            // 
            // r3
            // 
            this.r3.HeaderText = "R3";
            this.r3.Name = "r3";
            // 
            // r4
            // 
            this.r4.HeaderText = "R4";
            this.r4.Name = "r4";
            // 
            // srb
            // 
            this.srb.HeaderText = "SRB";
            this.srb.Name = "srb";
            // 
            // srd
            // 
            this.srd.HeaderText = "SRD";
            this.srd.Name = "srd";
            // 
            // src
            // 
            this.src.HeaderText = "SRC";
            this.src.Name = "src";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stanje memorije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stanje registara";
            // 
            // dgMemorija
            // 
            this.dgMemorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemorija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column0,
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7,
            this.column8,
            this.column9});
            this.dgMemorija.Location = new System.Drawing.Point(15, 124);
            this.dgMemorija.Name = "dgMemorija";
            this.dgMemorija.Size = new System.Drawing.Size(1044, 45);
            this.dgMemorija.TabIndex = 8;
            // 
            // column0
            // 
            this.column0.HeaderText = "#0";
            this.column0.Name = "column0";
            // 
            // column1
            // 
            this.column1.HeaderText = "#1";
            this.column1.Name = "column1";
            // 
            // column2
            // 
            this.column2.HeaderText = "#2";
            this.column2.Name = "column2";
            // 
            // column3
            // 
            this.column3.HeaderText = "#3";
            this.column3.Name = "column3";
            // 
            // column4
            // 
            this.column4.HeaderText = "#4";
            this.column4.Name = "column4";
            // 
            // column5
            // 
            this.column5.HeaderText = "#5";
            this.column5.Name = "column5";
            // 
            // column6
            // 
            this.column6.HeaderText = "#6";
            this.column6.Name = "column6";
            // 
            // column7
            // 
            this.column7.HeaderText = "#7";
            this.column7.Name = "column7";
            // 
            // column8
            // 
            this.column8.HeaderText = "#8";
            this.column8.Name = "column8";
            // 
            // column9
            // 
            this.column9.HeaderText = "#9";
            this.column9.Name = "column9";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnOpenCode);
            this.panel3.Controls.Add(this.btnSaveCode);
            this.panel3.Controls.Add(this.btnRestart);
            this.panel3.Controls.Add(this.btnStep);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(874, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 477);
            this.panel3.TabIndex = 4;
            // 
            // btnOpenCode
            // 
            this.btnOpenCode.Location = new System.Drawing.Point(21, 288);
            this.btnOpenCode.Name = "btnOpenCode";
            this.btnOpenCode.Size = new System.Drawing.Size(183, 54);
            this.btnOpenCode.TabIndex = 15;
            this.btnOpenCode.Text = "OTVORI FAJL";
            this.btnOpenCode.UseVisualStyleBackColor = true;
            this.btnOpenCode.Click += new System.EventHandler(this.btnOpenCode_Click);
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Location = new System.Drawing.Point(21, 228);
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(183, 54);
            this.btnSaveCode.TabIndex = 14;
            this.btnSaveCode.Text = "SACUVAJ KOD";
            this.btnSaveCode.UseVisualStyleBackColor = true;
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(21, 168);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(183, 54);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Location = new System.Drawing.Point(21, 108);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(183, 54);
            this.btnStep.TabIndex = 1;
            this.btnStep.Text = "JEDAN KORAK";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Location = new System.Drawing.Point(0, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 109);
            this.panel2.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(16, 8);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(833, 88);
            this.txtLog.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1095, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISA Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemorija)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgMemorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn column9;
        private System.Windows.Forms.DataGridView dgRegistri;
        private System.Windows.Forms.DataGridViewTextBoxColumn r1;
        private System.Windows.Forms.DataGridViewTextBoxColumn r2;
        private System.Windows.Forms.DataGridViewTextBoxColumn r3;
        private System.Windows.Forms.DataGridViewTextBoxColumn r4;
        private System.Windows.Forms.DataGridViewTextBoxColumn srb;
        private System.Windows.Forms.DataGridViewTextBoxColumn srd;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn src;
        private System.Windows.Forms.Button btnSaveCode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenCode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

