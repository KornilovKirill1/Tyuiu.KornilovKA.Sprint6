
namespace Tyuiu.KornilovKA.Sprint6.Task2.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KKA = new System.Windows.Forms.GroupBox();
            this.pictureBoxEquation_KKA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KKA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_KKA = new System.Windows.Forms.Label();
            this.labelStartValue_KKA = new System.Windows.Forms.Label();
            this.textBoxStopValue_KKA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_KKA = new System.Windows.Forms.TextBox();
            this.buttonReference_KKA = new System.Windows.Forms.Button();
            this.buttonExecute_KKA = new System.Windows.Forms.Button();
            this.groupBoxOutputData_KKA = new System.Windows.Forms.GroupBox();
            this.labelResult_KKA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_KKA = new System.Windows.Forms.DataGridView();
            this.chartFunction_KKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_KKA)).BeginInit();
            this.groupBoxInputData_KKA.SuspendLayout();
            this.groupBoxOutputData_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.pictureBoxEquation_KKA);
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(455, 227);
            this.groupBoxTask_KKA.TabIndex = 1;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие";
            // 
            // pictureBoxEquation_KKA
            // 
            this.pictureBoxEquation_KKA.Image = global::Tyuiu.KornilovKA.Sprint6.Task2.V21.Properties.Resources.task2;
            this.pictureBoxEquation_KKA.Location = new System.Drawing.Point(10, 57);
            this.pictureBoxEquation_KKA.Name = "pictureBoxEquation_KKA";
            this.pictureBoxEquation_KKA.Size = new System.Drawing.Size(264, 36);
            this.pictureBoxEquation_KKA.TabIndex = 1;
            this.pictureBoxEquation_KKA.TabStop = false;
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KKA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_KKA.Multiline = true;
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(335, 31);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxInputData_KKA
            // 
            this.groupBoxInputData_KKA.Controls.Add(this.labelStopValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.labelStartValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.textBoxStopValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.textBoxStartValue_KKA);
            this.groupBoxInputData_KKA.Location = new System.Drawing.Point(12, 245);
            this.groupBoxInputData_KKA.Name = "groupBoxInputData_KKA";
            this.groupBoxInputData_KKA.Size = new System.Drawing.Size(260, 60);
            this.groupBoxInputData_KKA.TabIndex = 2;
            this.groupBoxInputData_KKA.TabStop = false;
            this.groupBoxInputData_KKA.Text = "Ввод данных";
            // 
            // labelStopValue_KKA
            // 
            this.labelStopValue_KKA.AutoSize = true;
            this.labelStopValue_KKA.Location = new System.Drawing.Point(134, 20);
            this.labelStopValue_KKA.Name = "labelStopValue_KKA";
            this.labelStopValue_KKA.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_KKA.TabIndex = 3;
            this.labelStopValue_KKA.Text = "Конец шага:";
            // 
            // labelStartValue_KKA
            // 
            this.labelStartValue_KKA.AutoSize = true;
            this.labelStartValue_KKA.Location = new System.Drawing.Point(7, 20);
            this.labelStartValue_KKA.Name = "labelStartValue_KKA";
            this.labelStartValue_KKA.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_KKA.TabIndex = 2;
            this.labelStartValue_KKA.Text = "Старт шага:";
            // 
            // textBoxStopValue_KKA
            // 
            this.textBoxStopValue_KKA.Location = new System.Drawing.Point(133, 34);
            this.textBoxStopValue_KKA.Name = "textBoxStopValue_KKA";
            this.textBoxStopValue_KKA.Size = new System.Drawing.Size(120, 20);
            this.textBoxStopValue_KKA.TabIndex = 1;
            this.textBoxStopValue_KKA.TabStop = false;
            this.textBoxStopValue_KKA.Text = "5";
            // 
            // textBoxStartValue_KKA
            // 
            this.textBoxStartValue_KKA.Location = new System.Drawing.Point(7, 34);
            this.textBoxStartValue_KKA.Name = "textBoxStartValue_KKA";
            this.textBoxStartValue_KKA.Size = new System.Drawing.Size(120, 20);
            this.textBoxStartValue_KKA.TabIndex = 0;
            this.textBoxStartValue_KKA.TabStop = false;
            this.textBoxStartValue_KKA.Text = "-5";
            // 
            // buttonReference_KKA
            // 
            this.buttonReference_KKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReference_KKA.Location = new System.Drawing.Point(278, 250);
            this.buttonReference_KKA.Name = "buttonReference_KKA";
            this.buttonReference_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonReference_KKA.TabIndex = 4;
            this.buttonReference_KKA.TabStop = false;
            this.buttonReference_KKA.Text = "Справка";
            this.buttonReference_KKA.UseVisualStyleBackColor = false;
            this.buttonReference_KKA.Click += new System.EventHandler(this.buttonReference_KKA_Click);
            // 
            // buttonExecute_KKA
            // 
            this.buttonExecute_KKA.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_KKA.Location = new System.Drawing.Point(359, 250);
            this.buttonExecute_KKA.Name = "buttonExecute_KKA";
            this.buttonExecute_KKA.Size = new System.Drawing.Size(108, 55);
            this.buttonExecute_KKA.TabIndex = 5;
            this.buttonExecute_KKA.TabStop = false;
            this.buttonExecute_KKA.Text = "Выполнить";
            this.buttonExecute_KKA.UseVisualStyleBackColor = false;
            this.buttonExecute_KKA.Click += new System.EventHandler(this.buttonExecute_KKA_Click);
            this.buttonExecute_KKA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExecute_KKA_MouseDown);
            this.buttonExecute_KKA.MouseEnter += new System.EventHandler(this.buttonExecute_KKA_MouseEnter);
            this.buttonExecute_KKA.MouseLeave += new System.EventHandler(this.buttonExecute_KKA_MouseLeave);
            // 
            // groupBoxOutputData_KKA
            // 
            this.groupBoxOutputData_KKA.Controls.Add(this.chartFunction_KKA);
            this.groupBoxOutputData_KKA.Controls.Add(this.dataGridViewFunction_KKA);
            this.groupBoxOutputData_KKA.Controls.Add(this.labelResult_KKA);
            this.groupBoxOutputData_KKA.Location = new System.Drawing.Point(473, 12);
            this.groupBoxOutputData_KKA.Name = "groupBoxOutputData_KKA";
            this.groupBoxOutputData_KKA.Size = new System.Drawing.Size(544, 293);
            this.groupBoxOutputData_KKA.TabIndex = 6;
            this.groupBoxOutputData_KKA.TabStop = false;
            this.groupBoxOutputData_KKA.Text = "Вывод данных";
            // 
            // labelResult_KKA
            // 
            this.labelResult_KKA.AutoSize = true;
            this.labelResult_KKA.Location = new System.Drawing.Point(7, 20);
            this.labelResult_KKA.Name = "labelResult_KKA";
            this.labelResult_KKA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KKA.TabIndex = 1;
            this.labelResult_KKA.Text = "Результат:";
            // 
            // dataGridViewFunction_KKA
            // 
            this.dataGridViewFunction_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KKA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_KKA.Location = new System.Drawing.Point(7, 37);
            this.dataGridViewFunction_KKA.Name = "dataGridViewFunction_KKA";
            this.dataGridViewFunction_KKA.RowHeadersVisible = false;
            this.dataGridViewFunction_KKA.Size = new System.Drawing.Size(124, 248);
            this.dataGridViewFunction_KKA.TabIndex = 2;
            // 
            // chartFunction_KKA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_KKA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_KKA.Legends.Add(legend5);
            this.chartFunction_KKA.Location = new System.Drawing.Point(137, 35);
            this.chartFunction_KKA.Name = "chartFunction_KKA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_KKA.Series.Add(series5);
            this.chartFunction_KKA.Size = new System.Drawing.Size(401, 250);
            this.chartFunction_KKA.TabIndex = 3;
            this.chartFunction_KKA.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.groupBoxOutputData_KKA);
            this.Controls.Add(this.buttonExecute_KKA);
            this.Controls.Add(this.buttonReference_KKA);
            this.Controls.Add(this.groupBoxInputData_KKA);
            this.Controls.Add(this.groupBoxTask_KKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 21 | Корнилов К.А.";
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_KKA)).EndInit();
            this.groupBoxInputData_KKA.ResumeLayout(false);
            this.groupBoxInputData_KKA.PerformLayout();
            this.groupBoxOutputData_KKA.ResumeLayout(false);
            this.groupBoxOutputData_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.PictureBox pictureBoxEquation_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_KKA;
        private System.Windows.Forms.Label labelStopValue_KKA;
        private System.Windows.Forms.Label labelStartValue_KKA;
        private System.Windows.Forms.TextBox textBoxStopValue_KKA;
        private System.Windows.Forms.TextBox textBoxStartValue_KKA;
        private System.Windows.Forms.Button buttonReference_KKA;
        private System.Windows.Forms.Button buttonExecute_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KKA;
        private System.Windows.Forms.Label labelResult_KKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KKA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

