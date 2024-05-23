using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sex.SelectedIndex == 0 || sex.SelectedIndex == 1) && size.Value != 0 && mass.Value != 0)
                {
                    double h = (double)size.Value / 100;
                    int m = (int)mass.Value;
                    double imt = m / (h * h);
                    imt_result.Text = "" + Math.Round(imt, 2);
                    if (sex.SelectedIndex == 0)
                    {
                        if (imt < 18)
                        {
                            result_mass.Text = "недостаточный";
                            thin.Visible = true;
                            fat.Visible = false;
                            norm.Visible = false;
                            none.Visible = false;
                        }
                        else
                        {
                            if (imt > 24)
                            {
                                result_mass.Text = "избыточный";
                                thin.Visible = false;
                                fat.Visible = true;
                                norm.Visible = false;
                                none.Visible = false;
                            }
                            else
                            {
                                result_mass.Text = "нормальный";
                                thin.Visible = false;
                                fat.Visible = false;
                                norm.Visible = true;
                                none.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        if (imt < 20)
                        {
                            result_mass.Text = "недостаточный";
                            thin.Visible = true;
                            fat.Visible = false;
                            norm.Visible = false;
                            none.Visible = false;
                        }
                        else
                        {
                            if (imt > 26)
                            {
                                result_mass.Text = "избыточный";
                                thin.Visible = false;
                                fat.Visible = true;
                                norm.Visible = false;
                                none.Visible = false;
                            }
                            else
                            {
                                result_mass.Text = "нормальный";
                                thin.Visible = false;
                                fat.Visible = false;
                                norm.Visible = true;
                                none.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            
        }
    }
}
