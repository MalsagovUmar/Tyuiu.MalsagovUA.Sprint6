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

using Tyuiu.MalsagovUA.Sprint6.Task6.V1.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_MUA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MUA.ShowDialog();
            openFilePath = openFileDialogTask_MUA.FileName;
            textBoxInPutData_MUA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_MUA.Text = groupBoxOutPutData_MUA.Text + " " + openFileDialogTask_MUA.FileName;
            buttonDone_MUA.Enabled = true;
        }

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPutData_MUA.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
