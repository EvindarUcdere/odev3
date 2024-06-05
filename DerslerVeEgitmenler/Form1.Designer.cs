namespace DerslerVeEgitmenler
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
            this.tobPage1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.txtEgitmenID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDErsAdı = new System.Windows.Forms.TextBox();
            this.txtEgitmenAdı = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAdEgitmen = new System.Windows.Forms.TextBox();
            this.txtIdEgitmen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tobPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tobPage1
            // 
            this.tobPage1.Controls.Add(this.tabPage1);
            this.tobPage1.Controls.Add(this.tabPage2);
            this.tobPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tobPage1.Location = new System.Drawing.Point(0, 0);
            this.tobPage1.Name = "tobPage1";
            this.tobPage1.SelectedIndex = 0;
            this.tobPage1.Size = new System.Drawing.Size(608, 450);
            this.tobPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDersID);
            this.tabPage1.Controls.Add(this.txtEgitmenID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDErsAdı);
            this.tabPage1.Controls.Add(this.txtEgitmenAdı);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "dersEkle";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(119, 292);
            this.txtDersID.Multiline = true;
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(147, 37);
            this.txtDersID.TabIndex = 8;
            // 
            // txtEgitmenID
            // 
            this.txtEgitmenID.Location = new System.Drawing.Point(119, 118);
            this.txtEgitmenID.Multiline = true;
            this.txtEgitmenID.Name = "txtEgitmenID";
            this.txtEgitmenID.Size = new System.Drawing.Size(147, 34);
            this.txtEgitmenID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = " Ders ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egitmen ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ders Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Egitmen Adı";
            // 
            // txtDErsAdı
            // 
            this.txtDErsAdı.Location = new System.Drawing.Point(119, 214);
            this.txtDErsAdı.Multiline = true;
            this.txtDErsAdı.Name = "txtDErsAdı";
            this.txtDErsAdı.Size = new System.Drawing.Size(147, 34);
            this.txtDErsAdı.TabIndex = 2;
            // 
            // txtEgitmenAdı
            // 
            this.txtEgitmenAdı.Location = new System.Drawing.Point(119, 59);
            this.txtEgitmenAdı.Multiline = true;
            this.txtEgitmenAdı.Name = "txtEgitmenAdı";
            this.txtEgitmenAdı.Size = new System.Drawing.Size(147, 32);
            this.txtEgitmenAdı.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(360, 292);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnListele);
            this.tabPage2.Controls.Add(this.txtAdEgitmen);
            this.tabPage2.Controls.Add(this.txtIdEgitmen);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DersListele";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(72, 210);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(85, 38);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdEgitmen
            // 
            this.txtAdEgitmen.Location = new System.Drawing.Point(115, 94);
            this.txtAdEgitmen.Multiline = true;
            this.txtAdEgitmen.Name = "txtAdEgitmen";
            this.txtAdEgitmen.Size = new System.Drawing.Size(119, 33);
            this.txtAdEgitmen.TabIndex = 4;
            // 
            // txtIdEgitmen
            // 
            this.txtIdEgitmen.Location = new System.Drawing.Point(115, 40);
            this.txtIdEgitmen.Multiline = true;
            this.txtIdEgitmen.Name = "txtIdEgitmen";
            this.txtIdEgitmen.Size = new System.Drawing.Size(119, 34);
            this.txtIdEgitmen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Egitmen Adı ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Egitmen Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.tobPage1);
            this.Name = "Form1";
            this.Text = "t";
            this.tobPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tobPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDErsAdı;
        private System.Windows.Forms.TextBox txtEgitmenAdı;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.TextBox txtEgitmenID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAdEgitmen;
        private System.Windows.Forms.TextBox txtIdEgitmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

