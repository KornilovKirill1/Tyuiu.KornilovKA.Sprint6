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

using Tyuiu.KornilovKA.Sprint6.Task5.V3.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string path = @"C:\DataSprint6\InPutFileTask5V3.txt";
        DataService ds = new DataService();
        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            dataGridViewOutputData_KKA.ColumnCount = 2;
            dataGridViewOutputData_KKA.Columns[0].Width = 20;
            dataGridViewOutputData_KKA.Columns[1].Width = 50;

            this.chartGraph_KKA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph_KKA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraph_KKA.Series[0].Points.Clear();
            dataGridViewOutputData_KKA.Rows.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutputData_KKA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartGraph_KKA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            } catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void buttonInfo_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Корнилов Кирилл Андреевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
