namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.azonosito = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.kesz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.varosok = new System.Windows.Forms.ComboBox();
            this.nyelvbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosító:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // azonosito
            // 
            this.azonosito.Location = new System.Drawing.Point(172, 55);
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(100, 20);
            this.azonosito.TabIndex = 2;
            this.azonosito.ValueChanged += new System.EventHandler(this.azonosito_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(172, 86);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 4;
            this.nev.TextChanged += new System.EventHandler(this.nev_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nyelv:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési év:";
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(172, 147);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(100, 20);
            this.datum.TabIndex = 7;
            // 
            // kesz
            // 
            this.kesz.Location = new System.Drawing.Point(141, 220);
            this.kesz.Name = "kesz";
            this.kesz.Size = new System.Drawing.Size(75, 23);
            this.kesz.TabIndex = 8;
            this.kesz.Text = "kész";
            this.kesz.UseVisualStyleBackColor = true;
            this.kesz.Click += new System.EventHandler(this.kesz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Születési hely:";
            // 
            // varosok
            // 
            this.varosok.FormattingEnabled = true;
            this.varosok.Items.AddRange(new object[] {
            "Debrecen",
            "Budapest",
            "Hajdúböszörmény",
            "Gyál",
            "Fót"});
            this.varosok.Location = new System.Drawing.Point(172, 178);
            this.varosok.Name = "varosok";
            this.varosok.Size = new System.Drawing.Size(100, 21);
            this.varosok.TabIndex = 11;
            // 
            // nyelvbox
            // 
            this.nyelvbox.FormattingEnabled = true;
            this.nyelvbox.Items.AddRange(new object[] {
            "angol",
            "német",
            "francia",
            "olasz "});
            this.nyelvbox.Location = new System.Drawing.Point(172, 120);
            this.nyelvbox.Name = "nyelvbox";
            this.nyelvbox.Size = new System.Drawing.Size(100, 21);
            this.nyelvbox.TabIndex = 12;
            this.nyelvbox.SelectedIndexChanged += new System.EventHandler(this.nyelvbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.nyelvbox);
            this.Controls.Add(this.varosok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kesz);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.azonosito);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown azonosito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button kesz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox varosok;
        private System.Windows.Forms.ComboBox nyelvbox;
    }
}

