using System;
using System.Drawing; // Point'i kullanmak için gerekli kütüphane.
using System.IO; // Dosya okuması için gerekli kütüphane.
using System.Linq; // Label bulmak için gerekli kütüphane.
using System.Net; // İnternete bağlanması için gerekli kütüphane.
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class KelimeOyunu : Form
    {
        Random rastgele = new Random(); // Random nesnesini tanımlar.

        public KelimeOyunu()
        {
            InitializeComponent();

            // Labellerı picturebox'ın üstüne yerleştiriyorum.
            label0.Parent = pictureBox0;
            label0.BringToFront();
            label0.Location = new Point(11, 11);

            label1.Parent = pictureBox1;
            label1.BringToFront();
            label1.Location = new Point(11, 11);

            label2.Parent = pictureBox2;
            label2.BringToFront();
            label2.Location = new Point(11, 11);

            label3.Parent = pictureBox3;
            label3.BringToFront();
            label3.Location = new Point(11, 11);

            label4.Parent = pictureBox4;
            label4.BringToFront();
            label4.Location = new Point(11, 11);

            label5.Parent = pictureBox5;
            label5.BringToFront();
            label5.Location = new Point(11, 11);

            label6.Parent = pictureBox6;
            label6.BringToFront();
            label6.Location = new Point(11, 11);

            label7.Parent = pictureBox7;
            label7.BringToFront();
            label7.Location = new Point(11, 11);

            label8.Parent = pictureBox8;
            label8.BringToFront();
            label8.Location = new Point(11, 11);

            label9.Parent = pictureBox9;
            label9.BringToFront();
            label9.Location = new Point(11, 11);

        }

        #region Değişkenleri tanımladığım bölge
        string[] kelimeler = new string[14]; // Kelimeler için on dört elemanlı bir dizi tanımlar.

        string[] kelimeleranlam = new string[14]; // Kelimelerin anlamları için on dört elemanlı bir dizi tanımlar.

        char[] kelimeharfler; // Kelimeleri harflere bölmek için char dizileri.

        int soru = 0;
        int puan = 0;
        int sure = 180;
        int sureyidurdursaniye = 0;

        int[] soruhak = new int[14];
        double yarim = -0.5;
        #endregion

        private void textBoxCevap_TextChanged(object sender, EventArgs e)
        {
            // Doğru cevap verildiğinde sonraki soruya geçer.
            if (soru == 0)
            {
                // Girilen kelime doğru mu diye kontrol eder.
                if (kelimeler[0] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 1)
            {
                if (kelimeler[1] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox4.Visible = true;
                }
            }
            else if (soru == 2)
            {
                if (kelimeler[2] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 3)
            {
                if (kelimeler[3] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox5.Visible = true;
                }
            }
            else if (soru == 4)
            {
                if (kelimeler[4] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 5)
            {
                if (kelimeler[5] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox6.Visible = true;
                }
            }
            else if (soru == 6)
            {
                if (kelimeler[6] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 7)
            {
                if (kelimeler[7] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox7.Visible = true;
                }
            }
            else if (soru == 8)
            {
                if (kelimeler[8] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 9)
            {
                if (kelimeler[9] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox8.Visible = true;
                }
            }
            else if (soru == 10)
            {
                if (kelimeler[10] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 11)
            {
                if (kelimeler[11] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                    pictureBox9.Visible = true;
                }
            }
            else if (soru == 12)
            {
                if (kelimeler[12] == textBoxCevap.Text.ToLower())
                {
                    soru++;
                    labelSoru.Text = "Soru: " + (soru + 1);
                    textBoxSoru.Text = kelimeleranlam[soru];

                    DogruCevap();
                    PuanAyarla();
                }
            }
            else if (soru == 13)
            {
                if (kelimeler[13] == textBoxCevap.Text.ToLower())
                {
                    DogruCevap();
                    soru++;
                    PuanAyarla();
                    timerSure.Stop();

                    MessageBox.Show("Tebrikler! \r" + "Puanınız: " + puan);
                    Application.Restart();
                }
            }
        }

        private void buttonHarfAl_Click(object sender, EventArgs e)
        {
            if (soru == 0 && soruhak[0] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 4); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[0]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[0]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[0]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[0]--;
                        break;
                    }
                }
            } // Soru 1 | 4 Harf
            else if (soru == 1 && soruhak[1] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 4); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[1]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[1]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[1]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[1]--;
                        break;
                    }
                }
            } // Soru 2 | 4 Harf
            else if (soru == 2 && soruhak[2] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 5); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[2]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[2]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[2]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[2]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[2]--;
                        break;
                    }
                }
            } // Soru 3 | 5 Harf
            else if (soru == 3 && soruhak[3] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 5); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[3]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[3]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[3]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[3]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[3]--;
                        break;
                    }
                }
            } // Soru 4 | 5 Harf
            else if (soru == 4 && soruhak[4] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 6); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[4]--;
                        break;
                    }
                }
            } // Soru 5 | 6 Harf
            else if (soru == 5 && soruhak[5] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 6); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[5]--;
                        break;
                    }
                }
            } // Soru 6 | 6 Harf
            else if (soru == 6 && soruhak[6] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 7); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[6]--;
                        break;
                    }
                }
            } // Soru 7 | 7 Harf
            else if (soru == 7 && soruhak[7] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 7); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[7]--;
                        break;
                    }
                }
            } // Soru 8 | 7 Harf
            else if (soru == 8 && soruhak[8] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 8); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[8]--;
                        break;
                    }
                }
            } // Soru 9 | 8 Harf
            else if (soru == 9 && soruhak[9] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 8); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[9]--;
                        break;
                    }
                }
            } // Soru 10 | 8 Harf
            else if (soru == 10 && soruhak[10] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 9); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                    else if (harfal == 8 && !label8.Visible)
                    {
                        label8.Visible = true;
                        soruhak[10]--;
                        break;
                    }
                }
            } // Soru 11 | 9 Harf
            else if (soru == 11 && soruhak[11] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 9); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                    else if (harfal == 8 && !label8.Visible)
                    {
                        label8.Visible = true;
                        soruhak[11]--;
                        break;
                    }
                }
            } // Soru 12 | 9 Harf
            else if (soru == 12 && soruhak[12] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 10); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 8 && !label8.Visible)
                    {
                        label8.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                    else if (harfal == 9 && !label9.Visible)
                    {
                        label9.Visible = true;
                        soruhak[12]--;
                        break;
                    }
                }
            } // Soru 13 | 10 Harf
            else if (soru == 13 && soruhak[13] > 1)
            {
                // Eğer label görünür değil ise görünür yapar.
                for (; ; )
                {
                    int harfal = rastgele.Next(0, 10); // Rastgele sayı seçer.

                    if (harfal == 0 && !label0.Visible)
                    {
                        label0.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 1 && !label1.Visible)
                    {
                        label1.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 2 && !label2.Visible)
                    {
                        label2.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 3 && !label3.Visible)
                    {
                        label3.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 4 && !label4.Visible)
                    {
                        label4.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 5 && !label5.Visible)
                    {
                        label5.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 6 && !label6.Visible)
                    {
                        label6.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 7 && !label7.Visible)
                    {
                        label7.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 8 && !label8.Visible)
                    {
                        label8.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                    else if (harfal == 9 && !label9.Visible)
                    {
                        label9.Visible = true;
                        soruhak[13]--;
                        break;
                    }
                }
            } // Soru 14 | 10 Harf
        }

        private void buttonSureyiDurdur_Click(object sender, EventArgs e)
        {
            buttonSureyiDurdur.Enabled = false;
            buttonHarfAl.Enabled = false;
            textBoxCevap.ReadOnly = false;

            timerSure.Stop();
            timerSureyiDurdur.Start();
        }

        private void buttonOyunuBaslat_Click(object sender, EventArgs e)
        {
            buttonOyunuBaslat.Visible = false;
            buttonHarfAl.Visible = true;
            buttonSureyiDurdur.Visible = true;

            kelimeharfler = kelimeler[soru].ToCharArray();
            textBoxSoru.Text = kelimeleranlam[0];
            labelSoru.Text = "Soru: 1";

            timerSure.Start();
        }

        private void KelimeOyunu_Load(object sender, EventArgs e)
        {
            // Form açıldığında gerekli ayarları yapar.
            KelimeleriSec();
            KelimeAnlamSec();
            KelimeHarfAyarla();
            SoruHakAyarla();
        }

        private void timerSure_Tick(object sender, EventArgs e)
        {
            // Süreyi saniyede bir azaltıp değerini label'a yazdırıyor.
            sure--;
            if (sure == 0)
            {
                timerSure.Stop();
                MessageBox.Show("Oyun bitti! \n Puanınız: " + puan, "Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sure % 60 < 10)
                {
                    int dakika = sure / 60;
                    int saniye = sure % 60;
                    string saniyeondankucuk = "0" + saniye;
                    labelSure.Text = "Süre: " + dakika + ":" + saniyeondankucuk;
                }
                else
                {
                    int dakika = sure / 60;
                    int saniye = sure % 60;
                    labelSure.Text = "Süre: " + dakika + ":" + saniye;
                }
            }
        }

        private void timerSureyiDurdur_Tick(object sender, EventArgs e)
        {
            // Süreyi durdur butonuna basıldıktan sonra aktifleşir.
            sureyidurdursaniye++;
            if (sureyidurdursaniye == 30)
            {
                // Eğer süre dolarsa uyarı verir, - puan ekler.
                timerSureyiDurdur.Stop();
                sureyidurdursaniye = 0;
                MessageBox.Show("Süreniz doldu! \n Kelime: " + label0.Text + label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text + label7.Text + label8.Text + label9.Text);

                if (soru == 0 || soru == 1)
                {
                    if (soru == 0)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox4.Visible = true;
                    }
                    puan = puan - 400;
                }
                else if (soru == 2 || soru == 3)
                {
                    if (soru == 2)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox5.Visible = true;
                    }
                    puan = puan - 500;
                }
                else if (soru == 4 || soru == 5)
                {
                    if (soru == 4)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox6.Visible = true;
                    }
                    puan = puan - 600;
                }
                else if (soru == 6 || soru == 7)
                {
                    if (soru == 6)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox7.Visible = true;
                    }
                    puan = puan - 700;
                }
                else if (soru == 8 || soru == 9)
                {
                    if (soru == 8)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox8.Visible = true;
                    }
                    puan = puan - 800;
                }
                else if (soru == 10 || soru == 11)
                {
                    if (soru == 10)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                        pictureBox9.Visible = true;
                    }
                    puan = puan - 900;
                }
                else if (soru == 12 || soru == 13)
                {
                    if (soru == 10)
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    else
                    {
                        labelSoru.Text = "Soru: " + (soru + 2);
                        textBoxSoru.Text = kelimeleranlam[soru + 1];
                    }
                    puan = puan - 1000;
                }
                labelPuan.Text = "Puan: " + puan;
                soru++;
                DogruCevap();
            }
        }

        // Metot bölümü
        private void KelimeleriSec()
        {
            // kelimeler.txt dosyasını okuyup diziye kaydeder. Daha sonra bu diziden rastgele kelimeler çeker.
            TextReader tReader = new StreamReader("kelimeler.txt");
            string okunan = tReader.ReadToEnd();
            string[] satirlar = okunan.Split('\r');
            tReader.Close();

            for (int i = 0; i < 14; i++)
            {
                if (i == 0)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 4)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 1 | 4 harf
                else if (i == 1)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 4)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 2 | 4 harf
                else if (i == 2)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 5)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 3 | 5 harf
                else if (i == 3)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 5)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 4 | 5 harf
                else if (i == 4)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 6)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 5 | 6 harf
                else if (i == 5)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 6)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 6 | 6 harf
                else if (i == 6)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 7)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 7 | 7 harf
                else if (i == 7)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 7)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 8 | 7 harf
                else if (i == 8)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 8)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 9 | 8 harf
                else if (i == 9)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 8)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 10 | 8 harf
                else if (i == 10)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 9)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 11 | 9 harf
                else if (i == 11)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 9)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 12 | 9 harf
                else if (i == 12)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 10)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 13 | 10 harf
                else if (i == 13)
                {
                    for (; ; )
                    {
                        int rastgelesayi = rastgele.Next(0, satirlar.Length);
                        string secilenkelime = satirlar[rastgelesayi];
                        if (secilenkelime.Length == 10)
                        {
                            kelimeler[i] = secilenkelime;
                            break;
                        }
                    }
                } // Kelime 14 | 10 harf
            }
        }
        private void KelimeAnlamSec()
        {
            for (int i = 0; i < 14; i++)
            {
                // sozluk.gov.tr apisini kullanarak girilen kelimenin anlamını bulur.
                string adres = "https://sozluk.gov.tr/gts?ara=" + kelimeler[i];
                WebRequest istek = HttpWebRequest.Create(adres);
                WebResponse cevap;
                cevap = istek.GetResponse();
                StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
                string gelen = donenbilgiler.ReadToEnd();
                int kelimeanlam = gelen.IndexOf("\"anlam\"") + 9;
                int kelimeanlambitis = gelen.Substring(kelimeanlam).IndexOf("\"");
                string anlam = gelen.Substring(kelimeanlam, kelimeanlambitis);

                // Döngü her döndüğünde kelimelere anlamlarını yazdırır.
                kelimeleranlam[i] = anlam;
            }
        }
        private void KelimeHarfAyarla()
        {
            // Kelimeleri harflere bölüp label'a yazdırır.
            kelimeharfler = kelimeler[soru].ToCharArray();

            try
            {
                for (int i = 0; i < 14; i++)
                {
                    Label lbl = this.Controls.Find("label" + i, true).FirstOrDefault() as Label;
                    lbl.Text = kelimeharfler[i].ToString().ToUpper();
                }
            }
            catch { }
        }
        private void DogruCevap()
        {
            KelimeHarfAyarla();

            // Doğru cevap verildiğinde kontrolleri eski haline çevirir.
            label0.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            textBoxCevap.Clear();
            textBoxCevap.ReadOnly = true;
            buttonHarfAl.Enabled = true;
            buttonSureyiDurdur.Enabled = true;
            timerSure.Start();
            timerSureyiDurdur.Stop();
            sureyidurdursaniye = 0;
        }
        private void SoruHakAyarla()
        {
            // Soru harf alma haklarını ayarlar.
            for (int i = 0; i < 14; i++)
            {
                yarim += 0.5;
                soruhak[i] = Convert.ToInt16(Math.Floor(4 + yarim));
            }
        }
        private void PuanAyarla()
        {
            // Doğru cevap verildiğinde puan label'ını günceller.
            int puanayarla = soruhak[soru - 1];
            puan = puan + puanayarla * 100;
            labelPuan.Text = "Puan: " + puan;
        }

        private void KelimeOyunu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

/*
 * Yazılıma başlayalı yaklaşık 2 ay oluyor ve şimdiye kadar ki en çok uğraştığım proje, bu proje oldu.
 * Daha öncesinde aynı projeyi bir kere daha yazdım ve yaklaşık 2000 satır oldu.
 * Fakat istediğim şekilde çalışmadı, bir sürü hata vs. aldım.
 * Biraz inatçı olduğum için sıfırdan tekrar yapma kararı verdim ve bugün bu projeyi sonlandırıyorum.
 * Bunları buraya yazıyorum çünkü gerçekten bu projeyi yaparken çok yoruldum ve saatlerimi harcadım.
 * Kodlarda muhtemelen çok fazla hatam ve gereksiz uzunluk var.
 * İleride bu projeye baktığım zaman mutlu olacağıma inanıyorum.
 * Elimden geldiğince projeyi açıklamaya çalıştım yanlış bilgi verdiysem şimdiden kusura bakmayın.
 * -Mali (10:04 19.03.2022)
 */
