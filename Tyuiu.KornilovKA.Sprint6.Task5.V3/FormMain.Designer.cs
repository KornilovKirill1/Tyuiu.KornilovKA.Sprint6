
namespace Tyuiu.KornilovKA.Sprint6.Task5.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTaskAndButtons_KKA = new System.Windows.Forms.Panel();
            this.panelOutputData_KKA = new System.Windows.Forms.Panel();
            this.panelGraphs_KKA = new System.Windows.Forms.Panel();
            this.splitterBetweenOutputAndGraphs_KKA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_KKA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_KKA = new System.Windows.Forms.GroupBox();
            this.buttonDone_KKA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KKA = new System.Windows.Forms.Button();
            this.buttonInfo_KKA = new System.Windows.Forms.Button();
            this.dataGridViewOutputData_KKA = new System.Windows.Forms.DataGridView();
            this.chartGraph_KKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTaskAndButtons_KKA.SuspendLayout();
            this.panelOutputData_KKA.SuspendLayout();
            this.panelGraphs_KKA.SuspendLayout();
            this.groupBoxTask_KKA.SuspendLayout();
            this.groupBoxOutputData_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_KKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskAndButtons_KKA
            // 
            this.panelTaskAndButtons_KKA.Controls.Add(this.buttonInfo_KKA);
            this.panelTaskAndButtons_KKA.Controls.Add(this.buttonOpenFile_KKA);
            this.panelTaskAndButtons_KKA.Controls.Add(this.buttonDone_KKA);
            this.panelTaskAndButtons_KKA.Controls.Add(this.groupBoxTask_KKA);
            this.panelTaskAndButtons_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskAndButtons_KKA.Location = new System.Drawing.Point(0, 0);
            this.panelTaskAndButtons_KKA.Name = "panelTaskAndButtons_KKA";
            this.panelTaskAndButtons_KKA.Size = new System.Drawing.Size(699, 69);
            this.panelTaskAndButtons_KKA.TabIndex = 0;
            // 
            // panelOutputData_KKA
            // 
            this.panelOutputData_KKA.Controls.Add(this.groupBoxOutputData_KKA);
            this.panelOutputData_KKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutputData_KKA.Location = new System.Drawing.Point(0, 69);
            this.panelOutputData_KKA.Name = "panelOutputData_KKA";
            this.panelOutputData_KKA.Padding = new System.Windows.Forms.Padding(3);
            this.panelOutputData_KKA.Size = new System.Drawing.Size(125, 392);
            this.panelOutputData_KKA.TabIndex = 1;
            // 
            // panelGraphs_KKA
            // 
            this.panelGraphs_KKA.Controls.Add(this.chartGraph_KKA);
            this.panelGraphs_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphs_KKA.Location = new System.Drawing.Point(125, 69);
            this.panelGraphs_KKA.Name = "panelGraphs_KKA";
            this.panelGraphs_KKA.Size = new System.Drawing.Size(574, 392);
            this.panelGraphs_KKA.TabIndex = 2;
            // 
            // splitterBetweenOutputAndGraphs_KKA
            // 
            this.splitterBetweenOutputAndGraphs_KKA.Location = new System.Drawing.Point(125, 69);
            this.splitterBetweenOutputAndGraphs_KKA.Name = "splitterBetweenOutputAndGraphs_KKA";
            this.splitterBetweenOutputAndGraphs_KKA.Size = new System.Drawing.Size(3, 392);
            this.splitterBetweenOutputAndGraphs_KKA.TabIndex = 3;
            this.splitterBetweenOutputAndGraphs_KKA.TabStop = false;
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(440, 60);
            this.groupBoxTask_KKA.TabIndex = 0;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие:";
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.Location = new System.Drawing.Point(9, 20);
            this.textBoxTask_KKA.Multiline = true;
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(425, 33);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. Вывести в" +
    "се вещественные числа.  Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutputData_KKA
            // 
            this.groupBoxOutputData_KKA.Controls.Add(this.dataGridViewOutputData_KKA);
            this.groupBoxOutputData_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KKA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutputData_KKA.Name = "groupBoxOutputData_KKA";
            this.groupBoxOutputData_KKA.Size = new System.Drawing.Size(119, 386);
            this.groupBoxOutputData_KKA.TabIndex = 0;
            this.groupBoxOutputData_KKA.TabStop = false;
            this.groupBoxOutputData_KKA.Text = "Вывод данных:";
            // 
            // buttonDone_KKA
            // 
            this.buttonDone_KKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_KKA.Location = new System.Drawing.Point(450, 9);
            this.buttonDone_KKA.Name = "buttonDone_KKA";
            this.buttonDone_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_KKA.TabIndex = 1;
            this.buttonDone_KKA.TabStop = false;
            this.buttonDone_KKA.Text = "Выполнить";
            this.buttonDone_KKA.UseVisualStyleBackColor = false;
            this.buttonDone_KKA.Click += new System.EventHandler(this.buttonDone_KKA_Click);
            // 
            // buttonOpenFile_KKA
            // 
            this.buttonOpenFile_KKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_KKA.Location = new System.Drawing.Point(531, 9);
            this.buttonOpenFile_KKA.Name = "buttonOpenFile_KKA";
            this.buttonOpenFile_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_KKA.TabIndex = 2;
            this.buttonOpenFile_KKA.TabStop = false;
            this.buttonOpenFile_KKA.Text = "Открыть файл";
            this.buttonOpenFile_KKA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KKA.Click += new System.EventHandler(this.buttonOpenFile_KKA_Click);
            // 
            // buttonInfo_KKA
            // 
            this.buttonInfo_KKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KKA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInfo_KKA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_KKA.Location = new System.Drawing.Point(612, 9);
            this.buttonInfo_KKA.Name = "buttonInfo_KKA";
            this.buttonInfo_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonInfo_KKA.TabIndex = 3;
            this.buttonInfo_KKA.TabStop = false;
            this.buttonInfo_KKA.Text = "Справка";
            this.buttonInfo_KKA.UseVisualStyleBackColor = false;
            this.buttonInfo_KKA.Click += new System.EventHandler(this.buttonInfo_KKA_Click);
            // 
            // dataGridViewOutputData_KKA
            // 
            this.dataGridViewOutputData_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputData_KKA.ColumnHeadersVisible = false;
            this.dataGridViewOutputData_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputData_KKA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutputData_KKA.Name = "dataGridViewOutputData_KKA";
            this.dataGridViewOutputData_KKA.RowHeadersVisible = false;
            this.dataGridViewOutputData_KKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutputData_KKA.Size = new System.Drawing.Size(113, 367);
            this.dataGridViewOutputData_KKA.TabIndex = 0;
            this.dataGridViewOutputData_KKA.TabStop = false;
            // 
            // chartGraph_KKA
            // 
            chartArea10.Name = "ChartArea1";
            this.chartGraph_KKA.ChartAreas.Add(chartArea10);
            this.chartGraph_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartGraph_KKA.Legends.Add(legend10);
            this.chartGraph_KKA.Location = new System.Drawing.Point(0, 0);
            this.chartGraph_KKA.Name = "chartGraph_KKA";
            this.chartGraph_KKA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series10.ChartArea = "ChartArea1";
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartGraph_KKA.Series.Add(series10);
            this.chartGraph_KKA.Size = new System.Drawing.Size(574, 392);
            this.chartGraph_KKA.TabIndex = 0;
            this.chartGraph_KKA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.splitterBetweenOutputAndGraphs_KKA);
            this.Controls.Add(this.panelGraphs_KKA);
            this.Controls.Add(this.panelOutputData_KKA);
            this.Controls.Add(this.panelTaskAndButtons_KKA);
            this.MinimumSize = new System.Drawing.Size(715, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Корнилов К.А.";
            this.panelTaskAndButtons_KKA.ResumeLayout(false);
            this.panelOutputData_KKA.ResumeLayout(false);
            this.panelGraphs_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            this.groupBoxOutputData_KKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_KKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskAndButtons_KKA;
        private System.Windows.Forms.Button buttonDone_KKA;
        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.Panel panelOutputData_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KKA;
        private System.Windows.Forms.Panel panelGraphs_KKA;
        private System.Windows.Forms.Splitter splitterBetweenOutputAndGraphs_KKA;
        private System.Windows.Forms.Button buttonInfo_KKA;
        private System.Windows.Forms.Button buttonOpenFile_KKA;
        private System.Windows.Forms.DataGridView dataGridViewOutputData_KKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_KKA;
    }
}

