
namespace Tyuiu.KornilovKA.Sprint6.Task1.V9
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
            this.groupBoxTask_KKA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_KKA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KKA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_KKA = new System.Windows.Forms.Label();
            this.labelStartValue_KKA = new System.Windows.Forms.Label();
            this.textBoxStopValue_KKA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_KKA = new System.Windows.Forms.TextBox();
            this.buttonExecute_KKA = new System.Windows.Forms.Button();
            this.buttonReference_KKA = new System.Windows.Forms.Button();
            this.groupBoxOutputData_KKA = new System.Windows.Forms.GroupBox();
            this.labelResult_KKA = new System.Windows.Forms.Label();
            this.textBoxResult_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_KKA)).BeginInit();
            this.groupBoxInputData_KKA.SuspendLayout();
            this.groupBoxOutputData_KKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.pictureBoxTask_KKA);
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(455, 227);
            this.groupBoxTask_KKA.TabIndex = 0;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие";
            // 
            // pictureBoxTask_KKA
            // 
            this.pictureBoxTask_KKA.Image = global::Tyuiu.KornilovKA.Sprint6.Task1.V9.Properties.Resources.task1;
            this.pictureBoxTask_KKA.Location = new System.Drawing.Point(10, 57);
            this.pictureBoxTask_KKA.Name = "pictureBoxTask_KKA";
            this.pictureBoxTask_KKA.Size = new System.Drawing.Size(240, 40);
            this.pictureBoxTask_KKA.TabIndex = 1;
            this.pictureBoxTask_KKA.TabStop = false;
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KKA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_KKA.Multiline = true;
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(269, 31);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблице." +
    "";
            // 
            // groupBoxInputData_KKA
            // 
            this.groupBoxInputData_KKA.Controls.Add(this.labelStopValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.labelStartValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.textBoxStopValue_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.textBoxStartValue_KKA);
            this.groupBoxInputData_KKA.Location = new System.Drawing.Point(13, 246);
            this.groupBoxInputData_KKA.Name = "groupBoxInputData_KKA";
            this.groupBoxInputData_KKA.Size = new System.Drawing.Size(260, 60);
            this.groupBoxInputData_KKA.TabIndex = 1;
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
            // buttonExecute_KKA
            // 
            this.buttonExecute_KKA.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_KKA.Location = new System.Drawing.Point(360, 251);
            this.buttonExecute_KKA.Name = "buttonExecute_KKA";
            this.buttonExecute_KKA.Size = new System.Drawing.Size(108, 55);
            this.buttonExecute_KKA.TabIndex = 2;
            this.buttonExecute_KKA.TabStop = false;
            this.buttonExecute_KKA.Text = "Выполнить";
            this.buttonExecute_KKA.UseVisualStyleBackColor = false;
            this.buttonExecute_KKA.Click += new System.EventHandler(this.buttonExecute_KKA_Click);
            // 
            // buttonReference_KKA
            // 
            this.buttonReference_KKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReference_KKA.Location = new System.Drawing.Point(279, 251);
            this.buttonReference_KKA.Name = "buttonReference_KKA";
            this.buttonReference_KKA.Size = new System.Drawing.Size(75, 55);
            this.buttonReference_KKA.TabIndex = 3;
            this.buttonReference_KKA.TabStop = false;
            this.buttonReference_KKA.Text = "Справка";
            this.buttonReference_KKA.UseVisualStyleBackColor = false;
            this.buttonReference_KKA.Click += new System.EventHandler(this.buttonReference_KKA_Click);
            // 
            // groupBoxOutputData_KKA
            // 
            this.groupBoxOutputData_KKA.Controls.Add(this.labelResult_KKA);
            this.groupBoxOutputData_KKA.Controls.Add(this.textBoxResult_KKA);
            this.groupBoxOutputData_KKA.Location = new System.Drawing.Point(475, 13);
            this.groupBoxOutputData_KKA.Name = "groupBoxOutputData_KKA";
            this.groupBoxOutputData_KKA.Size = new System.Drawing.Size(233, 293);
            this.groupBoxOutputData_KKA.TabIndex = 4;
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
            // textBoxResult_KKA
            // 
            this.textBoxResult_KKA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_KKA.Location = new System.Drawing.Point(7, 36);
            this.textBoxResult_KKA.Multiline = true;
            this.textBoxResult_KKA.Name = "textBoxResult_KKA";
            this.textBoxResult_KKA.ReadOnly = true;
            this.textBoxResult_KKA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResult_KKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KKA.Size = new System.Drawing.Size(220, 251);
            this.textBoxResult_KKA.TabIndex = 0;
            this.textBoxResult_KKA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.groupBoxOutputData_KKA);
            this.Controls.Add(this.buttonReference_KKA);
            this.Controls.Add(this.buttonExecute_KKA);
            this.Controls.Add(this.groupBoxInputData_KKA);
            this.Controls.Add(this.groupBoxTask_KKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 9 | Корнилов К.А.";
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_KKA)).EndInit();
            this.groupBoxInputData_KKA.ResumeLayout(false);
            this.groupBoxInputData_KKA.PerformLayout();
            this.groupBoxOutputData_KKA.ResumeLayout(false);
            this.groupBoxOutputData_KKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_KKA;
        private System.Windows.Forms.Button buttonExecute_KKA;
        private System.Windows.Forms.Button buttonReference_KKA;
        private System.Windows.Forms.Label labelStopValue_KKA;
        private System.Windows.Forms.Label labelStartValue_KKA;
        private System.Windows.Forms.TextBox textBoxStopValue_KKA;
        private System.Windows.Forms.TextBox textBoxStartValue_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KKA;
        private System.Windows.Forms.Label labelResult_KKA;
        private System.Windows.Forms.TextBox textBoxResult_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.PictureBox pictureBoxTask_KKA;
    }
}

