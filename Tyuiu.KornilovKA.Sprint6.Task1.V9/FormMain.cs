using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KornilovKA.Sprint6.Task1.V9.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonExecute_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_KKA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_KKA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_KKA.Text = "";
                textBoxResult_KKA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KKA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_KKA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_KKA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_KKA.AppendText("+----------+----------+" + Environment.NewLine);
            } catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Корнилов Кирилл Андреевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
