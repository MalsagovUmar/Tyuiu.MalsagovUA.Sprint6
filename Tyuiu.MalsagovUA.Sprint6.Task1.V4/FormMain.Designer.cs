
namespace Tyuiu.MalsagovUA.Sprint6.Task1.V4
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
            this.groupBoxOutPutData_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MUA = new System.Windows.Forms.TextBox();
            this.labelResult_MUA = new System.Windows.Forms.Label();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_MUA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_MUA = new System.Windows.Forms.TextBox();
            this.labelStopIndex_MUA = new System.Windows.Forms.Label();
            this.labelStartIndex_MUA = new System.Windows.Forms.Label();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_MUA.SuspendLayout();
            this.groupBoxTask_MUA.SuspendLayout();
            this.groupBoxInPutData_MUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOutPutData_MUA
            // 
            this.groupBoxOutPutData_MUA.Controls.Add(this.textBoxResult_MUA);
            this.groupBoxOutPutData_MUA.Controls.Add(this.labelResult_MUA);
            this.groupBoxOutPutData_MUA.Location = new System.Drawing.Point(583, 12);
            this.groupBoxOutPutData_MUA.Name = "groupBoxOutPutData_MUA";
            this.groupBoxOutPutData_MUA.Size = new System.Drawing.Size(309, 426);
            this.groupBoxOutPutData_MUA.TabIndex = 0;
            this.groupBoxOutPutData_MUA.TabStop = false;
            this.groupBoxOutPutData_MUA.Text = "Вывод данных";
            // 
            // textBoxResult_MUA
            // 
            this.textBoxResult_MUA.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_MUA.Location = new System.Drawing.Point(11, 50);
            this.textBoxResult_MUA.Multiline = true;
            this.textBoxResult_MUA.Name = "textBoxResult_MUA";
            this.textBoxResult_MUA.ReadOnly = true;
            this.textBoxResult_MUA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MUA.Size = new System.Drawing.Size(292, 370);
            this.textBoxResult_MUA.TabIndex = 1;
            // 
            // labelResult_MUA
            // 
            this.labelResult_MUA.AutoSize = true;
            this.labelResult_MUA.Location = new System.Drawing.Point(7, 26);
            this.labelResult_MUA.Name = "labelResult_MUA";
            this.labelResult_MUA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_MUA.TabIndex = 0;
            this.labelResult_MUA.Text = "Результат:";
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(564, 328);
            this.groupBoxTask_MUA.TabIndex = 1;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(551, 296);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.";
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStopStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStartStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStopIndex_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStartIndex_MUA);
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(13, 347);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(328, 100);
            this.groupBoxInPutData_MUA.TabIndex = 2;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод данных";
            // 
            // textBoxStopStep_MUA
            // 
            this.textBoxStopStep_MUA.Location = new System.Drawing.Point(190, 59);
            this.textBoxStopStep_MUA.Name = "textBoxStopStep_MUA";
            this.textBoxStopStep_MUA.Size = new System.Drawing.Size(121, 26);
            this.textBoxStopStep_MUA.TabIndex = 3;
            this.textBoxStopStep_MUA.Text = "5";
            this.textBoxStopStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // textBoxStartStep_MUA
            // 
            this.textBoxStartStep_MUA.Location = new System.Drawing.Point(11, 58);
            this.textBoxStartStep_MUA.Name = "textBoxStartStep_MUA";
            this.textBoxStartStep_MUA.Size = new System.Drawing.Size(121, 26);
            this.textBoxStartStep_MUA.TabIndex = 2;
            this.textBoxStartStep_MUA.Text = "-5";
            this.textBoxStartStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // labelStopIndex_MUA
            // 
            this.labelStopIndex_MUA.AutoSize = true;
            this.labelStopIndex_MUA.Location = new System.Drawing.Point(186, 26);
            this.labelStopIndex_MUA.Name = "labelStopIndex_MUA";
            this.labelStopIndex_MUA.Size = new System.Drawing.Size(101, 20);
            this.labelStopIndex_MUA.TabIndex = 1;
            this.labelStopIndex_MUA.Text = "Конец шага:";
            // 
            // labelStartIndex_MUA
            // 
            this.labelStartIndex_MUA.AutoSize = true;
            this.labelStartIndex_MUA.Location = new System.Drawing.Point(7, 26);
            this.labelStartIndex_MUA.Name = "labelStartIndex_MUA";
            this.labelStartIndex_MUA.Size = new System.Drawing.Size(113, 20);
            this.labelStartIndex_MUA.TabIndex = 0;
            this.labelStartIndex_MUA.Text = "Начало шага:";
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(347, 356);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(98, 82);
            this.buttonHelp_MUA.TabIndex = 3;
            this.buttonHelp_MUA.Text = "Справка";
            this.buttonHelp_MUA.UseVisualStyleBackColor = false;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MUA.Location = new System.Drawing.Point(451, 356);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(120, 82);
            this.buttonDone_MUA.TabIndex = 4;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = false;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.buttonDone_MUA);
            this.Controls.Add(this.buttonHelp_MUA);
            this.Controls.Add(this.groupBoxInPutData_MUA);
            this.Controls.Add(this.groupBoxTask_MUA);
            this.Controls.Add(this.groupBoxOutPutData_MUA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 4 | Мальсагов У.А.";
            this.groupBoxOutPutData_MUA.ResumeLayout(false);
            this.groupBoxOutPutData_MUA.PerformLayout();
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPutData_MUA;
        private System.Windows.Forms.Label labelResult_MUA;
        private System.Windows.Forms.TextBox textBoxResult_MUA;
        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.TextBox textBoxStopStep_MUA;
        private System.Windows.Forms.TextBox textBoxStartStep_MUA;
        private System.Windows.Forms.Label labelStopIndex_MUA;
        private System.Windows.Forms.Label labelStartIndex_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
    }
}

