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
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.dtmasuk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btsend = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelt = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Databarang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Databarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT Transaksi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total :";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(125, 20);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 20);
            this.textID.TabIndex = 4;
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(125, 54);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(200, 20);
            this.textnama.TabIndex = 5;
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.Location = new System.Drawing.Point(125, 92);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(200, 21);
            this.cbjenis.TabIndex = 6;
            // 
            // dtmasuk
            // 
            this.dtmasuk.Location = new System.Drawing.Point(125, 133);
            this.dtmasuk.Name = "dtmasuk";
            this.dtmasuk.Size = new System.Drawing.Size(200, 20);
            this.dtmasuk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga :";
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
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(366, 20);
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
            this.Databarang.Size = new System.Drawing.Size(579, 170);
            this.Databarang.TabIndex = 15;
            // 
            // Masterbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 388);
            this.Controls.Add(this.Databarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelt);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtmasuk);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Masterbarang";
            this.Text = "Transaksi";
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
        private System.Windows.Forms.ComboBox cbjenis;
        private System.Windows.Forms.DateTimePicker dtmasuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelt;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Databarang;
    }
}