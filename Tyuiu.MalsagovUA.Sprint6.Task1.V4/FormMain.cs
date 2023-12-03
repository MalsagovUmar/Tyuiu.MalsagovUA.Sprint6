using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MalsagovUA.Sprint6.Task1.V4.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStartStep_MUA.Text);
                int stopStep = int.Parse(textBoxStopStep_MUA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_MUA.Text = "";
                textBoxResult_MUA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_MUA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_MUA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_MUA.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_MUA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Мальсагов Умар Асланович", "Сообщение");
        }

        private void textBoxStartStep_MUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
