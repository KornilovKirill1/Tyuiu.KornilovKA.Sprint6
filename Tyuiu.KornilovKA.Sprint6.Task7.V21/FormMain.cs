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

using Tyuiu.KornilovKA.Sprint6.Task7.V21.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_KKA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KKA.ShowDialog();
            openFilePath = openFileDialogTask_KKA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_KKA.ColumnCount = columns;
            dataGridViewInput_KKA.RowCount = rows;
            dataGridViewOutput_KKA.ColumnCount = columns;
            dataGridViewOutput_KKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_KKA.Columns[i].Width = 25;
                dataGridViewOutput_KKA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_KKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KKA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_KKA.ColumnCount = 50;
            dataGridViewOutput_KKA.ColumnCount = 50;

            dataGridViewInput_KKA.RowCount = 50;
            dataGridViewOutput_KKA.RowCount = 50;

            panelInputMatrix_KKA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_KKA.Columns[i].Width = 25;
                dataGridViewOutput_KKA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_KKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KKA.Enabled = true;
        }

        private void buttonSave_KKA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KKA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KKA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KKA.ShowDialog();

            string path = saveFileDialogMatrix_KKA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if(fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_KKA.RowCount;
            int columns = dataGridViewOutput_KKA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_KKA.Rows[i].Cells[j].Value + ";";
                    } else
                    {
                        str = str + dataGridViewOutput_KKA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_KKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KKA.ToolTipTitle = "Выполнить";
        }

        private void buttonOpenFile_KKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KKA.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_KKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KKA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_KKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KKA.ToolTipTitle = "Справка";
        }

        private void buttonInfo_KKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
