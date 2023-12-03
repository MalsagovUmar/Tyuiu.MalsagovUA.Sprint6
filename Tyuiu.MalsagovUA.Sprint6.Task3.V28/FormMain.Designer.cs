
namespace Tyuiu.MalsagovUA.Sprint6.Task3.V28
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
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_MUA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.groupBoxResult_MUA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_MUA = new System.Windows.Forms.DataGridView();
            this.labelResult_MUA = new System.Windows.Forms.Label();
            this.groupBoxTask_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_MUA)).BeginInit();
            this.groupBoxResult_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.dataGridViewInPutData_MUA);
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(681, 425);
            this.groupBoxTask_MUA.TabIndex = 0;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие";
            // 
            // dataGridViewInPutData_MUA
            // 
            this.dataGridViewInPutData_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_MUA.Location = new System.Drawing.Point(331, 26);
            this.dataGridViewInPutData_MUA.Name = "dataGridViewInPutData_MUA";
            this.dataGridViewInPutData_MUA.ReadOnly = true;
            this.dataGridViewInPutData_MUA.RowHeadersVisible = false;
            this.dataGridViewInPutData_MUA.RowHeadersWidth = 62;
            this.dataGridViewInPutData_MUA.RowTemplate.Height = 28;
            this.dataGridViewInPutData_MUA.Size = new System.Drawing.Size(344, 393);
            this.dataGridViewInPutData_MUA.TabIndex = 1;
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(317, 393);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = resources.GetString("textBoxTask_MUA.Text");
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.Location = new System.Drawing.Point(861, 402);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(175, 36);
            this.buttonDone_MUA.TabIndex = 1;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = true;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(766, 402);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(89, 36);
            this.buttonHelp_MUA.TabIndex = 2;
            this.buttonHelp_MUA.Text = "?";
            this.buttonHelp_MUA.UseVisualStyleBackColor = true;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // groupBoxResult_MUA
            // 
            this.groupBoxResult_MUA.Controls.Add(this.dataGridViewOutPutData_MUA);
            this.groupBoxResult_MUA.Controls.Add(this.labelResult_MUA);
            this.groupBoxResult_MUA.Location = new System.Drawing.Point(694, 22);
            this.groupBoxResult_MUA.Name = "groupBoxResult_MUA";
            this.groupBoxResult_MUA.Size = new System.Drawing.Size(392, 374);
            this.groupBoxResult_MUA.TabIndex = 3;
            this.groupBoxResult_MUA.TabStop = false;
            this.groupBoxResult_MUA.Text = "Вывод данных";
            // 
            // dataGridViewOutPutData_MUA
            // 
            this.dataGridViewOutPutData_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_MUA.Location = new System.Drawing.Point(7, 46);
            this.dataGridViewOutPutData_MUA.Name = "dataGridViewOutPutData_MUA";
            this.dataGridViewOutPutData_MUA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_MUA.RowHeadersWidth = 62;
            this.dataGridViewOutPutData_MUA.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_MUA.Size = new System.Drawing.Size(379, 322);
            this.dataGridViewOutPutData_MUA.TabIndex = 1;
            // 
            // labelResult_MUA
            // 
            this.labelResult_MUA.AutoSize = true;
            this.labelResult_MUA.Location = new System.Drawing.Point(6, 22);
            this.labelResult_MUA.Name = "labelResult_MUA";
            this.labelResult_MUA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_MUA.TabIndex = 0;
            this.labelResult_MUA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.groupBoxResult_MUA);
            this.Controls.Add(this.buttonHelp_MUA);
            this.Controls.Add(this.buttonDone_MUA);
            this.Controls.Add(this.groupBoxTask_MUA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 | Мальсагов У.А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_MUA)).EndInit();
            this.groupBoxResult_MUA.ResumeLayout(false);
            this.groupBoxResult_MUA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_MUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.GroupBox groupBoxResult_MUA;
        private System.Windows.Forms.Label labelResult_MUA;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_MUA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_MUA;
    }
}

