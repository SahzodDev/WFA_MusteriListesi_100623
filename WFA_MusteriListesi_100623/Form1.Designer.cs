namespace WFA_MusteriListesi_100623
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            nudYas = new NumericUpDown();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            btnListe = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Telefon :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 119);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 2;
            label3.Text = "Yaş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 163);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Adres :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(134, 29);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(216, 27);
            txtAd.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(134, 73);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(216, 27);
            txtTelefon.TabIndex = 5;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(134, 121);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(216, 27);
            nudYas.TabIndex = 6;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(134, 163);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(216, 81);
            txtAdres.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(134, 250);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(216, 50);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListe
            // 
            btnListe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnListe.Location = new Point(134, 306);
            btnListe.Name = "btnListe";
            btnListe.Size = new Size(216, 50);
            btnListe.TabIndex = 9;
            btnListe.Text = "Listeye Dön";
            btnListe.UseVisualStyleBackColor = true;
            btnListe.Click += btnListe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 378);
            Controls.Add(btnListe);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(nudYas);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private NumericUpDown nudYas;
        private TextBox txtAdres;
        private Button btnKaydet;
        private Button btnListe;
    }
}