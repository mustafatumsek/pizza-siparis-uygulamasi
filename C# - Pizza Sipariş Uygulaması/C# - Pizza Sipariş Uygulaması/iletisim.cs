using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void picKonum_Click(object sender, EventArgs e)
        {
            string url = "www.google.com/maps/@39.7786895,30.5154271,19.75z?entry=ttu;";
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                    && !char.IsSeparator(e.KeyChar);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length == 0 || txtEposta.Text.Length == 0 || txtMesaj.Text.Length == 0) { MessageBox.Show("'*' ile belirtilen alanların doldurulması zorunludur.", "Uyarı"); }
            else
            {
                txtAd.Clear();
                txtSoyad.Clear();
                txtEposta.Clear();
                txtMesaj.Clear();
                MessageBox.Show("Bizimle iletişime geçtiğiniz için teşekkür ederiz. En kısa zaman içerisinde vermiş olduğunuz mail adresine dönüş yapılacaktır.", "Gönderildi");
            }
        }

        private void lblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("www.bavyerapizza.com;");
            string url = "www.bavyerapizza.com";
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void lblAdres_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblAdres.Text);
            MessageBox.Show("Adres kopyalandı.", "Adres");
        }

        private void lblTelefon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblTelefon.Text);
            MessageBox.Show("Telefon numarası kopyalandı.", "Telefon");
        }
    }
}
