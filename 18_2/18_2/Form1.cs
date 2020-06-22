using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void rbFunt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFunt.Checked ==true)
            {
                double funt = 454;
                double[] gr = new double[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                lbl1Gr.Text = "1 грамм = " + gr[1]/funt + " фунтов";
                lbl2Gr.Text = "2 грамма = " + gr[2] / funt + " фунтов";
                lbl3Gr.Text = "3 грамма = " + gr[3] / funt + " фунтов";
                lbl4Gr.Text = "4 грамма = " + gr[4] / funt + " фунтов";
                lbl5Gr.Text = "5 грамм = " + gr[5] / funt + " фунтов";
                lbl6Gr.Text = "6 грамм = " + gr[6] / funt + " фунтов";
                lbl7Gr.Text = "7 грамм = " + gr[7] / funt + " фунтов";
                lbl8Gr.Text = "8 грамм = " + gr[8] / funt + " фунтов";
                lbl9Gr.Text = "9 грамм = " + gr[9] / funt + " фунтов";
                lbl10Gr.Text = "10 грамм = " + gr[10] / funt + " фунтов";
            } else
            if (rbPud.Checked == true)
            {
                double pud = 16380;
                double[] gr = new double[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                lbl1Gr.Text = "1 грамм = " + gr[1] / pud + " пудов";
                lbl2Gr.Text = "2 грамма = " + gr[2] / pud + " пудов";
                lbl3Gr.Text = "3 грамма = " + gr[3] / pud + " пудов";
                lbl4Gr.Text = "4 грамма = " + gr[4] / pud + " пудов";
                lbl5Gr.Text = "5 грамм = " + gr[5] / pud + " пудов";
                lbl6Gr.Text = "6 грамм = " + gr[6] / pud + " пудов";
                lbl7Gr.Text = "7 грамм = " + gr[7] / pud + " пудов";
                lbl8Gr.Text = "8 грамм = " + gr[8] / pud + " пудов";
                lbl9Gr.Text = "9 грамм = " + gr[9] / pud + " пудов";
                lbl10Gr.Text = "10 грамм = " + gr[10] / pud + " пудов";
            }
            else
            if(rbUnc.Checked == true)
            {
                double unc = 28.35;
                double[] gr = new double[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                lbl1Gr.Text = "1 грамм = " + gr[1] / unc + " унций";
                lbl2Gr.Text = "2 грамма = " + gr[2] / unc + " унций";
                lbl3Gr.Text = "3 грамма = " + gr[3] / unc + " унций";
                lbl4Gr.Text = "4 грамма = " + gr[4] / unc + " унций";
                lbl5Gr.Text = "5 грамм = " + gr[5] / unc + " унций";
                lbl6Gr.Text = "6 грамм = " + gr[6] / unc + " унций";
                lbl7Gr.Text = "7 грамм = " + gr[7] / unc + " унций";
                lbl8Gr.Text = "8 грамм = " + gr[8] / unc + " унций";
                lbl9Gr.Text = "9 грамм = " + gr[9] / unc + " унций";
                lbl10Gr.Text = "10 грамм = " + gr[10] / unc + " унций";
            }
            else
            if(rbDrahma.Checked == true)
            {
                double drahma = 1.772;
                double[] gr = new double[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                lbl1Gr.Text = "1 грамм = " + gr[1] / drahma + " драхм";
                lbl2Gr.Text = "2 грамма = " + gr[2] / drahma + " драхм";
                lbl3Gr.Text = "3 грамма = " + gr[3] / drahma + " драхм";
                lbl4Gr.Text = "4 грамма = " + gr[4] / drahma + " драхм";
                lbl5Gr.Text = "5 грамм = " + gr[5] / drahma + " драхм";
                lbl6Gr.Text = "6 грамм = " + gr[6] / drahma + " драхм";
                lbl7Gr.Text = "7 грамм = " + gr[7] / drahma + " драхм";
                lbl8Gr.Text = "8 грамм = " + gr[8] / drahma + " драхм";
                lbl9Gr.Text = "9 грамм = " + gr[9] / drahma + " драхм";
                lbl10Gr.Text = "10 грамм = " + gr[10] / drahma + " драхм";
            }
            else
            if(rbGran.Checked == true)
            {
                double gran = 0.0648;
                double[] gr = new double[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                lbl1Gr.Text = "1 грамм = " + gr[1] / gran + " гран";
                lbl2Gr.Text = "2 грамма = " + gr[2] / gran + " гран";
                lbl3Gr.Text = "3 грамма = " + gr[3] / gran + " гран";
                lbl4Gr.Text = "4 грамма = " + gr[4] / gran + " гран";
                lbl5Gr.Text = "5 грамм = " + gr[5] / gran + " гран";
                lbl6Gr.Text = "6 грамм = " + gr[6] / gran + " гран";
                lbl7Gr.Text = "7 грамм = " + gr[7] / gran + " гран";
                lbl8Gr.Text = "8 грамм = " + gr[8] / gran + " гран";
                lbl9Gr.Text = "9 грамм = " + gr[9] / gran + " гран";
                lbl10Gr.Text = "10 грамм = " + gr[10] / gran + " гран";
            }

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            rbFunt_CheckedChanged(sender, e);
        }
    }
}
//Чайкин Степан Станиславович, ИСиП-21
