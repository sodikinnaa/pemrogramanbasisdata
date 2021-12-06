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
            this.dtmasuk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btsend = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelt = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Databarang = new System.Windows.Forms.DataGridView();
            this.jenis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textharga = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.textpencarian = new System.Windows.Forms.TextBox();
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
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
            this.textnama.TabIndex = 1;
            // 
            // dtmasuk
            // 
            this.dtmasuk.Location = new System.Drawing.Point(93, 135);
            this.dtmasuk.Name = "dtmasuk";
            this.dtmasuk.Size = new System.Drawing.Size(200, 20);
            this.dtmasuk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "tgl :";
            // 
            // btsend
            // 
            this.btsend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsend.ForeColor = System.Drawing.Color.Black;
            this.btsend.Location = new System.Drawing.Point(93, 185);
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
            this.btupdate.Location = new System.Drawing.Point(259, 185);
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
            this.btdelt.Location = new System.Drawing.Point(347, 185);
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
            this.btedit.Location = new System.Drawing.Point(176, 185);
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
            this.btnew.Location = new System.Drawing.Point(10, 185);
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
            this.button1.Location = new System.Drawing.Point(541, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Databarang
            // 
            this.Databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Databarang.Location = new System.Drawing.Point(5, 213);
            this.Databarang.Name = "Databarang";
            this.Databarang.Size = new System.Drawing.Size(616, 170);
            this.Databarang.TabIndex = 15;
            this.Databarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Databarang_CellClick);
            // 
            // jenis
            // 
            this.jenis.AutoSize = true;
            this.jenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis.Location = new System.Drawing.Point(324, 67);
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
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Harga :";
            // 
            // textharga
            // 
            this.textharga.Location = new System.Drawing.Point(421, 99);
            this.textharga.Name = "textharga";
            this.textharga.Size = new System.Drawing.Size(200, 20);
            this.textharga.TabIndex = 18;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(421, 67);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(200, 20);
            this.txtstok.TabIndex = 19;
            // 
            // textpencarian
            // 
            this.textpencarian.Location = new System.Drawing.Point(440, 187);
            this.textpencarian.Name = "textpencarian";
            this.textpencarian.Size = new System.Drawing.Size(159, 20);
            this.textpencarian.TabIndex = 20;
            this.textpencarian.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.Location = new System.Drawing.Point(421, 138);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(200, 21);
            this.cbjenis.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "APLIKASI PENJUALAN SODIKIN";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(29, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 57);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Masterbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.textpencarian);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.textharga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.Databarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelt);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtmasuk);
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
        private System.Windows.Forms.DateTimePicker dtmasuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelt;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Databarang;
        private System.Windows.Forms.Label jenis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textharga;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox textpencarian;
        private System.Windows.Forms.ComboBox cbjenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}