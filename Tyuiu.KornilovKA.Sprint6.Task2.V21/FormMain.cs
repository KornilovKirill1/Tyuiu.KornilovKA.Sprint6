using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KornilovKA.Sprint6.Task2.V21.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task2.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.chartFunction_KKA.Titles.Add("График функции");

            this.chartFunction_KKA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_KKA.ChartAreas[0].AxisY.Title = "Ось Y";
        }

        DataService ds = new DataService();
        private void buttonReference_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Корнилов Кирилл Андреевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonExecute_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartFunction_KKA.Series[0].Points.Clear();
                this.dataGridViewFunction_KKA.Rows.Clear();

                int startValue = Convert.ToInt32(textBoxStartValue_KKA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_KKA.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                for(int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction_KKA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_KKA.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            } catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonExecute_KKA_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute_KKA.BackColor = Color.Red;
        }

        private void buttonExecute_KKA_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute_KKA.BackColor = Color.Green;
        }

        private void buttonExecute_KKA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExecute_KKA.BackColor = Color.Blue;
        }
    }
}
