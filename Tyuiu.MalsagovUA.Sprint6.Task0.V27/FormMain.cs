using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalsagovUA.Sprint6.Task0.V27.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task0.V27
{
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
        }
        private void buttonDone_MUA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_MUA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_MUA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_MUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_MUA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-2 Мальсагов Умар Асланович", "Сообщение");
        }
    }
}
