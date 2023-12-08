
namespace Tyuiu.KornilovKA.Sprint6.Task6.V17
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_KKA = new System.Windows.Forms.Panel();
            this.buttonInfo_KKA = new System.Windows.Forms.Button();
            this.buttonDone_KKA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KKA = new System.Windows.Forms.Button();
            this.panelTask_KKA = new System.Windows.Forms.Panel();
            this.groupBoxTask_KKA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.panelLoadFromFile_KKA = new System.Windows.Forms.Panel();
            this.groupBoxLoadFile_KKA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFile_KKA = new System.Windows.Forms.TextBox();
            this.panelResult_KKA = new System.Windows.Forms.Panel();
            this.groupBoxResult_KKA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KKA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_KKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons_KKA = new System.Windows.Forms.ToolTip(this.components);
            this.splitterBetweenInputAndOutput_KKA = new System.Windows.Forms.Splitter();
            this.panelButtons_KKA.SuspendLayout();
            this.panelTask_KKA.SuspendLayout();
            this.groupBoxTask_KKA.SuspendLayout();
            this.panelLoadFromFile_KKA.SuspendLayout();
            this.groupBoxLoadFile_KKA.SuspendLayout();
            this.panelResult_KKA.SuspendLayout();
            this.groupBoxResult_KKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_KKA
            // 
            this.panelButtons_KKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_KKA.Controls.Add(this.buttonInfo_KKA);
            this.panelButtons_KKA.Controls.Add(this.buttonDone_KKA);
            this.panelButtons_KKA.Controls.Add(this.buttonOpenFile_KKA);
            this.panelButtons_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_KKA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_KKA.Name = "panelButtons_KKA";
            this.panelButtons_KKA.Size = new System.Drawing.Size(884, 66);
            this.panelButtons_KKA.TabIndex = 0;
            // 
            // buttonInfo_KKA
            // 
            this.buttonInfo_KKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KKA.BackgroundImage = global::Tyuiu.KornilovKA.Sprint6.Task6.V17.Properties.Resources.help;
            this.buttonInfo_KKA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_KKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo_KKA.Location = new System.Drawing.Point(804, 4);
            this.buttonInfo_KKA.Name = "buttonInfo_KKA";
            this.buttonInfo_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonInfo_KKA.TabIndex = 2;
            this.buttonInfo_KKA.TabStop = false;
            this.toolTipButtons_KKA.SetToolTip(this.buttonInfo_KKA, "Сведения о программе");
            this.buttonInfo_KKA.UseVisualStyleBackColor = true;
            this.buttonInfo_KKA.Click += new System.EventHandler(this.buttonInfo_KKA_Click);
            this.buttonInfo_KKA.MouseEnter += new System.EventHandler(this.buttonInfo_KKA_MouseEnter);
            // 
            // buttonDone_KKA
            // 
            this.buttonDone_KKA.BackgroundImage = global::Tyuiu.KornilovKA.Sprint6.Task6.V17.Properties.Resources.page_white_go;
            this.buttonDone_KKA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_KKA.Enabled = false;
            this.buttonDone_KKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_KKA.Location = new System.Drawing.Point(86, 4);
            this.buttonDone_KKA.Name = "buttonDone_KKA";
            this.buttonDone_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_KKA.TabIndex = 1;
            this.buttonDone_KKA.TabStop = false;
            this.toolTipButtons_KKA.SetToolTip(this.buttonDone_KKA, "Находит третье слово в каждой строчке и\r\nобъединяет эти слова в одну строчку");
            this.buttonDone_KKA.UseVisualStyleBackColor = true;
            this.buttonDone_KKA.Click += new System.EventHandler(this.buttonDone_KKA_Click);
            this.buttonDone_KKA.MouseEnter += new System.EventHandler(this.buttonDone_KKA_MouseEnter);
            // 
            // buttonOpenFile_KKA
            // 
            this.buttonOpenFile_KKA.BackgroundImage = global::Tyuiu.KornilovKA.Sprint6.Task6.V17.Properties.Resources.folder_page;
            this.buttonOpenFile_KKA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_KKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile_KKA.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_KKA.Name = "buttonOpenFile_KKA";
            this.buttonOpenFile_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_KKA.TabIndex = 0;
            this.buttonOpenFile_KKA.TabStop = false;
            this.toolTipButtons_KKA.SetToolTip(this.buttonOpenFile_KKA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_KKA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KKA.Click += new System.EventHandler(this.buttonOpenFile_KKA_Click);
            this.buttonOpenFile_KKA.MouseEnter += new System.EventHandler(this.buttonOpenFile_KKA_MouseEnter);
            // 
            // panelTask_KKA
            // 
            this.panelTask_KKA.Controls.Add(this.groupBoxTask_KKA);
            this.panelTask_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_KKA.Location = new System.Drawing.Point(0, 66);
            this.panelTask_KKA.Name = "panelTask_KKA";
            this.panelTask_KKA.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_KKA.Size = new System.Drawing.Size(884, 68);
            this.panelTask_KKA.TabIndex = 1;
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(874, 58);
            this.groupBoxTask_KKA.TabIndex = 0;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие:";
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_KKA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_KKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KKA.Multiline = true;
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(861, 32);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = resources.GetString("textBoxTask_KKA.Text");
            // 
            // panelLoadFromFile_KKA
            // 
            this.panelLoadFromFile_KKA.Controls.Add(this.groupBoxLoadFile_KKA);
            this.panelLoadFromFile_KKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoadFromFile_KKA.Location = new System.Drawing.Point(0, 134);
            this.panelLoadFromFile_KKA.Name = "panelLoadFromFile_KKA";
            this.panelLoadFromFile_KKA.Padding = new System.Windows.Forms.Padding(5);
            this.panelLoadFromFile_KKA.Size = new System.Drawing.Size(442, 377);
            this.panelLoadFromFile_KKA.TabIndex = 2;
            // 
            // groupBoxLoadFile_KKA
            // 
            this.groupBoxLoadFile_KKA.Controls.Add(this.textBoxLoadFile_KKA);
            this.groupBoxLoadFile_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFile_KKA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxLoadFile_KKA.Name = "groupBoxLoadFile_KKA";
            this.groupBoxLoadFile_KKA.Size = new System.Drawing.Size(432, 367);
            this.groupBoxLoadFile_KKA.TabIndex = 0;
            this.groupBoxLoadFile_KKA.TabStop = false;
            this.groupBoxLoadFile_KKA.Text = "Ввод:";
            // 
            // textBoxLoadFile_KKA
            // 
            this.textBoxLoadFile_KKA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoadFile_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFile_KKA.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFile_KKA.Multiline = true;
            this.textBoxLoadFile_KKA.Name = "textBoxLoadFile_KKA";
            this.textBoxLoadFile_KKA.ReadOnly = true;
            this.textBoxLoadFile_KKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFile_KKA.Size = new System.Drawing.Size(426, 348);
            this.textBoxLoadFile_KKA.TabIndex = 0;
            this.textBoxLoadFile_KKA.TabStop = false;
            // 
            // panelResult_KKA
            // 
            this.panelResult_KKA.Controls.Add(this.groupBoxResult_KKA);
            this.panelResult_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_KKA.Location = new System.Drawing.Point(442, 134);
            this.panelResult_KKA.Name = "panelResult_KKA";
            this.panelResult_KKA.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_KKA.Size = new System.Drawing.Size(442, 377);
            this.panelResult_KKA.TabIndex = 3;
            // 
            // groupBoxResult_KKA
            // 
            this.groupBoxResult_KKA.Controls.Add(this.textBoxResult_KKA);
            this.groupBoxResult_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_KKA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_KKA.Name = "groupBoxResult_KKA";
            this.groupBoxResult_KKA.Size = new System.Drawing.Size(432, 367);
            this.groupBoxResult_KKA.TabIndex = 0;
            this.groupBoxResult_KKA.TabStop = false;
            this.groupBoxResult_KKA.Text = "Вывод:";
            // 
            // textBoxResult_KKA
            // 
            this.textBoxResult_KKA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KKA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_KKA.Multiline = true;
            this.textBoxResult_KKA.Name = "textBoxResult_KKA";
            this.textBoxResult_KKA.ReadOnly = true;
            this.textBoxResult_KKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KKA.Size = new System.Drawing.Size(426, 348);
            this.textBoxResult_KKA.TabIndex = 0;
            this.textBoxResult_KKA.TabStop = false;
            // 
            // openFileDialogTask_KKA
            // 
            this.openFileDialogTask_KKA.FileName = "openFileDialogTask_KKA";
            // 
            // toolTipButtons_KKA
            // 
            this.toolTipButtons_KKA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_KKA.ToolTipTitle = "Подсказка";
            // 
            // splitterBetweenInputAndOutput_KKA
            // 
            this.splitterBetweenInputAndOutput_KKA.Location = new System.Drawing.Point(442, 134);
            this.splitterBetweenInputAndOutput_KKA.Name = "splitterBetweenInputAndOutput_KKA";
            this.splitterBetweenInputAndOutput_KKA.Size = new System.Drawing.Size(3, 377);
            this.splitterBetweenInputAndOutput_KKA.TabIndex = 4;
            this.splitterBetweenInputAndOutput_KKA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitterBetweenInputAndOutput_KKA);
            this.Controls.Add(this.panelResult_KKA);
            this.Controls.Add(this.panelLoadFromFile_KKA);
            this.Controls.Add(this.panelTask_KKA);
            this.Controls.Add(this.panelButtons_KKA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Корнилов К.А.";
            this.panelButtons_KKA.ResumeLayout(false);
            this.panelTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            this.panelLoadFromFile_KKA.ResumeLayout(false);
            this.groupBoxLoadFile_KKA.ResumeLayout(false);
            this.groupBoxLoadFile_KKA.PerformLayout();
            this.panelResult_KKA.ResumeLayout(false);
            this.groupBoxResult_KKA.ResumeLayout(false);
            this.groupBoxResult_KKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_KKA;
        private System.Windows.Forms.Panel panelTask_KKA;
        private System.Windows.Forms.Button buttonDone_KKA;
        private System.Windows.Forms.Button buttonOpenFile_KKA;
        private System.Windows.Forms.Button buttonInfo_KKA;
        private System.Windows.Forms.Panel panelLoadFromFile_KKA;
        private System.Windows.Forms.Panel panelResult_KKA;
        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxLoadFile_KKA;
        private System.Windows.Forms.TextBox textBoxLoadFile_KKA;
        private System.Windows.Forms.GroupBox groupBoxResult_KKA;
        private System.Windows.Forms.TextBox textBoxResult_KKA;
        private System.Windows.Forms.ToolTip toolTipButtons_KKA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KKA;
        private System.Windows.Forms.Splitter splitterBetweenInputAndOutput_KKA;
    }
}

