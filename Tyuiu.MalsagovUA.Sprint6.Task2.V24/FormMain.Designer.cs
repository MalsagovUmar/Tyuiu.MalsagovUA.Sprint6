
namespace Tyuiu.MalsagovUA.Sprint6.Task2.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_MUA = new System.Windows.Forms.TextBox();
            this.labelStartStep_MUA = new System.Windows.Forms.Label();
            this.textBoxStopStep_MUA = new System.Windows.Forms.TextBox();
            this.labelStopStep_MUA = new System.Windows.Forms.Label();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.dataGridViewFunction_MUA = new System.Windows.Forms.DataGridView();
            this.chartFunction_MUA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_MUA.SuspendLayout();
            this.groupBoxInPutData_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(552, 290);
            this.groupBoxTask_MUA.TabIndex = 0;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(539, 258);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в DataGrid" +
    "View и построить график функции.";
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStopStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStartStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStopStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStartStep_MUA);
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(20, 310);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(308, 100);
            this.groupBoxInPutData_MUA.TabIndex = 1;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод данных";
            // 
            // textBoxStartStep_MUA
            // 
            this.textBoxStartStep_MUA.Location = new System.Drawing.Point(6, 68);
            this.textBoxStartStep_MUA.Name = "textBoxStartStep_MUA";
            this.textBoxStartStep_MUA.Size = new System.Drawing.Size(144, 26);
            this.textBoxStartStep_MUA.TabIndex = 0;
            this.textBoxStartStep_MUA.Text = "-5";
            this.textBoxStartStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // labelStartStep_MUA
            // 
            this.labelStartStep_MUA.AutoSize = true;
            this.labelStartStep_MUA.Location = new System.Drawing.Point(6, 36);
            this.labelStartStep_MUA.Name = "labelStartStep_MUA";
            this.labelStartStep_MUA.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_MUA.TabIndex = 1;
            this.labelStartStep_MUA.Text = "Старт шага:";
            // 
            // textBoxStopStep_MUA
            // 
            this.textBoxStopStep_MUA.Location = new System.Drawing.Point(157, 68);
            this.textBoxStopStep_MUA.Name = "textBoxStopStep_MUA";
            this.textBoxStopStep_MUA.Size = new System.Drawing.Size(144, 26);
            this.textBoxStopStep_MUA.TabIndex = 0;
            this.textBoxStopStep_MUA.Text = "5";
            this.textBoxStopStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // labelStopStep_MUA
            // 
            this.labelStopStep_MUA.AutoSize = true;
            this.labelStopStep_MUA.Location = new System.Drawing.Point(153, 36);
            this.labelStopStep_MUA.Name = "labelStopStep_MUA";
            this.labelStopStep_MUA.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_MUA.TabIndex = 1;
            this.labelStopStep_MUA.Text = "Конец шага:";
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(335, 310);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(97, 100);
            this.buttonHelp_MUA.TabIndex = 2;
            this.buttonHelp_MUA.Text = "Справка";
            this.buttonHelp_MUA.UseVisualStyleBackColor = false;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MUA.Location = new System.Drawing.Point(438, 310);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(121, 100);
            this.buttonDone_MUA.TabIndex = 2;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = false;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            this.buttonDone_MUA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MUA_MouseDown);
            this.buttonDone_MUA.MouseEnter += new System.EventHandler(this.buttonDone_MUA_MouseEnter);
            this.buttonDone_MUA.MouseLeave += new System.EventHandler(this.buttonDone_MUA_MouseLeave);
            // 
            // dataGridViewFunction_MUA
            // 
            this.dataGridViewFunction_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MUA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_MUA.Location = new System.Drawing.Point(597, 23);
            this.dataGridViewFunction_MUA.Name = "dataGridViewFunction_MUA";
            this.dataGridViewFunction_MUA.ReadOnly = true;
            this.dataGridViewFunction_MUA.RowHeadersVisible = false;
            this.dataGridViewFunction_MUA.RowHeadersWidth = 62;
            this.dataGridViewFunction_MUA.RowTemplate.Height = 28;
            this.dataGridViewFunction_MUA.Size = new System.Drawing.Size(181, 381);
            this.dataGridViewFunction_MUA.TabIndex = 3;
            // 
            // chartFunction_MUA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_MUA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_MUA.Legends.Add(legend3);
            this.chartFunction_MUA.Location = new System.Drawing.Point(784, 23);
            this.chartFunction_MUA.Name = "chartFunction_MUA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_MUA.Series.Add(series3);
            this.chartFunction_MUA.Size = new System.Drawing.Size(428, 381);
            this.chartFunction_MUA.TabIndex = 4;
            this.chartFunction_MUA.Text = "chart1";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 450);
            this.Controls.Add(this.chartFunction_MUA);
            this.Controls.Add(this.dataGridViewFunction_MUA);
            this.Controls.Add(this.buttonDone_MUA);
            this.Controls.Add(this.buttonHelp_MUA);
            this.Controls.Add(this.groupBoxInPutData_MUA);
            this.Controls.Add(this.groupBoxTask_MUA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 24 | Мальсагов У.А.";
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.TextBox textBoxStartStep_MUA;
        private System.Windows.Forms.Label labelStartStep_MUA;
        private System.Windows.Forms.Label labelStopStep_MUA;
        private System.Windows.Forms.TextBox textBoxStopStep_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MUA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

