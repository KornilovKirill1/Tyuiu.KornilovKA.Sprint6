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

using Tyuiu.KornilovKA.Sprint6.Task6.V17.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_KKA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KKA.FlatStyle = FlatStyle.Flat;
            buttonDone_KKA.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDone_KKA.FlatAppearance.BorderSize = 2;
        }

        private void buttonOpenFile_KKA_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile_KKA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KKA.FlatAppearance.BorderColor = Color.DarkGray;
            buttonOpenFile_KKA.FlatAppearance.BorderSize = 2;
        }

        private void buttonInfo_KKA_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo_KKA.FlatStyle = FlatStyle.Flat;
            buttonInfo_KKA.FlatAppearance.BorderColor = Color.DarkGray;
            buttonInfo_KKA.FlatAppearance.BorderSize = 2;
        }

        private void buttonOpenFile_KKA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KKA.ShowDialog();
            openFilePath = openFileDialogTask_KKA.FileName;
            textBoxLoadFile_KKA.Text = File.ReadAllText(openFilePath);
            groupBoxLoadFile_KKA.Text = groupBoxLoadFile_KKA.Text + " " + openFileDialogTask_KKA.FileName;
            buttonDone_KKA.Enabled = true;
        }

        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            textBoxResult_KKA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_KKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
