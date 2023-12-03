
namespace Tyuiu.MalsagovUA.Sprint6.Task0.V27
{
    partial class x
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(x));
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_MUA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.labelVarX_MUA = new System.Windows.Forms.Label();
            this.textBoxVarX_MUA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_MUA = new System.Windows.Forms.GroupBox();
            this.labelResult_MUA = new System.Windows.Forms.Label();
            this.textBoxResult_MUA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.groupBoxTask_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MUA)).BeginInit();
            this.groupBoxInPutData_MUA.SuspendLayout();
            this.groupBoxOutPutData_MUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Controls.Add(this.pictureBoxFormula_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(38, 34);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(750, 225);
            this.groupBoxTask_MUA.TabIndex = 0;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(10, 25);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(358, 194);
            this.textBoxTask_MUA.TabIndex = 2;
            this.textBoxTask_MUA.Text = "Вычислить значение выражения по формуле";
            // 
            // pictureBoxFormula_MUA
            // 
            this.pictureBoxFormula_MUA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_MUA.Image")));
            this.pictureBoxFormula_MUA.Location = new System.Drawing.Point(374, 25);
            this.pictureBoxFormula_MUA.Name = "pictureBoxFormula_MUA";
            this.pictureBoxFormula_MUA.Size = new System.Drawing.Size(370, 97);
            this.pictureBoxFormula_MUA.TabIndex = 1;
            this.pictureBoxFormula_MUA.TabStop = false;
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.labelVarX_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxVarX_MUA);
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(38, 265);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(455, 124);
            this.groupBoxInPutData_MUA.TabIndex = 1;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод данных";
            // 
            // labelVarX_MUA
            // 
            this.labelVarX_MUA.AutoSize = true;
            this.labelVarX_MUA.Location = new System.Drawing.Point(6, 34);
            this.labelVarX_MUA.Name = "labelVarX_MUA";
            this.labelVarX_MUA.Size = new System.Drawing.Size(123, 20);
            this.labelVarX_MUA.TabIndex = 1;
            this.labelVarX_MUA.Text = "Переменная X:";
            // 
            // textBoxVarX_MUA
            // 
            this.textBoxVarX_MUA.Location = new System.Drawing.Point(6, 57);
            this.textBoxVarX_MUA.Name = "textBoxVarX_MUA";
            this.textBoxVarX_MUA.Size = new System.Drawing.Size(443, 26);
            this.textBoxVarX_MUA.TabIndex = 0;
            this.textBoxVarX_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_MUA_KeyPress);
            // 
            // groupBoxOutPutData_MUA
            // 
            this.groupBoxOutPutData_MUA.Controls.Add(this.labelResult_MUA);
            this.groupBoxOutPutData_MUA.Controls.Add(this.textBoxResult_MUA);
            this.groupBoxOutPutData_MUA.Location = new System.Drawing.Point(499, 265);
            this.groupBoxOutPutData_MUA.Name = "groupBoxOutPutData_MUA";
            this.groupBoxOutPutData_MUA.Size = new System.Drawing.Size(283, 124);
            this.groupBoxOutPutData_MUA.TabIndex = 2;
            this.groupBoxOutPutData_MUA.TabStop = false;
            this.groupBoxOutPutData_MUA.Text = "Вывод данных";
            // 
            // labelResult_MUA
            // 
            this.labelResult_MUA.AutoSize = true;
            this.labelResult_MUA.Location = new System.Drawing.Point(6, 34);
            this.labelResult_MUA.Name = "labelResult_MUA";
            this.labelResult_MUA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_MUA.TabIndex = 1;
            this.labelResult_MUA.Text = "Результат:";
            // 
            // textBoxResult_MUA
            // 
            this.textBoxResult_MUA.Location = new System.Drawing.Point(6, 57);
            this.textBoxResult_MUA.Name = "textBoxResult_MUA";
            this.textBoxResult_MUA.ReadOnly = true;
            this.textBoxResult_MUA.Size = new System.Drawing.Size(271, 26);
            this.textBoxResult_MUA.TabIndex = 0;
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(588, 395);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(52, 42);
            this.buttonHelp_MUA.TabIndex = 3;
            this.buttonHelp_MUA.Text = "?";
            this.buttonHelp_MUA.UseVisualStyleBackColor = true;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.Location = new System.Drawing.Point(646, 395);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(136, 42);
            this.buttonDone_MUA.TabIndex = 4;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = true;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_MUA);
            this.Controls.Add(this.buttonHelp_MUA);
            this.Controls.Add(this.groupBoxOutPutData_MUA);
            this.Controls.Add(this.groupBoxInPutData_MUA);
            this.Controls.Add(this.groupBoxTask_MUA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "x";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 27 | Мальсагов У.А.";
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MUA)).EndInit();
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.PerformLayout();
            this.groupBoxOutPutData_MUA.ResumeLayout(false);
            this.groupBoxOutPutData_MUA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.TextBox textBoxResult_MUA;
        private System.Windows.Forms.Label labelResult_MUA;
        private System.Windows.Forms.Label labelVarX_MUA;
        private System.Windows.Forms.TextBox textBoxVarX_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
    }
}

