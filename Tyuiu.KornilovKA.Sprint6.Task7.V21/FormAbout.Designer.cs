﻿
namespace Tyuiu.KornilovKA.Sprint6.Task7.V21
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonDone_KKA = new System.Windows.Forms.Button();
            this.labelInfo_KKA = new System.Windows.Forms.Label();
            this.pictureBoxDeveloper_KKA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_KKA
            // 
            this.buttonDone_KKA.Location = new System.Drawing.Point(345, 133);
            this.buttonDone_KKA.Name = "buttonDone_KKA";
            this.buttonDone_KKA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_KKA.TabIndex = 5;
            this.buttonDone_KKA.TabStop = false;
            this.buttonDone_KKA.Text = "Ok";
            this.buttonDone_KKA.UseVisualStyleBackColor = true;
            this.buttonDone_KKA.Click += new System.EventHandler(this.buttonDone_KKA_Click);
            // 
            // labelInfo_KKA
            // 
            this.labelInfo_KKA.AutoSize = true;
            this.labelInfo_KKA.Location = new System.Drawing.Point(120, 9);
            this.labelInfo_KKA.Name = "labelInfo_KKA";
            this.labelInfo_KKA.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KKA.TabIndex = 4;
            this.labelInfo_KKA.Text = resources.GetString("labelInfo_KKA.Text");
            // 
            // pictureBoxDeveloper_KKA
            // 
            this.pictureBoxDeveloper_KKA.Image = global::Tyuiu.KornilovKA.Sprint6.Task7.V21.Properties.Resources.W6opSFB5UWw;
            this.pictureBoxDeveloper_KKA.Location = new System.Drawing.Point(13, 9);
            this.pictureBoxDeveloper_KKA.Name = "pictureBoxDeveloper_KKA";
            this.pictureBoxDeveloper_KKA.Size = new System.Drawing.Size(100, 140);
            this.pictureBoxDeveloper_KKA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeveloper_KKA.TabIndex = 3;
            this.pictureBoxDeveloper_KKA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.buttonDone_KKA);
            this.Controls.Add(this.labelInfo_KKA);
            this.Controls.Add(this.pictureBoxDeveloper_KKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_KKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KKA;
        private System.Windows.Forms.Label labelInfo_KKA;
        private System.Windows.Forms.PictureBox pictureBoxDeveloper_KKA;
    }
}