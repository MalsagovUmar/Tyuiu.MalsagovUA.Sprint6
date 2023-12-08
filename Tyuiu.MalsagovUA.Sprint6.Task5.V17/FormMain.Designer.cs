
namespace Tyuiu.MalsagovUA.Sprint6.Task5.V17
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
            this.panelTop_MUA = new System.Windows.Forms.Panel();
            this.panelLeft_MUA = new System.Windows.Forms.Panel();
            this.splitterLeft_MUA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.panelMid_MUA = new System.Windows.Forms.Panel();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.buttonOpen_MUA = new System.Windows.Forms.Button();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.dataGridViewResult_MUA = new System.Windows.Forms.DataGridView();
            this.chartFunction_MUA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_MUA.SuspendLayout();
            this.panelLeft_MUA.SuspendLayout();
            this.groupBoxTask_MUA.SuspendLayout();
            this.panelMid_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MUA
            // 
            this.panelTop_MUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTop_MUA.Controls.Add(this.buttonHelp_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonOpen_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonDone_MUA);
            this.panelTop_MUA.Controls.Add(this.groupBoxTask_MUA);
            this.panelTop_MUA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MUA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MUA.Name = "panelTop_MUA";
            this.panelTop_MUA.Size = new System.Drawing.Size(978, 119);
            this.panelTop_MUA.TabIndex = 0;
            // 
            // panelLeft_MUA
            // 
            this.panelLeft_MUA.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelLeft_MUA.Controls.Add(this.dataGridViewResult_MUA);
            this.panelLeft_MUA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MUA.Location = new System.Drawing.Point(0, 119);
            this.panelLeft_MUA.Name = "panelLeft_MUA";
            this.panelLeft_MUA.Size = new System.Drawing.Size(247, 375);
            this.panelLeft_MUA.TabIndex = 1;
            // 
            // splitterLeft_MUA
            // 
            this.splitterLeft_MUA.Location = new System.Drawing.Point(247, 119);
            this.splitterLeft_MUA.Name = "splitterLeft_MUA";
            this.splitterLeft_MUA.Size = new System.Drawing.Size(3, 375);
            this.splitterLeft_MUA.TabIndex = 2;
            this.splitterLeft_MUA.TabStop = false;
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(591, 109);
            this.groupBoxTask_MUA.TabIndex = 0;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие:";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(9, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(576, 77);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = "Прочитать данные из файла InPutFileTask5V17.txt.\r\nВывести все отрицательные числа" +
    " в dataGridView.\r\nПостроить диаграмму по этим значениям.";
            // 
            // panelMid_MUA
            // 
            this.panelMid_MUA.BackColor = System.Drawing.Color.Red;
            this.panelMid_MUA.Controls.Add(this.chartFunction_MUA);
            this.panelMid_MUA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_MUA.Location = new System.Drawing.Point(250, 119);
            this.panelMid_MUA.Name = "panelMid_MUA";
            this.panelMid_MUA.Size = new System.Drawing.Size(728, 375);
            this.panelMid_MUA.TabIndex = 3;
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MUA.Location = new System.Drawing.Point(601, 12);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(120, 101);
            this.buttonDone_MUA.TabIndex = 1;
            this.buttonDone_MUA.Text = "Выполнить";
            this.buttonDone_MUA.UseVisualStyleBackColor = false;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // buttonOpen_MUA
            // 
            this.buttonOpen_MUA.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonOpen_MUA.Location = new System.Drawing.Point(726, 12);
            this.buttonOpen_MUA.Name = "buttonOpen_MUA";
            this.buttonOpen_MUA.Size = new System.Drawing.Size(120, 101);
            this.buttonOpen_MUA.TabIndex = 1;
            this.buttonOpen_MUA.Text = "Открыть файл";
            this.buttonOpen_MUA.UseVisualStyleBackColor = false;
            this.buttonOpen_MUA.Click += new System.EventHandler(this.buttonOpen_MUA_Click);
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MUA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_MUA.Location = new System.Drawing.Point(861, 12);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(105, 101);
            this.buttonHelp_MUA.TabIndex = 1;
            this.buttonHelp_MUA.Text = "Справка";
            this.buttonHelp_MUA.UseVisualStyleBackColor = false;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // dataGridViewResult_MUA
            // 
            this.dataGridViewResult_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_MUA.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewResult_MUA.Name = "dataGridViewResult_MUA";
            this.dataGridViewResult_MUA.ReadOnly = true;
            this.dataGridViewResult_MUA.RowHeadersVisible = false;
            this.dataGridViewResult_MUA.RowHeadersWidth = 62;
            this.dataGridViewResult_MUA.RowTemplate.Height = 28;
            this.dataGridViewResult_MUA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_MUA.Size = new System.Drawing.Size(240, 359);
            this.dataGridViewResult_MUA.TabIndex = 0;
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
            this.chartFunction_MUA.Location = new System.Drawing.Point(7, 7);
            this.chartFunction_MUA.Name = "chartFunction_MUA";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MUA.Series.Add(series1);
            this.chartFunction_MUA.Size = new System.Drawing.Size(709, 356);
            this.chartFunction_MUA.TabIndex = 0;
            this.chartFunction_MUA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.panelMid_MUA);
            this.Controls.Add(this.splitterLeft_MUA);
            this.Controls.Add(this.panelLeft_MUA);
            this.Controls.Add(this.panelTop_MUA);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 17 | Мальсагов У.А.";
            this.panelTop_MUA.ResumeLayout(false);
            this.panelLeft_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.panelMid_MUA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MUA;
        private System.Windows.Forms.Panel panelLeft_MUA;
        private System.Windows.Forms.Splitter splitterLeft_MUA;
        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMid_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonOpen_MUA;
        private System.Windows.Forms.DataGridView dataGridViewResult_MUA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MUA;
    }
}

