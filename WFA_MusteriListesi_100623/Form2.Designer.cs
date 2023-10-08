namespace WFA_MusteriListesi_100623
{
    partial class Form2
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
            lstMusteri = new ListBox();
            btnMusteriEkle = new Button();
            SuspendLayout();
            // 
            // lstMusteri
            // 
            lstMusteri.FormattingEnabled = true;
            lstMusteri.ItemHeight = 20;
            lstMusteri.Location = new Point(12, 12);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(342, 304);
            lstMusteri.TabIndex = 0;
            lstMusteri.DoubleClick += lstMusteri_DoubleClick;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriEkle.Location = new Point(69, 322);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(223, 58);
            btnMusteriEkle.TabIndex = 1;
            btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 411);
            Controls.Add(btnMusteriEkle);
            Controls.Add(lstMusteri);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMusteri;
        private Button btnMusteriEkle;
    }
}