using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Timers;
using System.Media;


namespace ZderTimer
{
    public partial class Form1 : Form
    {
        public static Zaman zaman = new Zaman();
        int kontrol = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ticker.Stop();
            Ticker.Interval = 100;
            Metin.Text = null;
            MetinKutusu.ForeColor = Color.White;
        }

        private void SesCal(bool flip)
        {
            SoundPlayer ses = new SoundPlayer(@"C:\Users\ZderWindows\Music\timer.wav");
            if (flip)
                ses.Play();
            else
                ses.Stop();
        }

        private void MetinKutusu_Click(object sender, EventArgs e)
        {
            MetinKutusu.Text = null;
        }

        private void MetinKutusu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Baslat_Click(this, new EventArgs());
            }
        }

        private void Baslat_Click(object sender, EventArgs e)
        {
            if (kontrol == 0)
            {
                kontrol = 1;
                zaman = zaman.Hesapla(MetinKutusu.Text);
                Baslat.Text = "Durdur";
                MetinKutusu.Text = null;
                SesCal(false);
                Ticker.Start();
            }
            else
            {
                kontrol = 0;
                Baslat.Text = "Başlat";
                Ticker.Stop();
                SesCal(false);
            }
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            if (zaman.saniye == -2)
                Metin.Text = String.Format("{0}", DateTime.Parse(DateTime.Now.ToString()).Subtract(DateTime.Parse(zaman.vakit.ToString())));
            else if (kontrol == 1 && zaman.vakit.ToString() == DateTime.Now.ToString())
            {
                SesCal(true);
                kontrol = 0;
                Baslat.Text = "Başlat";
                
                Metin.Text = null; 
                Ticker.Stop();
            }
            else
                Metin.Text = String.Format("{0}", DateTime.Parse(DateTime.Now.ToString()).Subtract(DateTime.Parse(zaman.vakit.ToString()))).Substring(1);
        }

        private void MetinKutusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
            */
        }
    }
    public class Zaman
    {
        public int saat;
        public int dakika;
        public int saniye;
        public DateTime vakit = new DateTime();
        
        public Zaman Hesapla(string metin)
        {
            Zaman zaman = new Zaman();
            zaman.vakit = DateTime.Now;
            
            if (metin.Length != 0) //key press te kontrol ettirki : ve numaralar dışın yazmasın
            {
                if (metin.Substring(0, 1) == "*")
                {
                    metin = metin.Substring(1);
                    switch (metin.Split(':').Length - 1)
                    {
                        case 0:
                            if (metin.Length == 1)
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 2));
                            zaman.dakika = 0;
                            zaman.saniye = 0;
                            break;
                        case 1:
                            if (metin.IndexOf(':') == 1)
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 2));
                            metin = metin.Substring(metin.IndexOf(":") + 1);
                            if (metin.Length == 1)
                                zaman.dakika = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.dakika = Convert.ToInt32(metin.Substring(0, 2));
                            zaman.saniye = 0;
                            break;
                        case 2:
                            if (metin.IndexOf(':') == 1)
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.saat = Convert.ToInt32(metin.Substring(0, 2));
                            metin = metin.Substring(metin.IndexOf(":") + 1);
                            if (metin.IndexOf(':') == 1)
                                zaman.dakika = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.dakika = Convert.ToInt32(metin.Substring(0, 2));
                            metin = metin.Substring(metin.IndexOf(":") + 1);
                            if (metin.Length == 1)
                                zaman.saniye = Convert.ToInt32(metin.Substring(0, 1));
                            else
                                zaman.saniye = Convert.ToInt32(metin.Substring(0, 2));
                            break;
                        default:
                            zaman.saat = -1;
                            zaman.dakika = -1;
                            zaman.saniye = -1;
                            break;
                    }
                    zaman.vakit = new DateTime(zaman.vakit.Year, zaman.vakit.Month, zaman.vakit.Day, zaman.saat, zaman.dakika, zaman.saniye);
                }
                else if (metin.Last() == 'h')
                {
                    zaman.vakit = zaman.vakit.AddHours(Convert.ToInt32(metin.Remove(metin.Length - 1)));
                }
                else if (metin.Last() == 'm')
                {
                    zaman.vakit = zaman.vakit.AddMinutes(Convert.ToInt32(metin.Remove(metin.Length - 1)));
                }
                else if (metin.Last() == 's')
                {
                    zaman.vakit = zaman.vakit.AddSeconds(Convert.ToInt32(metin.Remove(metin.Length - 1)));
                }
                else if (metin == "sw")
                {
                    zaman.saniye = -2;
                }
            }
            return zaman;
        }
    }

    
}
