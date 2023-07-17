using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Odtwarzacz_czasowy_MP3
{

    public partial class Form1 : Form
    {

        private List<int> czasy = new List<int>();
        private int numer;

        public Form1()
        {
            InitializeComponent();
        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog1.FileName);
                czasy.Add(tbPrzerwa.Value);
            }
            CzasListy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.settings.volume = 10000000;
            CzasListy();
        }

        private void buDodajListę_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.AddRange(openFileDialog1.FileNames);
                for (int j = 0; j < openFileDialog1.FileNames.Length; j++)
                    czasy.Add((int)tbPrzerwa.Value);
            }
            CzasListy();
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                czasy.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            CzasListy();
        }

        private void UsuńWszystko_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CzasListy();
            czasy.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Przyciski();
                timer1.Interval = tbPoczątek.Value * 1000;
                if (cbLosowo.Checked == false)
                {
                    if (listBox1.SelectedIndex >= 0)
                        numer = listBox1.SelectedIndex;
                    else
                        numer = 0;
                }
                else
                {
                    Random los = new Random();
                    numer = los.Next(listBox1.Items.Count);
                }

                timer1.Enabled = true;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = (string)listBox1.Items[0];
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(
            string command,
            StringBuilder returnValue,
            int returnLength,
            IntPtr winHandle);


        public void CzasListy()
        {
            int czas = 0;
            int czas2 = 0;
            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                czas = czas + CzasUtworu((string)listBox1.Items[i]);
            }
            czas2 = czas;
            czas2 += tbPoczątek.Value;
            for (int i = 0; i < czasy.Count - 1; i++)
                czas2 += czasy[i];
            laCzas.Text = "Czas listy: " + (czas / 3600).ToString() + " godzin ";
            laCzasOdtwarzania.Text = "Czas odtwarzania: " + (czas2 / 3600).ToString() + " godzin ";
            while (czas > 3600)
                czas -= 3600;
            while (czas2 > 3600)
                czas2 -= 3600;
            laCzas.Text = laCzas.Text + (czas / 60).ToString() + " minut " + (czas % 60).ToString() + " sekund";
            laCzasOdtwarzania.Text = laCzasOdtwarzania.Text + (czas2 / 60).ToString() + " minut " + (czas2 % 60).ToString() + " sekund";
        }

        public int CzasUtworu(string nazwa)
        {
            MP3Header mh = new MP3Header();
            mh.ReadMP3Information(nazwa);
            return mh.intLength;
        }

        private void buPauza_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timer1.Enabled = false;
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Interval = (CzasUtworu((string)listBox1.Items[numer - 1]) - (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition + czasy[numer - 1]) * 1000;
                timer1.Enabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void tbPoczątek_Scroll(object sender, EventArgs e)
        {
            tePoczątek.Text = tbPoczątek.Value.ToString();
        }

        private void tbPrzerwa_Scroll(object sender, EventArgs e)
        {
            tePrzerwa.Text = tbPrzerwa.Value.ToString(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numer + 1 == listBox1.Items.Count)
                timer1.Interval = CzasUtworu((string)listBox1.Items[numer]) * 1000 + 1000;
            else if (numer >= listBox1.Items.Count)
            {
                timer1.Enabled = false;
                Przyciski();
                return;
            }
            else
                timer1.Interval = (CzasUtworu((string)listBox1.Items[numer]) + czasy[numer]) * 1000;
            axWindowsMediaPlayer1.URL = (string)listBox1.Items[numer];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (cbLosowo.Checked == false)
            {
                numer++;
            }
            else
            {
                Random los = new Random();
                numer = los.Next(listBox1.Items.Count);
            }
        }

        private void buZatrzymaj_Click(object sender, EventArgs e)
        {
            Przyciski();
            timer1.Enabled = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        public void Przyciski()
        {
            buGraj.Enabled = !buGraj.Enabled;
            buPauza.Enabled = !buPauza.Enabled;
            buZatrzymaj.Enabled = !buZatrzymaj.Enabled; 
        }

        private void buInformacje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Jakub Żeżuła. Kopiowanie i rozpowszechnianie zalecane. :) Wszelkie sugestie, problemy i pytania proszę przesyłać na adres kzez1986@poczta.onet.pl.","O programie",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tePoczątek_Leave(object sender, EventArgs e)
        {
            int wynik1, wynik2;
            TextBox tb = new TextBox();
            tb = (TextBox)sender;
            if (!int.TryParse(tePoczątek.Text, out wynik1) || !int.TryParse(tePrzerwa.Text, out wynik2))
            {
                MessageBox.Show("Nieprawidłowa wartość", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
            }
            else
            {
                if (wynik1 < 1 || wynik1 > 3600 || wynik2 < 1 || wynik2 > 3600)
                {
                    MessageBox.Show("Musisz podać liczbę z zakresu od 1 do 3600", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb.Focus();
                }
                else
                {
                    tbPoczątek.Value = wynik1;
                    tbPrzerwa.Value = wynik2;
                }
            }
        }

    }
}
