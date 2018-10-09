namespace Our_Projekt
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.PrenumereraKnapp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SpelaUppAvsnitt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.VisaPrenumPod = new System.Windows.Forms.Button();
            this.AvPrenumereraKnapp = new System.Windows.Forms.Button();
            this.SpelaUppPrenumPod = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UppdateringsintervallKnapp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VisaTid = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LaggTillKategoriKnapp = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TaBortKategoriKnapp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AndraNamnPaKategoriKnapp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(46, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 584);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 793);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visa avsnitt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(46, 56);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(202, 26);
            this.textBoxURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1417, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1417, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ange minuter mellan 1 - 60";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(997, 390);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(174, 364);
            this.listBox2.TabIndex = 6;
            // 
            // PrenumereraKnapp
            // 
            this.PrenumereraKnapp.Location = new System.Drawing.Point(602, 582);
            this.PrenumereraKnapp.Name = "PrenumereraKnapp";
            this.PrenumereraKnapp.Size = new System.Drawing.Size(170, 43);
            this.PrenumereraKnapp.TabIndex = 7;
            this.PrenumereraKnapp.Text = "Prenumerera";
            this.PrenumereraKnapp.UseVisualStyleBackColor = true;
            this.PrenumereraKnapp.Click += new System.EventHandler(this.PrenumereraKnapp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Namnge podcasten du vill lägga till";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(602, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 9;
            // 
            // SpelaUppAvsnitt
            // 
            this.SpelaUppAvsnitt.Location = new System.Drawing.Point(312, 793);
            this.SpelaUppAvsnitt.Name = "SpelaUppAvsnitt";
            this.SpelaUppAvsnitt.Size = new System.Drawing.Size(169, 62);
            this.SpelaUppAvsnitt.TabIndex = 10;
            this.SpelaUppAvsnitt.Text = "Spela upp avsnitt";
            this.SpelaUppAvsnitt.UseVisualStyleBackColor = true;
            this.SpelaUppAvsnitt.Click += new System.EventHandler(this.SpelaUppAvsnitt_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(1255, 310);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(520, 444);
            this.listBox3.TabIndex = 11;
            this.listBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox3_DrawItem);
            this.listBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseMove);
            // 
            // VisaPrenumPod
            // 
            this.VisaPrenumPod.Location = new System.Drawing.Point(1375, 787);
            this.VisaPrenumPod.Name = "VisaPrenumPod";
            this.VisaPrenumPod.Size = new System.Drawing.Size(291, 62);
            this.VisaPrenumPod.TabIndex = 12;
            this.VisaPrenumPod.Text = "Visa Prenums";
            this.VisaPrenumPod.UseVisualStyleBackColor = true;
            this.VisaPrenumPod.Click += new System.EventHandler(this.VisaPrenumPod_Click);
            // 
            // AvPrenumereraKnapp
            // 
            this.AvPrenumereraKnapp.Location = new System.Drawing.Point(1022, 787);
            this.AvPrenumereraKnapp.Name = "AvPrenumereraKnapp";
            this.AvPrenumereraKnapp.Size = new System.Drawing.Size(126, 62);
            this.AvPrenumereraKnapp.TabIndex = 13;
            this.AvPrenumereraKnapp.Text = "Avprenumerera";
            this.AvPrenumereraKnapp.UseVisualStyleBackColor = true;
            this.AvPrenumereraKnapp.Click += new System.EventHandler(this.AvPrenumereraKnapp_Click);
            // 
            // SpelaUppPrenumPod
            // 
            this.SpelaUppPrenumPod.Location = new System.Drawing.Point(1375, 880);
            this.SpelaUppPrenumPod.Name = "SpelaUppPrenumPod";
            this.SpelaUppPrenumPod.Size = new System.Drawing.Size(291, 62);
            this.SpelaUppPrenumPod.TabIndex = 14;
            this.SpelaUppPrenumPod.Text = "Spela upp avsnitt";
            this.SpelaUppPrenumPod.UseVisualStyleBackColor = true;
            this.SpelaUppPrenumPod.Click += new System.EventHandler(this.SpelaUppPrenumPod_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Uppdatera_Tick);
            // 
            // UppdateringsintervallKnapp
            // 
            this.UppdateringsintervallKnapp.Location = new System.Drawing.Point(1421, 241);
            this.UppdateringsintervallKnapp.Name = "UppdateringsintervallKnapp";
            this.UppdateringsintervallKnapp.Size = new System.Drawing.Size(182, 37);
            this.UppdateringsintervallKnapp.TabIndex = 15;
            this.UppdateringsintervallKnapp.Text = "Uppdateringsintervall";
            this.UppdateringsintervallKnapp.UseVisualStyleBackColor = true;
            this.UppdateringsintervallKnapp.Click += new System.EventHandler(this.UppdateringsintervallKnapp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1669, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // VisaTid
            // 
            this.VisaTid.Tick += new System.EventHandler(this.VisaTid_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(995, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LaggTillKategoriKnapp
            // 
            this.LaggTillKategoriKnapp.Location = new System.Drawing.Point(602, 246);
            this.LaggTillKategoriKnapp.Name = "LaggTillKategoriKnapp";
            this.LaggTillKategoriKnapp.Size = new System.Drawing.Size(170, 39);
            this.LaggTillKategoriKnapp.TabIndex = 18;
            this.LaggTillKategoriKnapp.Text = "Lägg till kategori";
            this.LaggTillKategoriKnapp.UseVisualStyleBackColor = true;
            this.LaggTillKategoriKnapp.Click += new System.EventHandler(this.LaggTillKategoriKnapp_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(602, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 26);
            this.textBox3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Namnge kategori du vill lägga till";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(602, 531);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // TaBortKategoriKnapp
            // 
            this.TaBortKategoriKnapp.Location = new System.Drawing.Point(1022, 880);
            this.TaBortKategoriKnapp.Name = "TaBortKategoriKnapp";
            this.TaBortKategoriKnapp.Size = new System.Drawing.Size(126, 62);
            this.TaBortKategoriKnapp.TabIndex = 22;
            this.TaBortKategoriKnapp.Text = "Ta bort kategori";
            this.TaBortKategoriKnapp.UseVisualStyleBackColor = true;
            this.TaBortKategoriKnapp.Click += new System.EventHandler(this.TaBortKategoriKnapp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Välj kategori att lägga podcasten i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(902, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Här kan du visa podcasts som du prenumererar på";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(995, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Välj kategori";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1294, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(478, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Här kan du ändra uppdateringsintervallen för dina prenumerationer";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(997, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 26);
            this.textBox4.TabIndex = 27;
            // 
            // AndraNamnPaKategoriKnapp
            // 
            this.AndraNamnPaKategoriKnapp.Location = new System.Drawing.Point(997, 172);
            this.AndraNamnPaKategoriKnapp.Name = "AndraNamnPaKategoriKnapp";
            this.AndraNamnPaKategoriKnapp.Size = new System.Drawing.Size(172, 54);
            this.AndraNamnPaKategoriKnapp.TabIndex = 28;
            this.AndraNamnPaKategoriKnapp.Text = "Ändra namn på kategori";
            this.AndraNamnPaKategoriKnapp.UseVisualStyleBackColor = true;
            this.AndraNamnPaKategoriKnapp.Click += new System.EventHandler(this.AndraNamnPaKategoriKnapp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(991, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Skriv in namn du vill ändra till";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(785, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(598, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Här kan du ändra en kategoris namn, välj kategori att ändra på i kategorilistan u" +
    "nder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AndraNamnPaKategoriKnapp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TaBortKategoriKnapp);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LaggTillKategoriKnapp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UppdateringsintervallKnapp);
            this.Controls.Add(this.SpelaUppPrenumPod);
            this.Controls.Add(this.AvPrenumereraKnapp);
            this.Controls.Add(this.VisaPrenumPod);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.SpelaUppAvsnitt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrenumereraKnapp);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button PrenumereraKnapp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SpelaUppAvsnitt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button VisaPrenumPod;
        private System.Windows.Forms.Button AvPrenumereraKnapp;
        private System.Windows.Forms.Button SpelaUppPrenumPod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UppdateringsintervallKnapp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer VisaTid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LaggTillKategoriKnapp;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button TaBortKategoriKnapp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button AndraNamnPaKategoriKnapp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

