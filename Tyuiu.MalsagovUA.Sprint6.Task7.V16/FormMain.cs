using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.MalsagovUA.Sprint6.Task7.V16.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_MUA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_MUA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_MUA_Click(object sender, EventArgs e)
        {
            openFileDialog_MUA.ShowDialog();
            openFile = openFileDialog_MUA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_MUA.RowCount = rows;
            dataGridViewInPutData_MUA.ColumnCount = columns;
            dataGridViewOutPutData_MUA.RowCount = rows;
            dataGridViewOutPutData_MUA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_MUA.Columns[i].Width = 50;
                dataGridViewOutPutData_MUA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_MUA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_MUA.Enabled = true;
        }

        private void buttonOpenFile_MUA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MUA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MUA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MUA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MUA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MUA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MUA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MUA.ToolTipTitle = "Справка";
        }

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            //FormAbout formabout = new FormAbout();
            //formabout.ShowDialog();
        }

        private void buttonSave_MUA_Click(object sender, EventArgs e)
        {
            saveFileDialog_MUA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_MUA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MUA.ShowDialog();

            string path = saveFileDialog_MUA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_MUA.RowCount;
            int columns = dataGridViewOutPutData_MUA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_MUA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_MUA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPutData_MUA.RowCount = 50;
            dataGridViewOutPutData_MUA.RowCount = 50;

            dataGridViewInPutData_MUA.ColumnCount = 50;
            dataGridViewOutPutData_MUA.ColumnCount = 50;

            panelLeft_MUA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPutData_MUA.Columns[i].Width = 25;
                dataGridViewOutPutData_MUA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_MUA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_MUA.Enabled = true;
        }
    }
}
