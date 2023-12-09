
namespace Tyuiu.MalsagovUA.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_LEFT = new System.Windows.Forms.Panel();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.buttonSave_MUA = new System.Windows.Forms.Button();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_MUA = new System.Windows.Forms.Label();
            this.labelStartStep_MUA = new System.Windows.Forms.Label();
            this.textBoxStopStep_MUA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_MUA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.panelLeft_MUA = new System.Windows.Forms.Panel();
            this.groupBoxResult_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MUA = new System.Windows.Forms.TextBox();
            this.splitterMain_MUA = new System.Windows.Forms.Splitter();
            this.panelMid_MUA = new System.Windows.Forms.Panel();
            this.chartFunction_MUA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_LEFT.SuspendLayout();
            this.groupBoxInPutData_MUA.SuspendLayout();
            this.groupBoxTask_MUA.SuspendLayout();
            this.panelLeft_MUA.SuspendLayout();
            this.groupBoxResult_MUA.SuspendLayout();
            this.panelMid_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_LEFT
            // 
            this.panelTop_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTop_LEFT.Controls.Add(this.buttonHelp_MUA);
            this.panelTop_LEFT.Controls.Add(this.buttonSave_MUA);
            this.panelTop_LEFT.Controls.Add(this.buttonDone_MUA);
            this.panelTop_LEFT.Controls.Add(this.groupBoxInPutData_MUA);
            this.panelTop_LEFT.Controls.Add(this.groupBoxTask_MUA);
            this.panelTop_LEFT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_LEFT.Location = new System.Drawing.Point(0, 0);
            this.panelTop_LEFT.Name = "panelTop_LEFT";
            this.panelTop_LEFT.Size = new System.Drawing.Size(1188, 114);
            this.panelTop_LEFT.TabIndex = 1;
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MUA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(1082, 12);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(94, 70);
            this.buttonHelp_MUA.TabIndex = 2;
            this.buttonHelp_MUA.Text = "Справка";
            this.buttonHelp_MUA.UseVisualStyleBackColor = false;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // buttonSave_MUA
            // 
            this.buttonSave_MUA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_MUA.Location = new System.Drawing.Point(962, 13);
            this.buttonSave_MUA.Name = "buttonSave_MUA";
            this.buttonSave_MUA.Size = new System.Drawing.Size(114, 69);
            this.buttonSave_MUA.TabIndex = 2;
            this.buttonSave_MUA.Text = "Сохранить";
            this.buttonSave_MUA.UseVisualStyleBackColor = false;
            this.buttonSave_MUA.Click += new System.EventHandler(this.buttonSave_MUA_Click);
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MUA.Location = new System.Drawing.Point(822, 13);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(134, 69);
            this.buttonDone_MUA.TabIndex = 2;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = false;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStopStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.labelStartStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStopStep_MUA);
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxStartStep_MUA);
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(502, 4);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(314, 100);
            this.groupBoxInPutData_MUA.TabIndex = 1;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод данных:";
            // 
            // labelStopStep_MUA
            // 
            this.labelStopStep_MUA.AutoSize = true;
            this.labelStopStep_MUA.Location = new System.Drawing.Point(162, 29);
            this.labelStopStep_MUA.Name = "labelStopStep_MUA";
            this.labelStopStep_MUA.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_MUA.TabIndex = 1;
            this.labelStopStep_MUA.Text = "Конец шага:";
            // 
            // labelStartStep_MUA
            // 
            this.labelStartStep_MUA.AutoSize = true;
            this.labelStartStep_MUA.Location = new System.Drawing.Point(6, 29);
            this.labelStartStep_MUA.Name = "labelStartStep_MUA";
            this.labelStartStep_MUA.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_MUA.TabIndex = 1;
            this.labelStartStep_MUA.Text = "Старт шага:";
            // 
            // textBoxStopStep_MUA
            // 
            this.textBoxStopStep_MUA.Location = new System.Drawing.Point(166, 52);
            this.textBoxStopStep_MUA.Name = "textBoxStopStep_MUA";
            this.textBoxStopStep_MUA.Size = new System.Drawing.Size(142, 26);
            this.textBoxStopStep_MUA.TabIndex = 0;
            this.textBoxStopStep_MUA.Text = "5";
            this.textBoxStopStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // textBoxStartStep_MUA
            // 
            this.textBoxStartStep_MUA.Location = new System.Drawing.Point(6, 52);
            this.textBoxStartStep_MUA.Name = "textBoxStartStep_MUA";
            this.textBoxStartStep_MUA.Size = new System.Drawing.Size(142, 26);
            this.textBoxStartStep_MUA.TabIndex = 0;
            this.textBoxStartStep_MUA.Text = "-5";
            this.textBoxStartStep_MUA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_MUA_KeyPress);
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(492, 100);
            this.groupBoxTask_MUA.TabIndex = 0;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(9, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(476, 68);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в textBox." +
    " Построить график функции и сохранить в файл OutPutFileTask4V21.txt по нажатию к" +
    "нопки.";
            // 
            // panelLeft_MUA
            // 
            this.panelLeft_MUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelLeft_MUA.Controls.Add(this.groupBoxResult_MUA);
            this.panelLeft_MUA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MUA.Location = new System.Drawing.Point(0, 114);
            this.panelLeft_MUA.Name = "panelLeft_MUA";
            this.panelLeft_MUA.Size = new System.Drawing.Size(267, 430);
            this.panelLeft_MUA.TabIndex = 2;
            // 
            // groupBoxResult_MUA
            // 
            this.groupBoxResult_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult_MUA.Controls.Add(this.textBoxResult_MUA);
            this.groupBoxResult_MUA.Location = new System.Drawing.Point(13, 7);
            this.groupBoxResult_MUA.Name = "groupBoxResult_MUA";
            this.groupBoxResult_MUA.Size = new System.Drawing.Size(248, 411);
            this.groupBoxResult_MUA.TabIndex = 0;
            this.groupBoxResult_MUA.TabStop = false;
            this.groupBoxResult_MUA.Text = "Вывод данных:";
            // 
            // textBoxResult_MUA
            // 
            this.textBoxResult_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_MUA.Location = new System.Drawing.Point(7, 26);
            this.textBoxResult_MUA.Multiline = true;
            this.textBoxResult_MUA.Name = "textBoxResult_MUA";
            this.textBoxResult_MUA.ReadOnly = true;
            this.textBoxResult_MUA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MUA.Size = new System.Drawing.Size(235, 379);
            this.textBoxResult_MUA.TabIndex = 0;
            // 
            // splitterMain_MUA
            // 
            this.splitterMain_MUA.Location = new System.Drawing.Point(267, 114);
            this.splitterMain_MUA.Name = "splitterMain_MUA";
            this.splitterMain_MUA.Size = new System.Drawing.Size(10, 430);
            this.splitterMain_MUA.TabIndex = 3;
            this.splitterMain_MUA.TabStop = false;
            // 
            // panelMid_MUA
            // 
            this.panelMid_MUA.BackColor = System.Drawing.Color.Red;
            this.panelMid_MUA.Controls.Add(this.chartFunction_MUA);
            this.panelMid_MUA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_MUA.Location = new System.Drawing.Point(277, 114);
            this.panelMid_MUA.Name = "panelMid_MUA";
            this.panelMid_MUA.Padding = new System.Windows.Forms.Padding(5);
            this.panelMid_MUA.Size = new System.Drawing.Size(911, 430);
            this.panelMid_MUA.TabIndex = 4;
            // 
            // chartFunction_MUA
            // 
            this.chartFunction_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MUA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_MUA.Legends.Add(legend1);
            this.chartFunction_MUA.Location = new System.Drawing.Point(9, 7);
            this.chartFunction_MUA.Name = "chartFunction_MUA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MUA.Series.Add(series1);
            this.chartFunction_MUA.Size = new System.Drawing.Size(894, 415);
            this.chartFunction_MUA.TabIndex = 0;
            this.chartFunction_MUA.Text = "График функции f(x):";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            title1.Name = "TitleFunction";
            title1.Text = "График функции f(x)";
            this.chartFunction_MUA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 544);
            this.Controls.Add(this.panelMid_MUA);
            this.Controls.Add(this.splitterMain_MUA);
            this.Controls.Add(this.panelLeft_MUA);
            this.Controls.Add(this.panelTop_LEFT);
            this.MinimumSize = new System.Drawing.Size(1210, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 21 | Мальсагов У.А.";
            this.panelTop_LEFT.ResumeLayout(false);
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.PerformLayout();
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.panelLeft_MUA.ResumeLayout(false);
            this.groupBoxResult_MUA.ResumeLayout(false);
            this.groupBoxResult_MUA.PerformLayout();
            this.panelMid_MUA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_LEFT;
        private System.Windows.Forms.Panel panelLeft_MUA;
        private System.Windows.Forms.Splitter splitterMain_MUA;
        private System.Windows.Forms.Panel panelMid_MUA;
        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonSave_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.Label labelStopStep_MUA;
        private System.Windows.Forms.Label labelStartStep_MUA;
        private System.Windows.Forms.TextBox textBoxStopStep_MUA;
        private System.Windows.Forms.TextBox textBoxStartStep_MUA;
        private System.Windows.Forms.GroupBox groupBoxResult_MUA;
        private System.Windows.Forms.TextBox textBoxResult_MUA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MUA;
    }
}

