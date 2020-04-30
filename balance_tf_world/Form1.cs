using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balance_tf_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int para;
        int k1f, k2f, k3f, k4f, k5f, k6f, k7f, k8f, k9f, k10f, k11f, k12f, k13f, k14f, k15f, k16f;
        int ap, dp, hp;
        int gelir;
        int s1dp, s2dp, s3dp, s4dp, s5dp, s6dp, s7dp, s8dp, s9dp, s10dp, s11dp, s12dp, s13dp, s14dp, s15dp, s16dp;

        private void button32_Click(object sender, EventArgs e)
        {
            para = para + (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
            label155.Text = Convert.ToString(para);
            label154.Text = Convert.ToString(para);
            label88.Text = Convert.ToString(para);
            label223.Text = Convert.ToString(para);
            label293.Text = Convert.ToString(para);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            para = para + (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
            label155.Text = Convert.ToString(para);
            label154.Text = Convert.ToString(para);
            label88.Text = Convert.ToString(para);
            label223.Text = Convert.ToString(para);
            label293.Text = Convert.ToString(para);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (s1m<1)
            {
                if (bronzm>=10)
                {
                    bronzm = bronzm - 10;
                    s1m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Bronz Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (s2m < 1)
            {
                if (bronzm >= 25)
                {
                    bronzm = bronzm - 25;
                    s2m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Bronz Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (s3m < 1)
            {
                if (bronzm >= 100)
                {
                    bronzm = bronzm - 100;
                    s3m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Bronz Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (s4m < 1)
            {
                if (gumusm >= 10)
                {
                    gumusm = gumusm - 10;
                    s4m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Gümüş Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (s5m < 1)
            {
                if (gumusm >= 25)
                {
                    gumusm = gumusm - 25;
                    s5m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Gümüş Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (s6m < 1)
            {
                if (gumusm >= 50)
                {
                    gumusm = gumusm - 50;
                    s6m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Gümüş Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (s7m < 1)
            {
                if (gumusm >= 100)
                {
                    gumusm = gumusm - 100;
                    s7m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Gümüş Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (s8m < 1)
            {
                if (altinm >= 1)
                {
                    altinm = altinm - 1;
                    s8m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Altın Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (s9m < 1)
            {
                if (altinm >= 10)
                {
                    altinm = altinm - 10;
                    s9m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Altın Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (s10m < 1)
            {
                if (guctasim >= 1)
                {
                    guctasim = guctasim - 1;
                    s10m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (s11m < 1)
            {
                if (guctasim >= 10)
                {
                    guctasim = guctasim - 10;
                    s11m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (s12m < 1)
            {
                if (guctasim >= 100)
                {
                    guctasim = guctasim - 100;
                    s12m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (s13m < 1)
            {
                if (guctasim >= 250)
                {
                    guctasim = guctasim - 250;
                    s13m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (s14m < 1)
            {
                if (guctasim >= 500)
                {
                    guctasim = guctasim - 500;
                    s14m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (s15m < 1)
            {
                if (guctasim >= 750)
                {
                    guctasim = guctasim - 750;
                    s15m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (s16m < 1)
            {
                if (guctasim >= 1000)
                {
                    guctasim = guctasim - 1000;
                    s16m++;
                }
                else
                {
                    MessageBox.Show("Yeterli Güç Taşı Yok");
                }
            }
            else
            {
                MessageBox.Show("Maximum İtem Sınırına Ulaştınız");
            }
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);
        }

        int s1hp, s2hp, s3hp, s4hp, s5hp, s6hp, s7hp, s8hp, s9hp, s10hp, s11hp, s12hp, s13hp, s14hp, s15hp, s16hp;
        int s1f, s2f, s3f, s4f, s5f, s6f, s7f, s8f, s9f, s10f, s11f, s12f, s13f, s14f, s15f, s16f;
        int s1m, s2m, s3m, s4m, s5m, s6m, s7m, s8m, s9m, s10m, s11m, s12m, s13m, s14m, s15m, s16m;
        private void button5_Click(object sender, EventArgs e)
        {
            if (para >= k8f)
            {
                k8m++;
                label17.Text = Convert.ToString(k8m);
                para = para - k8f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k8m <= 1)
                {
                    ap = ap + k8h;
                }

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (para >= k10f)
            {
                k10m++;
                label53.Text = Convert.ToString(k10m);
                para = para - k10f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k10m <= 1)
                {
                    ap = ap + k10h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (para >= k11f)
            {
                k11m++;
                label51.Text = Convert.ToString(k11m);
                para = para - k11f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k11m <= 1)
                {
                    ap = ap + k11h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (para >= k12f)
            {
                k12m++;
                label49.Text = Convert.ToString(k12m);
                para = para - k12f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k12m <= 1)
                {
                    ap = ap + k12h;
                }

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (para >= k13f)
            {
                k13m++;
                label39.Text = Convert.ToString(k13m);
                para = para - k13f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k13m <= 1)
                {
                    ap = ap + k13h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (para >= k14f)
            {
                k14m++;
                label37.Text = Convert.ToString(k14m);
                para = para - k14f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k14m <= 1)
                {
                    ap = ap + k14h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (para >= k15f)
            {
                k15m++;
                label35.Text = Convert.ToString(k15m);
                para = para - k15f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k15m <= 1)
                {
                    ap = ap + k15h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (para >= k16f)
            {
                k16m++;
                label33.Text = Convert.ToString(k16m);
                para = para - k16f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k16m <= 1)
                {
                    ap = ap + k16h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            para = para + (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
            label155.Text = Convert.ToString(para);
            label154.Text = Convert.ToString(para);
            label88.Text = Convert.ToString(para);
            label223.Text = Convert.ToString(para);
            label293.Text = Convert.ToString(para);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (para >= bronzf)
            {
                para = para - bronzf;
                bronzm++;
                label67.Text = Convert.ToString(bronzm);
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (para >= gumusf)
            {
                para = para - gumusf;
                gumusm++;
                label69.Text = Convert.ToString(gumusm);
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (para >= altinf)
            {
                para = para - altinf;
                altinm++;
                label73.Text = Convert.ToString(altinm);
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (para >= guctasif)
            {
                para = para - guctasif;
                guctasim++;
                label77.Text = Convert.ToString(guctasim);
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (para >= k7f)
            {
                k7m++;
                label19.Text = Convert.ToString(k7m);
                para = para - k7f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k7m <= 1)
                {
                    ap = ap + k7h;
                }

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (para >= k6f)
            {
                k6m++;
                label21.Text = Convert.ToString(k6m);
                para = para - k6f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k6m <= 1)
                {
                    ap = ap + k6h;
                }

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (para >= k5f)
            {
                k5m++;
                label23.Text = Convert.ToString(k5m);
                para = para - k5f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);

                if (k5m <= 1)
                {
                    ap = ap + k5h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (para >= k4f)
            {
                k4m++;
                label15.Text = Convert.ToString(k4m);
                para = para - k4f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k4m <= 1)
                {
                    ap = ap + k4h;
                }

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (para >= k3f)
            {
                k3m++;
                label13.Text = Convert.ToString(k3m);
                para = para - k3f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k3m <= 1)
                {
                    ap = ap + k3h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (para >= k2f)
            {
                k2m++;
                label11.Text = Convert.ToString(k2m);
                para = para - k2f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);

                if (k2m <= 1)
                {
                    ap = ap + k2h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (para >= k1f)
            {
                k1m++;
                label9.Text = Convert.ToString(k1m);
                para = para - k1f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);

            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (para >= k9f)
            {
                k9m++;
                label55.Text = Convert.ToString(k9m);
                para = para - k9f;
                label155.Text = Convert.ToString(para);
                label154.Text = Convert.ToString(para);
                label88.Text = Convert.ToString(para);
                gelir = (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
                if (k9m <= 1)
                {
                    ap = ap + k9h;
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok");
            }
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            label84.Text = Convert.ToString(ap);
            label85.Text = Convert.ToString(dp);
            label86.Text = Convert.ToString(hp);
            label228.Text = Convert.ToString(gelir);
            label85.Text = Convert.ToString(dp);
            label67.Text = Convert.ToString(bronzm);
            label69.Text = Convert.ToString(gumusm);
            label73.Text = Convert.ToString(altinm);
            label77.Text = Convert.ToString(guctasim);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            para = para + (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
            label155.Text = Convert.ToString(para);
            label154.Text = Convert.ToString(para);
            label88.Text = Convert.ToString(para);
            label223.Text = Convert.ToString(para);
            label293.Text = Convert.ToString(para);
            

        }

        int k1g, k2g, k3g, k4g, k5g, k6g, k7g, k8g, k9g, k10g, k11g, k12g, k13g, k14g, k15g, k16g;

        int bronzm, gumusm, altinm, guctasim;
        int bronzf, gumusf, altinf, guctasif;
        int k1m, k2m, k3m, k4m, k5m, k6m, k7m, k8m, k9m, k10m, k11m, k12m, k13m, k14m, k15m, k16m;
        int k1h, k2h, k3h, k4h, k5h, k6h, k7h, k8h, k9h, k10h, k11h, k12h, k13h, k14h, k15h, k16h;

        public void Form1_Load(object sender, EventArgs e)
        {
            
            label154.Text = Convert.ToString(para);
            label88.Text = Convert.ToString(para);
            para = 0;
            ap = 10;
            dp = 0;
            hp = 100;
            k1f = 100;
            k2f = 200;
            k3f = 300;
            k4f = 500;
            k5f = 1000;
            k6f = 2500;
            k7f = 5000;
            k8f = 10000;
            k9f = 25000;
            k10f = 35000;
            k11f = 45000;
            k12f = 60000;
            k13f = 75000;
            k14f = 100000;
            k15f = 250000;
            k16f = 500000;
            k1m = 1;

            k2m = 0;
            k3m = 0;
            k4m = 0;
            k5m = 0;
            k6m = 0;
            k7m = 0;
            k8m = 0;
            k9m = 0;
            k10m = 0;
            k11m = 0;
            k12m = 0;
            k13m = 0;
            k14m = 0;
            k15m = 0;
            k16m = 0;
            k1g = 10;
            k2g = 15;
            k3g = 20;
            k4g = 25;
            k5g = 35;
            k6g = 50;
            k7g = 60;
            k8g = 70;
            k9g = 80;
            k10g = 90;
            k11g = 110;
            k12g = 200;
            k13g = 250;
            k14g = 300;
            k15g = 400;
            k16g = 500;
            k1h = 10;
            k2h = 15;
            k3h = 20;
            k4h = 25;
            k5h = 35;
            k6h = 50;
            k7h = 60;
            k8h = 70;
            k9h = 80;
            k10h = 90;
            k11h = 110;
            k12h = 200;
            k13h = 250;
            k14h = 300;
            k15h = 400;
            k16h = 500;
            bronzm = 0;
            gumusm = 0;
            altinm = 0;
            guctasim = 0;
            bronzf = 10000;
            gumusf = 10*bronzf;
            altinf = 100*gumusf;
            guctasif = 100*altinf;
            progressBar3.Maximum = 2000;
            progressBar2.Maximum = 1000;
            progressBar1.Maximum = 2305;
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
            progressBar3.Minimum = 0;
            progressBar3.Value = hp;
            progressBar2.Value = dp;
            progressBar1.Value = ap;
            
            para = para + (k1m * k1g) + (k2m * k2g) + (k3m * k3g) + (k4m * k4g) + (k5m * k5g) + (k5m * k5g) + (k6m * k6g) + (k7m * k7g) + (k8m * k8g) + (k9m * k9g) + (k10m * k10g) + (k11m * k11g) + (k12m * k12g) + (k13m * k13g) + (k14m * k14g) + (k15m * k15g) + (k16m * k16g);
            








        }
    }
}