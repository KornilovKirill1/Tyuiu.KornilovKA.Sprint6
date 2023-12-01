
namespace Tyuiu.KornilovKA.Sprint6.Task3.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_KKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewTaskMatrix_KKA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_KKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixResult_KKA = new System.Windows.Forms.DataGridView();
            this.labelResult_KKA = new System.Windows.Forms.Label();
            this.buttonReference_KKA = new System.Windows.Forms.Button();
            this.buttonDone_KKA = new System.Windows.Forms.Button();
            this.groupBoxTask_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_KKA)).BeginInit();
            this.groupBoxOutputData_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.dataGridViewTaskMatrix_KKA);
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(449, 208);
            this.groupBoxTask_KKA.TabIndex = 0;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие";
            // 
            // dataGridViewTaskMatrix_KKA
            // 
            this.dataGridViewTaskMatrix_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_KKA.ColumnHeadersVisible = false;
            this.dataGridViewTaskMatrix_KKA.Location = new System.Drawing.Point(223, 12);
            this.dataGridViewTaskMatrix_KKA.Name = "dataGridViewTaskMatrix_KKA";
            this.dataGridViewTaskMatrix_KKA.RowHeadersVisible = false;
            this.dataGridViewTaskMatrix_KKA.Size = new System.Drawing.Size(220, 190);
            this.dataGridViewTaskMatrix_KKA.TabIndex = 1;
            this.dataGridViewTaskMatrix_KKA.TabStop = false;
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KKA.Multiline = true;
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(210, 111);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = resources.GetString("textBoxTask_KKA.Text");
            // 
            // groupBoxOutputData_KKA
            // 
            this.groupBoxOutputData_KKA.Controls.Add(this.dataGridViewMatrixResult_KKA);
            this.groupBoxOutputData_KKA.Controls.Add(this.labelResult_KKA);
            this.groupBoxOutputData_KKA.Location = new System.Drawing.Point(468, 13);
            this.groupBoxOutputData_KKA.Name = "groupBoxOutputData_KKA";
            this.groupBoxOutputData_KKA.Size = new System.Drawing.Size(173, 170);
            this.groupBoxOutputData_KKA.TabIndex = 5;
            this.groupBoxOutputData_KKA.TabStop = false;
            this.groupBoxOutputData_KKA.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_KKA
            // 
            this.dataGridViewMatrixResult_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_KKA.ColumnHeadersVisible = false;
            this.dataGridViewMatrixResult_KKA.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewMatrixResult_KKA.Name = "dataGridViewMatrixResult_KKA";
            this.dataGridViewMatrixResult_KKA.ReadOnly = true;
            this.dataGridViewMatrixResult_KKA.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_KKA.Size = new System.Drawing.Size(153, 127);
            this.dataGridViewMatrixResult_KKA.TabIndex = 2;
            this.dataGridViewMatrixResult_KKA.TabStop = false;
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
            // buttonReference_KKA
            // 
            this.buttonReference_KKA.Location = new System.Drawing.Point(468, 198);
            this.buttonReference_KKA.Name = "buttonReference_KKA";
            this.buttonReference_KKA.Size = new System.Drawing.Size(26, 23);
            this.buttonReference_KKA.TabIndex = 6;
            this.buttonReference_KKA.TabStop = false;
            this.buttonReference_KKA.Text = "?";
            this.buttonReference_KKA.UseVisualStyleBackColor = true;
            this.buttonReference_KKA.Click += new System.EventHandler(this.buttonReference_KKA_Click);
            // 
            // buttonDone_KKA
            // 
            this.buttonDone_KKA.Location = new System.Drawing.Point(566, 198);
            this.buttonDone_KKA.Name = "buttonDone_KKA";
            this.buttonDone_KKA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_KKA.TabIndex = 7;
            this.buttonDone_KKA.TabStop = false;
            this.buttonDone_KKA.Text = "Выполнить";
            this.buttonDone_KKA.UseVisualStyleBackColor = true;
            this.buttonDone_KKA.Click += new System.EventHandler(this.buttonDone_KKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 233);
            this.Controls.Add(this.buttonDone_KKA);
            this.Controls.Add(this.buttonReference_KKA);
            this.Controls.Add(this.groupBoxOutputData_KKA);
            this.Controls.Add(this.groupBoxTask_KKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Корнилов К.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_KKA)).EndInit();
            this.groupBoxOutputData_KKA.ResumeLayout(false);
            this.groupBoxOutputData_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KKA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_KKA;
        private System.Windows.Forms.Label labelResult_KKA;
        private System.Windows.Forms.Button buttonReference_KKA;
        private System.Windows.Forms.Button buttonDone_KKA;
    }
}

