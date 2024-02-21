using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int balance = 1000, total = 0, oyuncuKartToplam = 0, casinoKartToplam = 0;
		yuvarlakbutton button1 = new yuvarlakbutton();
		yuvarlakbutton button2 = new yuvarlakbutton();
		yuvarlakbutton button3 = new yuvarlakbutton();
		yuvarlakbutton button4 = new yuvarlakbutton();
		yuvarlakbutton button5 = new yuvarlakbutton();
		yuvarlakbutton button6 = new yuvarlakbutton();
		yuvarlakbutton button7 = new yuvarlakbutton();


		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Size = new Size(120, 120);
			button1.Location = new System.Drawing.Point(400, 800);
			button1.BackColor = Color.HotPink;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.FlatAppearance.BorderColor = Color.Red;
			button1.Text = "100";
			button1.ForeColor = Color.Black;
			this.Controls.Add(button1);
			button1.Click += button1_Click;

			button2.Size = new Size(130, 130);
			button2.Location = new System.Drawing.Point(600, 800);
			button2.BackColor = Color.Green;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.FlatAppearance.BorderColor = Color.Red;
			button2.Text = "200";
			button2.ForeColor = Color.Black;
			this.Controls.Add(button2);
			button2.Click += button2_Click;

			button3.Size = new Size(140, 140);
			button3.Location = new System.Drawing.Point(800, 800);
			button3.BackColor = Color.Yellow;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.FlatAppearance.BorderColor = Color.Red;
			button3.Text = "500";
			button3.ForeColor = Color.Black;
			this.Controls.Add(button3);
			button3.Click += button3_Click;

			button4.Size = new Size(150, 150);
			button4.Location = new System.Drawing.Point(1000, 800);
			button4.BackColor = Color.Orange;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.FlatAppearance.BorderColor = Color.Red;
			button4.Text = "1000";
			button4.ForeColor = Color.Black;
			this.Controls.Add(button4);
			button4.Click += button4_Click;

			button5.Size = new Size(160, 160);
			button5.Location = new System.Drawing.Point(1200, 800);
			button5.BackColor = Color.Red;
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.FlatAppearance.BorderColor = Color.Red;
			button5.Text = "5000";
			button5.ForeColor = Color.Black;
			this.Controls.Add(button5);
			button5.Click += button5_Click;


			button6.Size = new Size(120, 120);
			button6.Location = new System.Drawing.Point(600, 650);
			button6.BackColor = Color.HotPink;
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.FlatAppearance.BorderColor = Color.Red;
			button6.Text = "Kart Çek";
			button6.ForeColor = Color.Black;
			this.Controls.Add(button6);
			button6.Click += button6_Click;


			button7.Size = new Size(120, 120);
			button7.Location = new System.Drawing.Point(800, 650);
			button7.BackColor = Color.HotPink;
			button7.FlatAppearance.BorderSize = 0;
			button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button7.FlatAppearance.BorderColor = Color.Red;
			button7.Text = "Dur";
			button7.ForeColor = Color.Black;
			this.Controls.Add(button7);
			button7.Click += button7_Click;


			button8.Size = new Size(120, 120);
			button8.Location = new System.Drawing.Point(1000, 650);
			button8.BackColor = Color.HotPink;
			button8.FlatAppearance.BorderSize = 0;
			button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button8.FlatAppearance.BorderColor = Color.Red;
			button8.Text = "2X";
			button8.ForeColor = Color.Black;
			this.Controls.Add(button8);
			button8.Click += button8_Click;

			button6.Visible = false;
			button7.Visible = false;
			button8.Visible = false;
		}

		yuvarlakbutton button8 = new yuvarlakbutton();

		public class yuvarlakbutton : Button
		{
			protected override void OnResize(EventArgs e)
			{
				base.OnResize(e);
				GraphicsPath gp = new GraphicsPath();
				gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
				this.Region = new Region(gp);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (balance >= 100)
			{
				balance -= 100;
				total += 100;
			}
			else
			{
				MessageBox.Show("Paranız Yetersiz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			label3.Text = Convert.ToString(balance);
			label4.Text = Convert.ToString(total);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (balance >= 200)
			{
				balance -= 200;
				total += 200;
			}
			else
			{
				MessageBox.Show("Paranız Yetersiz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			label3.Text = Convert.ToString(balance);
			label4.Text = Convert.ToString(total);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (balance >= 500)
			{
				balance -= 500;
				total += 500;
			}
			else
			{
				MessageBox.Show("Paranız Yetersiz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			label3.Text = Convert.ToString(balance);
			label4.Text = Convert.ToString(total);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (balance >= 1000)
			{
				balance -= 1000;
				total += 1000;
			}
			else
			{
				MessageBox.Show("Paranız Yetersiz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			label3.Text = Convert.ToString(balance);
			label4.Text = Convert.ToString(total);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (balance >= 5000)
			{
				balance -= 5000;
				total += 5000;
			}
			else
			{
				MessageBox.Show("Paranız Yetersiz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			label3.Text = Convert.ToString(balance);
			label4.Text = Convert.ToString(total);
		}


		private void button6_Click(object sender, EventArgs e)
		{
			OyuncuListe();

			if (oyuncuKartToplam > 21)
			{

				MessageBox.Show("Kaybettiniz" + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
			else if (oyuncuKartToplam == 21)
			{
				total *= 2;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}

		}
		private void button7_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)
			{
				casinoCalısma();

			}

			paraHesap();
		}

		private void button8_Click(object sender, EventArgs e)
		{

			for (int i = 0; i < 5; i++)
			{
				if (i == 1)
				{
					OyuncuListe();
					button8.Enabled = false;
				}
				else if (casinoKartToplam < oyuncuKartToplam)
				{
					CasinoListesi();
				}

			}
			if (oyuncuKartToplam > 21)
			{

				MessageBox.Show("Kaybettiniz" + total * 2);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
			else if (oyuncuKartToplam > casinoKartToplam && oyuncuKartToplam <= 21)
			{

				total *= 3;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
			else if (oyuncuKartToplam == 21)
			{

				total *= 3;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (casinoKartToplam > oyuncuKartToplam && casinoKartToplam <= 21)
			{


				MessageBox.Show("Kaybettiniz" + total * 2);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (casinoKartToplam == 21)
			{


				MessageBox.Show("Kaybettiniz" + total * 2);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (oyuncuKartToplam == casinoKartToplam)
			{
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Berabere");
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}

			else if (casinoKartToplam > oyuncuKartToplam && casinoKartToplam > 21)
			{
				total *= 3;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
		}

		private void btnBasla_Click(object sender, EventArgs e)
		{
			for (int i = 1; i <= 3; i++)
			{
				if (i == 1)
				{

					CasinoListesi();
				}

				if (i > 1)
				{
					OyuncuListe();
				}




				btnBasla.Visible = false;
			}
			if (oyuncuKartToplam == 21)
			{
				total *= 2;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + total);
				total = 0;
				label4.Text = total.ToString();
				BtnKaybet();
			}
			button6.Visible = true;
			button7.Visible = true;
			button8.Visible = true;
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			button4.Visible = false;
			button5.Visible = false;
		}


		static string RastgeleRenkSec(List<string> RastgeleRenkSec)
		{

			Random random = new Random();
			int rastgeleIndex = random.Next(RastgeleRenkSec.Count);


			return RastgeleRenkSec[rastgeleIndex];
		}
		static string RastgeleKartSec(List<string> BlackJackListe)
		{

			Random random = new Random();
			int rastgeleIndex = random.Next(BlackJackListe.Count);


			return BlackJackListe[rastgeleIndex];
		}

		private void btnTekrarOyna_Click(object sender, EventArgs e)
		{
			temizle();
			BtnKaybet();
		}

		private void temizle()
		{
			Casino.Items.Clear();
			Oyuncu.Items.Clear();
			lbl1.Text = "0";
			lbl2.Text = "0";
			label4.Text = "0";
			total = 0;
			btnBasla.Visible = true;
			balance = 1000;
			label3.Text = balance.ToString();
			oyuncuKartToplam = 0;
			casinoKartToplam = 0;
		}

		private void temizle2()
		{
			Casino.Items.Clear();
			Oyuncu.Items.Clear();
			lbl1.Text = "0";
			lbl2.Text = "0";
			label4.Text = "0";
			total = 0;
			btnBasla.Visible = true;
			oyuncuKartToplam = 0;
			casinoKartToplam = 0;
		}

		private void casinoCalısma()
		{
			if (casinoKartToplam < oyuncuKartToplam)
			{
				List<string> BlackJackListe = new List<string>
		{
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"J",
			"Q",
			"K",
			"A"
		};
				List<string> Renkler = new List<string>
		{
			"Sinek",
			"Kupa",
			"Karo",
			"Maça",

		};


				string rastgelekart = RastgeleKartSec(BlackJackListe);
				string rastgelerenk = RastgeleRenkSec(Renkler);

				Thread.Sleep(100);
				Casino.Items.Add(rastgelerenk + " " + rastgelekart);
				if (rastgelekart == "J" || rastgelekart == "Q" || rastgelekart == "K" || rastgelekart == "10")
				{
					casinoKartToplam += 10;
					lbl1.Text = (Convert.ToString(casinoKartToplam));

				}
				else if (rastgelekart == "A")
				{

					if (casinoKartToplam <= 10)
					{
						casinoKartToplam += 11;
						lbl1.Text = (Convert.ToString(casinoKartToplam));
					}
					else
					{
						casinoKartToplam += 1;
						lbl1.Text = (Convert.ToString(casinoKartToplam));

					}

				}
				else
				{
					casinoKartToplam += Convert.ToInt16(rastgelekart);
					lbl1.Text = (Convert.ToString(casinoKartToplam));
				}

			}

		}

		private void paraHesap()
		{
			if (oyuncuKartToplam > 21)
			{

				MessageBox.Show("Kaybettiniz" + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
			else if (oyuncuKartToplam > casinoKartToplam && oyuncuKartToplam <= 21)
			{
				total *= 2;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
			else if (oyuncuKartToplam == 21)
			{

				total *= 2;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (casinoKartToplam > oyuncuKartToplam && casinoKartToplam <= 21)
			{


				MessageBox.Show("Kaybettiniz" + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (casinoKartToplam == 21)
			{


				MessageBox.Show("Kaybettiniz" + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();

			}
			else if (oyuncuKartToplam == casinoKartToplam)
			{
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Berabere");
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}

			else if (casinoKartToplam > oyuncuKartToplam && casinoKartToplam > 21)
			{
				total *= 2;
				balance += total;
				label3.Text = balance.ToString();
				MessageBox.Show("Kazandınız" + " " + total);
				total = 0;
				label4.Text = total.ToString();
				temizle2();
				BtnKaybet();
			}
		}

		private void CasinoListesi()
		{
			List<string> BlackJackListe = new List<string>
		{
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"J",
			"Q",
			"K",
			"A"
		};
			List<string> Renkler = new List<string>
		{
			"Sinek",
			"Kupa",
			"Karo",
			"Maça",

		};

			Thread.Sleep(100);
			string rastgelekart = RastgeleKartSec(BlackJackListe);
			string rastgelerenk = RastgeleRenkSec(Renkler);
			Casino.Items.Add(rastgelerenk + " " + rastgelekart);


			if (rastgelekart == "J" || rastgelekart == "Q" || rastgelekart == "K" || rastgelekart == "10")
			{
				casinoKartToplam += 10;
				lbl1.Text = (Convert.ToString(casinoKartToplam));

			}

			else if (rastgelekart == "A")
			{

				if (casinoKartToplam <= 10)
				{
					casinoKartToplam += 11;
					lbl1.Text = (Convert.ToString(casinoKartToplam));

				}
				else
				{
					casinoKartToplam += 1;
					lbl1.Text = (Convert.ToString(casinoKartToplam));

				}

			}
			else
			{
				casinoKartToplam += Convert.ToInt16(rastgelekart);
				lbl1.Text = (Convert.ToString(casinoKartToplam));

			}
		}

		private void OyuncuListe()
		{

			List<string> BlackJackListe = new List<string>
		{
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"J",
			"Q",
			"K",
			"A"
		};
			List<string> Renkler = new List<string>
		{
			"Sinek",
			"Kupa",
			"Karo",
			"Maça",

		};


			string rastgelekart = RastgeleKartSec(BlackJackListe);
			string rastgelerenk = RastgeleRenkSec(Renkler);
			Oyuncu.Items.Add(rastgelerenk + " " + rastgelekart);

			Thread.Sleep(100);
			if (rastgelekart == "J" || rastgelekart == "Q" || rastgelekart == "K" || rastgelekart == "10")
			{
				oyuncuKartToplam += 10;
				lbl2.Text = (Convert.ToString(oyuncuKartToplam));


			}

			else if (rastgelekart == "A")
			{

				if (oyuncuKartToplam <= 10)
				{
					oyuncuKartToplam += 11;
					lbl2.Text = (Convert.ToString(oyuncuKartToplam));

				}
				else
				{
					oyuncuKartToplam += 1;
					lbl2.Text = (Convert.ToString(oyuncuKartToplam));

				}



			}
			else
			{
				oyuncuKartToplam += Convert.ToInt16(rastgelekart);
				lbl2.Text = (Convert.ToString(oyuncuKartToplam));


			}
		}

		private void BtnKaybet()
		{
			button6.Visible = false;
			button7.Visible = false;
			button8.Visible = false;
			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
			button4.Visible = true;
			button5.Visible = true;
			button8.Enabled = true;
		}

	}
}
