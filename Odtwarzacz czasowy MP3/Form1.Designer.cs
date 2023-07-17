namespace Odtwarzacz_czasowy_MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buDodaj = new System.Windows.Forms.Button();
            this.buDodajListę = new System.Windows.Forms.Button();
            this.buUsuń = new System.Windows.Forms.Button();
            this.buUsuńWszystko = new System.Windows.Forms.Button();
            this.buGraj = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.laCzas = new System.Windows.Forms.Label();
            this.tbPoczątek = new System.Windows.Forms.TrackBar();
            this.cbLosowo = new System.Windows.Forms.CheckBox();
            this.tePoczątek = new System.Windows.Forms.TextBox();
            this.tbPrzerwa = new System.Windows.Forms.TrackBar();
            this.tePrzerwa = new System.Windows.Forms.TextBox();
            this.buZatrzymaj = new System.Windows.Forms.Button();
            this.buInformacje = new System.Windows.Forms.Button();
            this.buPauza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.laCzasOdtwarzania = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoczątek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrzerwa)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(107, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 225);
            this.listBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Muzyka|*.mp3";
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(307, 233);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(75, 23);
            this.buDodaj.TabIndex = 1;
            this.buDodaj.Text = "Dodaj plik";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // buDodajListę
            // 
            this.buDodajListę.Location = new System.Drawing.Point(388, 233);
            this.buDodajListę.Name = "buDodajListę";
            this.buDodajListę.Size = new System.Drawing.Size(75, 23);
            this.buDodajListę.TabIndex = 2;
            this.buDodajListę.Text = "Dodaj listę";
            this.buDodajListę.UseVisualStyleBackColor = true;
            this.buDodajListę.Click += new System.EventHandler(this.buDodajListę_Click);
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(469, 233);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(129, 23);
            this.buUsuń.TabIndex = 3;
            this.buUsuń.Text = "Usuń pojedynczy";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // buUsuńWszystko
            // 
            this.buUsuńWszystko.Location = new System.Drawing.Point(604, 233);
            this.buUsuńWszystko.Name = "buUsuńWszystko";
            this.buUsuńWszystko.Size = new System.Drawing.Size(129, 23);
            this.buUsuńWszystko.TabIndex = 4;
            this.buUsuńWszystko.Text = "Usuń wszystko";
            this.buUsuńWszystko.UseVisualStyleBackColor = true;
            this.buUsuńWszystko.Click += new System.EventHandler(this.UsuńWszystko_Click);
            // 
            // buGraj
            // 
            this.buGraj.Location = new System.Drawing.Point(3, 12);
            this.buGraj.Name = "buGraj";
            this.buGraj.Size = new System.Drawing.Size(98, 23);
            this.buGraj.TabIndex = 5;
            this.buGraj.Text = "Graj";
            this.buGraj.UseVisualStyleBackColor = true;
            this.buGraj.Click += new System.EventHandler(this.button3_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(503, 272);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(217, 26);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Czas w sekundach przed pierwszym utworem:";
            // 
            // laCzas
            // 
            this.laCzas.AutoSize = true;
            this.laCzas.Location = new System.Drawing.Point(0, 229);
            this.laCzas.Name = "laCzas";
            this.laCzas.Size = new System.Drawing.Size(53, 13);
            this.laCzas.TabIndex = 9;
            this.laCzas.Text = "Czas listy:";
            // 
            // tbPoczątek
            // 
            this.tbPoczątek.Location = new System.Drawing.Point(3, 304);
            this.tbPoczątek.Maximum = 3600;
            this.tbPoczątek.Minimum = 1;
            this.tbPoczątek.Name = "tbPoczątek";
            this.tbPoczątek.Size = new System.Drawing.Size(582, 42);
            this.tbPoczątek.TabIndex = 10;
            this.tbPoczątek.Value = 1;
            this.tbPoczątek.Scroll += new System.EventHandler(this.tbPoczątek_Scroll);
            // 
            // cbLosowo
            // 
            this.cbLosowo.AutoSize = true;
            this.cbLosowo.Location = new System.Drawing.Point(3, 170);
            this.cbLosowo.Name = "cbLosowo";
            this.cbLosowo.Size = new System.Drawing.Size(63, 17);
            this.cbLosowo.TabIndex = 11;
            this.cbLosowo.Text = "Losowo";
            this.cbLosowo.UseVisualStyleBackColor = true;
            // 
            // tePoczątek
            // 
            this.tePoczątek.Location = new System.Drawing.Point(604, 316);
            this.tePoczątek.Name = "tePoczątek";
            this.tePoczątek.Size = new System.Drawing.Size(100, 20);
            this.tePoczątek.TabIndex = 12;
            this.tePoczątek.Text = "1";
            this.tePoczątek.Leave += new System.EventHandler(this.tePoczątek_Leave);
            // 
            // tbPrzerwa
            // 
            this.tbPrzerwa.Location = new System.Drawing.Point(3, 353);
            this.tbPrzerwa.Maximum = 3600;
            this.tbPrzerwa.Minimum = 1;
            this.tbPrzerwa.Name = "tbPrzerwa";
            this.tbPrzerwa.Size = new System.Drawing.Size(582, 42);
            this.tbPrzerwa.TabIndex = 13;
            this.tbPrzerwa.Value = 1;
            this.tbPrzerwa.Scroll += new System.EventHandler(this.tbPrzerwa_Scroll);
            // 
            // tePrzerwa
            // 
            this.tePrzerwa.Location = new System.Drawing.Point(604, 368);
            this.tePrzerwa.Name = "tePrzerwa";
            this.tePrzerwa.Size = new System.Drawing.Size(100, 20);
            this.tePrzerwa.TabIndex = 14;
            this.tePrzerwa.Text = "1";
            this.tePrzerwa.Leave += new System.EventHandler(this.tePoczątek_Leave);
            // 
            // buZatrzymaj
            // 
            this.buZatrzymaj.Enabled = false;
            this.buZatrzymaj.Location = new System.Drawing.Point(3, 90);
            this.buZatrzymaj.Name = "buZatrzymaj";
            this.buZatrzymaj.Size = new System.Drawing.Size(98, 23);
            this.buZatrzymaj.TabIndex = 16;
            this.buZatrzymaj.Text = "Zatrzymaj";
            this.buZatrzymaj.UseVisualStyleBackColor = true;
            this.buZatrzymaj.Click += new System.EventHandler(this.buZatrzymaj_Click);
            // 
            // buInformacje
            // 
            this.buInformacje.Location = new System.Drawing.Point(3, 130);
            this.buInformacje.Name = "buInformacje";
            this.buInformacje.Size = new System.Drawing.Size(98, 23);
            this.buInformacje.TabIndex = 17;
            this.buInformacje.Text = "Informacje";
            this.buInformacje.UseVisualStyleBackColor = true;
            this.buInformacje.Click += new System.EventHandler(this.buInformacje_Click);
            // 
            // buPauza
            // 
            this.buPauza.Enabled = false;
            this.buPauza.Location = new System.Drawing.Point(3, 51);
            this.buPauza.Name = "buPauza";
            this.buPauza.Size = new System.Drawing.Size(98, 23);
            this.buPauza.TabIndex = 18;
            this.buPauza.Text = "Pauza / Wznów";
            this.buPauza.UseVisualStyleBackColor = true;
            this.buPauza.Click += new System.EventHandler(this.buPauza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Przerwa w sekundach pomiędzy utworem następnie dodanym, a kolejnym:";
            // 
            // laCzasOdtwarzania
            // 
            this.laCzasOdtwarzania.AutoSize = true;
            this.laCzasOdtwarzania.Location = new System.Drawing.Point(0, 255);
            this.laCzasOdtwarzania.Name = "laCzasOdtwarzania";
            this.laCzasOdtwarzania.Size = new System.Drawing.Size(93, 13);
            this.laCzasOdtwarzania.TabIndex = 20;
            this.laCzasOdtwarzania.Text = "Czas odtwarzania:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 393);
            this.Controls.Add(this.laCzasOdtwarzania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buPauza);
            this.Controls.Add(this.buInformacje);
            this.Controls.Add(this.buZatrzymaj);
            this.Controls.Add(this.tePrzerwa);
            this.Controls.Add(this.tbPrzerwa);
            this.Controls.Add(this.tePoczątek);
            this.Controls.Add(this.cbLosowo);
            this.Controls.Add(this.tbPoczątek);
            this.Controls.Add(this.laCzas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buGraj);
            this.Controls.Add(this.buUsuńWszystko);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.buDodajListę);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Odtwarzacz czasowy MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoczątek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrzerwa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.Button buDodajListę;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.Button buUsuńWszystko;
        private System.Windows.Forms.Button buGraj;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laCzas;
        private System.Windows.Forms.TrackBar tbPoczątek;
        private System.Windows.Forms.CheckBox cbLosowo;
        private System.Windows.Forms.TextBox tePoczątek;
        private System.Windows.Forms.TrackBar tbPrzerwa;
        private System.Windows.Forms.TextBox tePrzerwa;
        private System.Windows.Forms.Button buZatrzymaj;
        private System.Windows.Forms.Button buInformacje;
        private System.Windows.Forms.Button buPauza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laCzasOdtwarzania;
        private System.Windows.Forms.Timer timer1;
    }
}

