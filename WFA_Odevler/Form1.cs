using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFA_Odevler
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] diziSayi = new int[6];        
        int sayac = 0;
        int index = 0;
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (index ==0)
            {
                timer1.Start();
                int sayi1 = rnd.Next(6, 49);               
                txtSayi1.Text = sayi1.ToString();
                if (sayac == 9)
                {
                    diziSayi[index] = sayi1;
                    txtSayi1.Text = sayi1.ToString();
                    index++;
                    sayac = 0;
                }
                else
                {
                    sayac++;
                }
            }
            else if (index == 1)
            {
                int sayi2 = rnd.Next(6, 49);
                txtSayi2.Text = sayi2.ToString();
                if (sayac == 9)
                {
                    diziSayi[index] = sayi2;
                    for (int i = 0; i < diziSayi.Length-5; i++)
                    {
                        if (sayi2 == diziSayi[i])
                        {
                            sayac = 0;
                            index = 0;
                        }
                        else
                        {
                            sayac = 0;
                            
                        }
                    }
                    index++;
                }
                else
                {
                    sayac++;
                }
            }
            else if (index == 2)
            {
                int sayi3 = rnd.Next(6, 49);
                txtSayi3.Text = sayi3.ToString();
                if (sayac == 9)
                {
                    diziSayi[index] = sayi3;
                    for (int i = 0; i < diziSayi.Length - 4; i++)
                    {
                        if (sayi3 == diziSayi[i])
                        {
                            sayac = 0;
                            index = 1;
                        }
                        else
                        {
                            sayac = 0;                            
                        }
                        
                    }
                    index++;
                }
                else
                {
                    sayac++;
                }
            }
            else if (index == 3)
            {
                int sayi4 = rnd.Next(6, 49);
                txtSayi4.Text = sayi4.ToString();
                if (sayac == 9)
                {
                    diziSayi[index] = sayi4;
                    for (int i = 0; i < diziSayi.Length - 3; i++)
                    {
                        if (sayi4 == diziSayi[i])
                        {
                            sayac = 0;
                            index = 2;
                        }
                        else
                        {
                            sayac = 0;
                            
                        }
                    }
                    index++;
                }
                else
                {
                    sayac++;
                }
            }
            else if (index == 4)
            {
                int sayi5 = rnd.Next(6, 49);
                txtSayi5.Text = sayi5.ToString();
                if (sayac == 9)
                {
                    diziSayi[index] = sayi5;
                    for (int i = 0; i < diziSayi.Length - 2; i++)
                    {
                        if (sayi5 == diziSayi[i])
                        {
                            sayac = 0;
                            index = 3;
                        }
                        else
                        {
                            sayac = 0;
                            
                        }
                    }
                    index++;
                }
                else
                {
                    sayac++;
                }
            }
            else if (index == 5)
            {
                int sayi6 = rnd.Next(6, 49);
                txtSayi6.Text = sayi6.ToString();
                if (sayac == 9)
                {                    
                    
                    diziSayi[index] = sayi6;
                    for (int i = 0; i < diziSayi.Length-1; i++)
                    {
                        if (sayi6 == diziSayi[i])
                        {
                            sayac = 0;
                            index = 4;
                        }
                        else
                        {
                            timer1.Stop();
                            Array.Sort(diziSayi);
                            txtSayi1.Text = diziSayi[0].ToString();
                            txtSayi2.Text = diziSayi[1].ToString();
                            txtSayi3.Text = diziSayi[2].ToString();
                            txtSayi4.Text = diziSayi[3].ToString();
                            txtSayi5.Text = diziSayi[4].ToString();
                            txtSayi6.Text = diziSayi[5].ToString();
                            metroButton1.Enabled = false;

                        }
                    }                 
                    
                }
                else
                {
                    sayac++;
                }
            }
            
            
        }
    }
}
