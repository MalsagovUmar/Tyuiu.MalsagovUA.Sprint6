using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalsagovUA.Sprint6.Task5.V17.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\malsu\source\repos\Tyuiu.MalsagovUA.Sprint6\Tyuiu.MalsagovUA.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Мальсагов Умар Асланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_MUA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MUA.ColumnCount = 2;
            dataGridViewResult_MUA.Columns[0].Width = 20;
            dataGridViewResult_MUA.Columns[1].Width = 50;
            this.chartFunction_MUA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_MUA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_MUA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_MUA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_MUA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
