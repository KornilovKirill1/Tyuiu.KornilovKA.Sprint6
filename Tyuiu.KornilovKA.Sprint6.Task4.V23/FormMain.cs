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

using Tyuiu.KornilovKA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_KKA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_KKA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] arrResult = new double[len];

                arrResult = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_KKA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KKA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutputData_KKA.Text = "";
                chartResult_KKA.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartResult_KKA.Series[0].Points.AddXY(startValue, arrResult[i]);
                    textBoxOutputData_KKA.AppendText(arrResult[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxOutputData_KKA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Корнилов Кирилл Андреевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
