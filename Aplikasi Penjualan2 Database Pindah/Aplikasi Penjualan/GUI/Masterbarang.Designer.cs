namespace Aplikasi_Penjualan.GUI
{
    partial class Masterbarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masterbarang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.btsend = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelt = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Databarang = new System.Windows.Forms.DataGridView();
            this.jenis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texthargab = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.textpencarian = new System.Windows.Forms.TextBox();
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.texthargaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsatuan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis :";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(93, 67);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 20);
            this.textID.TabIndex = 1;
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(93, 101);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(200, 20);
            this.textnama.TabIndex = 2;
            // 
            // btsend
            // 
            this.btsend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsend.ForeColor = System.Drawing.Color.Black;
            this.btsend.Location = new System.Drawing.Point(93, 233);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(77, 22);
            this.btsend.TabIndex = 9;
            this.btsend.Text = "Save";
            this.btsend.UseVisualStyleBackColor = false;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btupdate.ForeColor = System.Drawing.Color.Black;
            this.btupdate.Location = new System.Drawing.Point(259, 233);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(82, 22);
            this.btupdate.TabIndex = 10;
            this.btupdate.Text = "Perbarui Data";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelt
            // 
            this.btdelt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdelt.ForeColor = System.Drawing.Color.Black;
            this.btdelt.Location = new System.Drawing.Point(347, 233);
            this.btdelt.Name = "btdelt";
            this.btdelt.Size = new System.Drawing.Size(77, 22);
            this.btdelt.TabIndex = 11;
            this.btdelt.Text = "Hapus Data";
            this.btdelt.UseVisualStyleBackColor = false;
            this.btdelt.Click += new System.EventHandler(this.btdelt_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btedit.ForeColor = System.Drawing.Color.Black;
            this.btedit.Location = new System.Drawing.Point(176, 233);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(77, 22);
            this.btedit.TabIndex = 12;
            this.btedit.Text = "Edit Data";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btnew
            // 
            this.btnew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnew.ForeColor = System.Drawing.Color.Black;
            this.btnew.Location = new System.Drawing.Point(10, 233);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(77, 22);
            this.btnew.TabIndex = 13;
            this.btnew.Text = "Data Baru";
            this.btnew.UseVisualStyleBackColor = false;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(563, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Databarang
            // 
            this.Databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Databarang.Location = new System.Drawing.Point(5, 261);
            this.Databarang.Name = "Databarang";
            this.Databarang.Size = new System.Drawing.Size(616, 192);
            this.Databarang.TabIndex = 15;
            this.Databarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Databarang_CellClick);
            // 
            // jenis
            // 
            this.jenis.AutoSize = true;
            this.jenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis.Location = new System.Drawing.Point(6, 138);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(50, 20);
            this.jenis.TabIndex = 16;
            this.jenis.Text = "Stok :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Harga beli :";
            // 
            // texthargab
            // 
            this.texthargab.Location = new System.Drawing.Point(421, 99);
            this.texthargab.Name = "texthargab";
            this.texthargab.Size = new System.Drawing.Size(200, 20);
            this.texthargab.TabIndex = 5;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(93, 141);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(200, 20);
            this.txtstok.TabIndex = 3;
            // 
            // textpencarian
            // 
            this.textpencarian.Location = new System.Drawing.Point(440, 235);
            this.textpencarian.Name = "textpencarian";
            this.textpencarian.Size = new System.Drawing.Size(159, 20);
            this.textpencarian.TabIndex = 8;
            this.textpencarian.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.ItemHeight = 13;
            this.cbjenis.Location = new System.Drawing.Point(421, 138);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(200, 21);
            this.cbjenis.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "APLIKASI PENJUALAN SODIKIN";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(10, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 57);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Harga jual :";
            // 
            // texthargaj
            // 
            this.texthargaj.Location = new System.Drawing.Point(421, 67);
            this.texthargaj.Name = "texthargaj";
            this.texthargaj.Size = new System.Drawing.Size(200, 20);
            this.texthargaj.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "satuan :";
            // 
            // txtsatuan
            // 
            this.txtsatuan.Location = new System.Drawing.Point(93, 188);
            this.txtsatuan.Name = "txtsatuan";
            this.txtsatuan.Size = new System.Drawing.Size(200, 20);
            this.txtsatuan.TabIndex = 7;
            // 
            // Masterbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 443);
            this.Controls.Add(this.txtsatuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texthargaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.textpencarian);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.texthargab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.Databarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelt);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Masterbarang";
            this.Text = "Masterbarang";
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelt;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Databarang;
        private System.Windows.Forms.Label jenis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texthargab;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox textpencarian;
        private System.Windows.Forms.ComboBox cbjenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texthargaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsatuan;
    }
}