
namespace Tyuiu.KornilovKA.Sprint6.Task0.V15
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
            this.pictureBoxTask_KKA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KKA = new System.Windows.Forms.GroupBox();
            this.labelVarX_KKA = new System.Windows.Forms.Label();
            this.textBoxInputVarX_KKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutData_KKA = new System.Windows.Forms.GroupBox();
            this.textBoxOutputResult_KKA = new System.Windows.Forms.TextBox();
            this.labelResult_KKA = new System.Windows.Forms.Label();
            this.buttonDone_KKA = new System.Windows.Forms.Button();
            this.buttonHelp_KKA = new System.Windows.Forms.Button();
            this.groupBoxTask_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_KKA)).BeginInit();
            this.groupBoxInputData_KKA.SuspendLayout();
            this.groupBoxOutData_KKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KKA
            // 
            this.groupBoxTask_KKA.Controls.Add(this.pictureBoxTask_KKA);
            this.groupBoxTask_KKA.Controls.Add(this.textBoxTask_KKA);
            this.groupBoxTask_KKA.Location = new System.Drawing.Point(12, 29);
            this.groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            this.groupBoxTask_KKA.Size = new System.Drawing.Size(401, 183);
            this.groupBoxTask_KKA.TabIndex = 0;
            this.groupBoxTask_KKA.TabStop = false;
            this.groupBoxTask_KKA.Text = "Условие";
            // 
            // pictureBoxTask_KKA
            // 
            this.pictureBoxTask_KKA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_KKA.Image")));
            this.pictureBoxTask_KKA.Location = new System.Drawing.Point(7, 40);
            this.pictureBoxTask_KKA.Name = "pictureBoxTask_KKA";
            this.pictureBoxTask_KKA.Size = new System.Drawing.Size(244, 39);
            this.pictureBoxTask_KKA.TabIndex = 1;
            this.pictureBoxTask_KKA.TabStop = false;
            // 
            // textBoxTask_KKA
            // 
            this.textBoxTask_KKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KKA.Name = "textBoxTask_KKA";
            this.textBoxTask_KKA.ReadOnly = true;
            this.textBoxTask_KKA.Size = new System.Drawing.Size(183, 13);
            this.textBoxTask_KKA.TabIndex = 0;
            this.textBoxTask_KKA.TabStop = false;
            this.textBoxTask_KKA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInputData_KKA
            // 
            this.groupBoxInputData_KKA.Controls.Add(this.labelVarX_KKA);
            this.groupBoxInputData_KKA.Controls.Add(this.textBoxInputVarX_KKA);
            this.groupBoxInputData_KKA.Location = new System.Drawing.Point(12, 218);
            this.groupBoxInputData_KKA.Name = "groupBoxInputData_KKA";
            this.groupBoxInputData_KKA.Size = new System.Drawing.Size(190, 81);
            this.groupBoxInputData_KKA.TabIndex = 1;
            this.groupBoxInputData_KKA.TabStop = false;
            this.groupBoxInputData_KKA.Text = "Ввод данных";
            // 
            // labelVarX_KKA
            // 
            this.labelVarX_KKA.AutoSize = true;
            this.labelVarX_KKA.Location = new System.Drawing.Point(4, 28);
            this.labelVarX_KKA.Name = "labelVarX_KKA";
            this.labelVarX_KKA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_KKA.TabIndex = 1;
            this.labelVarX_KKA.Text = "Переменная X:";
            // 
            // textBoxInputVarX_KKA
            // 
            this.textBoxInputVarX_KKA.Location = new System.Drawing.Point(7, 44);
            this.textBoxInputVarX_KKA.Name = "textBoxInputVarX_KKA";
            this.textBoxInputVarX_KKA.Size = new System.Drawing.Size(112, 20);
            this.textBoxInputVarX_KKA.TabIndex = 0;
            this.textBoxInputVarX_KKA.TabStop = false;
            this.textBoxInputVarX_KKA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputVarX_KKA_KeyPress);
            // 
            // groupBoxOutData_KKA
            // 
            this.groupBoxOutData_KKA.Controls.Add(this.textBoxOutputResult_KKA);
            this.groupBoxOutData_KKA.Controls.Add(this.labelResult_KKA);
            this.groupBoxOutData_KKA.Location = new System.Drawing.Point(219, 218);
            this.groupBoxOutData_KKA.Name = "groupBoxOutData_KKA";
            this.groupBoxOutData_KKA.Size = new System.Drawing.Size(194, 81);
            this.groupBoxOutData_KKA.TabIndex = 2;
            this.groupBoxOutData_KKA.TabStop = false;
            this.groupBoxOutData_KKA.Text = "Вывод данных";
            // 
            // textBoxOutputResult_KKA
            // 
            this.textBoxOutputResult_KKA.Location = new System.Drawing.Point(7, 45);
            this.textBoxOutputResult_KKA.Name = "textBoxOutputResult_KKA";
            this.textBoxOutputResult_KKA.ReadOnly = true;
            this.textBoxOutputResult_KKA.Size = new System.Drawing.Size(117, 20);
            this.textBoxOutputResult_KKA.TabIndex = 1;
            this.textBoxOutputResult_KKA.TabStop = false;
            // 
            // labelResult_KKA
            // 
            this.labelResult_KKA.AutoSize = true;
            this.labelResult_KKA.Location = new System.Drawing.Point(7, 28);
            this.labelResult_KKA.Name = "labelResult_KKA";
            this.labelResult_KKA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KKA.TabIndex = 0;
            this.labelResult_KKA.Text = "Результат:";
            // 
            // buttonDone_KKA
            // 
            this.buttonDone_KKA.Location = new System.Drawing.Point(326, 306);
            this.buttonDone_KKA.Name = "buttonDone_KKA";
            this.buttonDone_KKA.Size = new System.Drawing.Size(87, 38);
            this.buttonDone_KKA.TabIndex = 3;
            this.buttonDone_KKA.TabStop = false;
            this.buttonDone_KKA.Text = "Выполнить";
            this.buttonDone_KKA.UseVisualStyleBackColor = true;
            this.buttonDone_KKA.Click += new System.EventHandler(this.buttonDone_KKA_Click);
            // 
            // buttonHelp_KKA
            // 
            this.buttonHelp_KKA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_KKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KKA.Location = new System.Drawing.Point(283, 305);
            this.buttonHelp_KKA.Name = "buttonHelp_KKA";
            this.buttonHelp_KKA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_KKA.TabIndex = 4;
            this.buttonHelp_KKA.TabStop = false;
            this.buttonHelp_KKA.Text = "?";
            this.buttonHelp_KKA.UseVisualStyleBackColor = false;
            this.buttonHelp_KKA.Click += new System.EventHandler(this.buttonHelp_KKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 353);
            this.Controls.Add(this.buttonHelp_KKA);
            this.Controls.Add(this.buttonDone_KKA);
            this.Controls.Add(this.groupBoxOutData_KKA);
            this.Controls.Add(this.groupBoxInputData_KKA);
            this.Controls.Add(this.groupBoxTask_KKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 15 | Корнилов К.А.";
            this.groupBoxTask_KKA.ResumeLayout(false);
            this.groupBoxTask_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_KKA)).EndInit();
            this.groupBoxInputData_KKA.ResumeLayout(false);
            this.groupBoxInputData_KKA.PerformLayout();
            this.groupBoxOutData_KKA.ResumeLayout(false);
            this.groupBoxOutData_KKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.PictureBox pictureBoxTask_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_KKA;
        private System.Windows.Forms.Label labelVarX_KKA;
        private System.Windows.Forms.TextBox textBoxInputVarX_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutData_KKA;
        private System.Windows.Forms.TextBox textBoxOutputResult_KKA;
        private System.Windows.Forms.Label labelResult_KKA;
        private System.Windows.Forms.Button buttonDone_KKA;
        private System.Windows.Forms.Button buttonHelp_KKA;
    }
}

