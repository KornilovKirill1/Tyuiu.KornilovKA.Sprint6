using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KornilovKA.Sprint6.Task3.V11.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] valueArray = {
                { 27, -15, 14 , 2, 27 },
                { -8, 14, -10, 33, 0 },
                { 1, 7, -11, -11, 23 },
                { -13, -20, 15, -16, 34 },
                { -3, 1, -1, 5, 1 }
            };

        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(valueArray);

            int rows = result.GetUpperBound(0) + 1;
            int columns = result.Length / rows;

            dataGridViewMatrixResult_KKA.ColumnCount = columns;
            dataGridViewMatrixResult_KKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_KKA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_KKA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonReference_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-1 Корнилов Кирилл Андреевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = valueArray.GetUpperBound(0) + 1;
            int columns = valueArray.Length / rows;

            dataGridViewTaskMatrix_KKA.ColumnCount = columns;
            dataGridViewTaskMatrix_KKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskMatrix_KKA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTaskMatrix_KKA.Rows[i].Cells[j].Value = Convert.ToString(valueArray[i, j]);
                }
            }
        }
    }
}
