namespace Proje_Hizmet
{
    partial class müsterilistelemefrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmüsteriıd = new System.Windows.Forms.TextBox();
            this.txtunvan = new System.Windows.Forms.TextBox();
            this.txtelno = new System.Windows.Forms.TextBox();
            this.txtmusıdara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜNVAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEL NO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 318);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtmüsteriıd
            // 
            this.txtmüsteriıd.Location = new System.Drawing.Point(152, 84);
            this.txtmüsteriıd.Name = "txtmüsteriıd";
            this.txtmüsteriıd.Size = new System.Drawing.Size(177, 22);
            this.txtmüsteriıd.TabIndex = 4;
            this.txtmüsteriıd.TextChanged += new System.EventHandler(this.txtmüsteriıd_TextChanged);
            // 
            // txtunvan
            // 
            this.txtunvan.Location = new System.Drawing.Point(152, 131);
            this.txtunvan.Name = "txtunvan";
            this.txtunvan.Size = new System.Drawing.Size(177, 22);
            this.txtunvan.TabIndex = 5;
            // 
            // txtelno
            // 
            this.txtelno.Location = new System.Drawing.Point(152, 176);
            this.txtelno.Name = "txtelno";
            this.txtelno.Size = new System.Drawing.Size(177, 22);
            this.txtelno.TabIndex = 6;
            // 
            // txtmusıdara
            // 
            this.txtmusıdara.Location = new System.Drawing.Point(622, 20);
            this.txtmusıdara.Name = "txtmusıdara";
            this.txtmusıdara.Size = new System.Drawing.Size(137, 22);
            this.txtmusıdara.TabIndex = 8;
            this.txtmusıdara.TextChanged += new System.EventHandler(this.txtmusıdara_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(453, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MÜŞTERİ ID ARA ";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(52, 259);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(116, 46);
            this.btngüncelle.TabIndex = 9;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(209, 259);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(120, 46);
            this.btniptal.TabIndex = 10;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(120, 334);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(106, 47);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // müsterilistelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.txtmusıdara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtelno);
            this.Controls.Add(this.txtunvan);
            this.Controls.Add(this.txtmüsteriıd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "müsterilistelemefrm";
            this.Text = "MÜŞTERİ LİSTELEME SAYFASI";
            this.Load += new System.EventHandler(this.müsterilistelemefrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.müsterilistelemefrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmüsteriıd;
        private System.Windows.Forms.TextBox txtunvan;
        private System.Windows.Forms.TextBox txtelno;
        private System.Windows.Forms.TextBox txtmusıdara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnsil;
    }
}