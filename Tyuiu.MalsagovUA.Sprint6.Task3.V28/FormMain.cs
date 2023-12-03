using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalsagovUA.Sprint6.Task3.V28.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] array = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                       { -13, -11, -20, -15, 9 },
                                       { 18, 13, -12, -15, -11 },
                                       { 10, -2, 19, -4, -10 },
                                       { 6, -20, -4, 13, -14 } };

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Мальсагов Умар Асланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            dataGridViewInPutData_MUA.ColumnCount = columns;
            dataGridViewInPutData_MUA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_MUA.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutData_MUA.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }

        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int[,] res_array = ds.Calculate(array);
            dataGridViewOutPutData_MUA.ColumnCount = columns;
            dataGridViewOutPutData_MUA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPutData_MUA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutData_MUA.Rows[i].Cells[j].Value = Convert.ToString(res_array[i, j]);
                }
            }
        }
    }
}
