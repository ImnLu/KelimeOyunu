using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class KelimeIndir : Form
    {
        public KelimeIndir()
        {
            InitializeComponent();
        }

        WebClient client;

        private void KelimeIndir_Load(object sender, EventArgs e)
        {
            this.Activated += KelimeIndir_Activated;
        }

        private void KelimeIndir_Activated(object sender, EventArgs e)
        {
            this.Hide();
            if (!File.Exists("kelimeler.txt"))
            {
                //Eğer internet varsa indirmeye başlıyor.
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    this.Show();
                    //Dosya indiren sistem.
                    client = new WebClient();
                    client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;

                    string url = "https://cdn.discordapp.com/attachments/405403798299869185/954641707234897940/kelimeler.txt";
                    Thread thread = new Thread(() =>
                    {
                        Uri uri = new Uri(url);
                        client.DownloadFileAsync(uri, Application.StartupPath + "/" + "kelimeler.txt");
                    });
                    thread.Start();
                }

                //Eğer internet yoksa hata veriyor.
                else
                {
                    MessageBox.Show("İnternet bağlantınızı kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                KelimeOyunu kelimeOyunu = new KelimeOyunu();
                this.Hide();
                kelimeOyunu.Show();
            }
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Application.Restart();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                //İlerleme çubuğuyla senkronize çalışan sistem.
                progressBar.Minimum = 0;
                double alinanveri = double.Parse(e.BytesReceived.ToString());
                double toplam = double.Parse(e.TotalBytesToReceive.ToString());
                double yuzdelikoran = alinanveri / toplam * 100;
                progressBar.Value = int.Parse(Math.Truncate(yuzdelikoran).ToString());
            }));
        }
    }
}

