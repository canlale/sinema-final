using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public int koltuksayisi;
        public Form1()
        {
            InitializeComponent();
            comboBox3.Items.Add("Öğrenci");
            comboBox3.Items.Add("Tam");
            comboBox1.Items.Add("Salon 1");
            comboBox1.Items.Add("Salon 2");
            comboBox1.Items.Add("Salon 3");
            comboBox1.Items.Add("Salon 4");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("18:00");
            comboBox2.Items.Add("20:00");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.Yellow)
            {
                button1.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != Color.Yellow)
            {
                button2.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != Color.Yellow)
            {
                button4.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (button5.BackColor != Color.Yellow)
            {
                button5.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.BackColor != Color.Yellow)
            {
                button8.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (button7.BackColor != Color.Yellow)
            {
                button7.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.BackColor != Color.Yellow)
            {
                button6.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.BackColor != Color.Yellow)
            {
                button3.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (button12.BackColor != Color.Yellow)
            {
                button12.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button12.BackColor == Color.Yellow)
            {
                button12.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.BackColor != Color.Yellow)
            {
                button9.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (button10.BackColor != Color.Yellow)
            {
                button10.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button10.BackColor == Color.Yellow)
            {
                button10.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (button11.BackColor != Color.Yellow)
            {
                button11.BackColor = Color.Yellow;
                koltuksayisi += 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button13.Visible = true;
            }
            else if (button11.BackColor == Color.Yellow)
            {
                button11.BackColor = Color.Transparent;
                koltuksayisi -= 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button13.Visible = false;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (comboBox3.Text == "Öğrenci" || comboBox3.Text == "Tam")
            {
                if (comboBox1.Text =="Salon 1" || comboBox1.Text == "Salon 2" || comboBox1.Text == "Salon 3" || comboBox1.Text == "Salon 4" || comboBox1.Text == "Salon 5")
                {
                    if (comboBox2.Text == "12:00" || comboBox2.Text == "14:00" || comboBox2.Text == "16:00" || comboBox2.Text == "18:00" || comboBox2.Text == "20:00")
                    {
                        if (button1.BackColor == Color.Yellow)
                        {
                            button1.BackColor = Color.Red;
                            button1.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button2.BackColor == Color.Yellow)
                        {
                            button2.BackColor = Color.Red;
                            button2.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button3.BackColor == Color.Yellow)
                        {
                            button3.BackColor = Color.Red;
                            button3.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button4.BackColor == Color.Yellow)
                        {
                            button4.BackColor = Color.Red;
                            button4.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button5.BackColor == Color.Yellow)
                        {
                            button5.BackColor = Color.Red;
                            button5.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button6.BackColor == Color.Yellow)
                        {
                            button6.BackColor = Color.Red;
                            button6.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button7.BackColor == Color.Yellow)
                        {
                            button7.BackColor = Color.Red;
                            button7.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button8.BackColor == Color.Yellow)
                        {
                            button8.BackColor = Color.Red;
                            button8.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button9.BackColor == Color.Yellow)
                        {
                            button9.BackColor = Color.Red;
                            button9.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button10.BackColor == Color.Yellow)
                        {
                            button10.BackColor = Color.Red;
                            button10.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button11.BackColor == Color.Yellow)
                        {
                            button11.BackColor = Color.Red;
                            button11.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        if (button12.BackColor == Color.Yellow)
                        {
                            button12.BackColor = Color.Red;
                            button12.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            comboBox1.Visible = false;
                            comboBox2.Visible = false;
                            comboBox3.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            button13.Visible = false;
                        }
                        int Ucret = 0;
                        int ekliUcret;
                        int ToplamUcret;
                        Hesaplar hesap = new Hesaplar
                        {
                            gozluksayisi = Convert.ToInt32(textBox1.Text),
                            menusayisi = Convert.ToInt32(textBox2.Text),
                        };
                        if (comboBox3.Text == "Öğrenci")
                        {
                            Ucret = koltuksayisi * 15;
                        }
                        if (comboBox3.Text == "Tam")
                        {
                            Ucret = koltuksayisi * 20;
                        }
                        hesap.EkUcretHesapla();
                        ekliUcret = hesap.EkUcret;
                        ToplamUcret = Ucret + ekliUcret;
                        koltuksayisi = 0;

                        MessageBox.Show("Toplam Ödenecek Tutar: " + ToplamUcret);

                    }
                    else
                    {
                        MessageBox.Show("Lütfen Gireceğiniz Filmin Seansını Seçiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Gireceğiniz Filmin Salonunu Seçiniz!");
                }
            }
            else
            {
                MessageBox.Show("Müşteri Bilgilerini Doldurunuz!");
            }
        }
    }
}
