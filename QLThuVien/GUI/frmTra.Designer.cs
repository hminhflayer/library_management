
namespace GUI
{
    partial class frmTra
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
            this.dgvMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTra = new System.Windows.Forms.Button();
            this.cmbSach = new System.Windows.Forms.ComboBox();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMuon
            // 
            this.dgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuon.Location = new System.Drawing.Point(4, 25);
            this.dgvMuon.Name = "dgvMuon";
            this.dgvMuon.ReadOnly = true;
            this.dgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuon.Size = new System.Drawing.Size(452, 246);
            this.dgvMuon.TabIndex = 8;
            this.dgvMuon.Click += new System.EventHandler(this.dgvMuon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMuon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 277);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mượn";
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(94, 375);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(296, 46);
            this.btnTra.TabIndex = 11;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSach
            // 
            this.cmbSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSach.Enabled = false;
            this.cmbSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSach.FormattingEnabled = true;
            this.cmbSach.Location = new System.Drawing.Point(162, 59);
            this.cmbSach.Name = "cmbSach";
            this.cmbSach.Size = new System.Drawing.Size(215, 27);
            this.cmbSach.TabIndex = 19;
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocGia.Enabled = false;
            this.cmbDocGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(162, 21);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(215, 27);
            this.cmbDocGia.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Độc giả";
            // 
            // frmTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.cmbSach);
            this.Controls.Add(this.cmbDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTra";
            this.Text = "Danh sách mượn";
            this.Load += new System.EventHandler(this.frmMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.ComboBox cmbSach;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}