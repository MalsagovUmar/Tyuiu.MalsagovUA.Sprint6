
namespace Tyuiu.MalsagovUA.Sprint6.Task6.V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogTask_MUA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MUA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_MUA = new System.Windows.Forms.Button();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.panelTop_MUA = new System.Windows.Forms.Panel();
            this.panelLeft_MUA = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_MUA = new System.Windows.Forms.TextBox();
            this.panelRight_MUA = new System.Windows.Forms.Panel();
            this.splitterMain_MUA = new System.Windows.Forms.Splitter();
            this.groupBoxOutPutData_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_MUA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.panelTop_MUA.SuspendLayout();
            this.panelLeft_MUA.SuspendLayout();
            this.groupBoxInPutData_MUA.SuspendLayout();
            this.panelRight_MUA.SuspendLayout();
            this.groupBoxOutPutData_MUA.SuspendLayout();
            this.groupBoxTask_MUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_MUA
            // 
            this.openFileDialogTask_MUA.FileName = "openFileDialog1";
            // 
            // toolTip_MUA
            // 
            this.toolTip_MUA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MUA.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_MUA
            // 
            this.buttonOpenFile_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MUA.Image")));
            this.buttonOpenFile_MUA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_MUA.Name = "buttonOpenFile_MUA";
            this.buttonOpenFile_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonOpenFile_MUA.TabIndex = 0;
            this.toolTip_MUA.SetToolTip(this.buttonOpenFile_MUA, "Открыть файл\r\nВыбрать нужный файл для обработки");
            this.buttonOpenFile_MUA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MUA.Click += new System.EventHandler(this.buttonOpenFile_MUA_Click);
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.Enabled = false;
            this.buttonDone_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MUA.Image")));
            this.buttonDone_MUA.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonDone_MUA.TabIndex = 0;
            this.toolTip_MUA.SetToolTip(this.buttonDone_MUA, "Вывести первое слово каждой строки в результирующею строку.");
            this.buttonDone_MUA.UseVisualStyleBackColor = true;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MUA.Image")));
            this.buttonHelp_MUA.Location = new System.Drawing.Point(991, 12);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonHelp_MUA.TabIndex = 0;
            this.toolTip_MUA.SetToolTip(this.buttonHelp_MUA, "Сведения о программе");
            this.buttonHelp_MUA.UseVisualStyleBackColor = true;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            // 
            // panelTop_MUA
            // 
            this.panelTop_MUA.Controls.Add(this.buttonHelp_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonDone_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonOpenFile_MUA);
            this.panelTop_MUA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MUA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MUA.Name = "panelTop_MUA";
            this.panelTop_MUA.Size = new System.Drawing.Size(1078, 207);
            this.panelTop_MUA.TabIndex = 1;
            // 
            // panelLeft_MUA
            // 
            this.panelLeft_MUA.Controls.Add(this.groupBoxInPutData_MUA);
            this.panelLeft_MUA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MUA.Location = new System.Drawing.Point(0, 207);
            this.panelLeft_MUA.Name = "panelLeft_MUA";
            this.panelLeft_MUA.Size = new System.Drawing.Size(526, 437);
            this.panelLeft_MUA.TabIndex = 2;
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.textBoxInPutData_MUA);
            this.groupBoxInPutData_MUA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(516, 437);
            this.groupBoxInPutData_MUA.TabIndex = 5;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод данных:";
            // 
            // textBoxInPutData_MUA
            // 
            this.textBoxInPutData_MUA.Location = new System.Drawing.Point(7, 66);
            this.textBoxInPutData_MUA.Multiline = true;
            this.textBoxInPutData_MUA.Name = "textBoxInPutData_MUA";
            this.textBoxInPutData_MUA.ReadOnly = true;
            this.textBoxInPutData_MUA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_MUA.Size = new System.Drawing.Size(503, 329);
            this.textBoxInPutData_MUA.TabIndex = 0;
            // 
            // panelRight_MUA
            // 
            this.panelRight_MUA.Controls.Add(this.splitterMain_MUA);
            this.panelRight_MUA.Controls.Add(this.groupBoxOutPutData_MUA);
            this.panelRight_MUA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_MUA.Location = new System.Drawing.Point(526, 207);
            this.panelRight_MUA.Name = "panelRight_MUA";
            this.panelRight_MUA.Size = new System.Drawing.Size(552, 437);
            this.panelRight_MUA.TabIndex = 4;
            // 
            // splitterMain_MUA
            // 
            this.splitterMain_MUA.Location = new System.Drawing.Point(0, 0);
            this.splitterMain_MUA.Name = "splitterMain_MUA";
            this.splitterMain_MUA.Size = new System.Drawing.Size(3, 437);
            this.splitterMain_MUA.TabIndex = 6;
            this.splitterMain_MUA.TabStop = false;
            // 
            // groupBoxOutPutData_MUA
            // 
            this.groupBoxOutPutData_MUA.Controls.Add(this.textBoxOutPutData_MUA);
            this.groupBoxOutPutData_MUA.Location = new System.Drawing.Point(6, 0);
            this.groupBoxOutPutData_MUA.Name = "groupBoxOutPutData_MUA";
            this.groupBoxOutPutData_MUA.Size = new System.Drawing.Size(516, 401);
            this.groupBoxOutPutData_MUA.TabIndex = 5;
            this.groupBoxOutPutData_MUA.TabStop = false;
            this.groupBoxOutPutData_MUA.Text = "Вывод данных:";
            // 
            // textBoxOutPutData_MUA
            // 
            this.textBoxOutPutData_MUA.Location = new System.Drawing.Point(6, 66);
            this.textBoxOutPutData_MUA.Multiline = true;
            this.textBoxOutPutData_MUA.Name = "textBoxOutPutData_MUA";
            this.textBoxOutPutData_MUA.ReadOnly = true;
            this.textBoxOutPutData_MUA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_MUA.Size = new System.Drawing.Size(503, 329);
            this.textBoxOutPutData_MUA.TabIndex = 0;
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(0, 107);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(1048, 100);
            this.groupBoxTask_MUA.TabIndex = 3;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие:";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(1034, 68);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = "Дан файл InPutFileTask6V1.txt. Загрузить файл в textBoxIn через openFileDialog. В" +
    "ывести первое слово каждой строки в результирующею строку и вывести ее в textBox" +
    "Out.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.panelRight_MUA);
            this.Controls.Add(this.groupBoxTask_MUA);
            this.Controls.Add(this.panelLeft_MUA);
            this.Controls.Add(this.panelTop_MUA);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 1 | Мальсагов Умар Асланович";
            this.panelTop_MUA.ResumeLayout(false);
            this.panelLeft_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.PerformLayout();
            this.panelRight_MUA.ResumeLayout(false);
            this.groupBoxOutPutData_MUA.ResumeLayout(false);
            this.groupBoxOutPutData_MUA.PerformLayout();
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MUA;
        private System.Windows.Forms.ToolTip toolTip_MUA;
        private System.Windows.Forms.Button buttonOpenFile_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Panel panelTop_MUA;
        private System.Windows.Forms.Panel panelLeft_MUA;
        private System.Windows.Forms.Panel panelRight_MUA;
        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.TextBox textBoxInPutData_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_MUA;
        private System.Windows.Forms.TextBox textBoxOutPutData_MUA;
        private System.Windows.Forms.Splitter splitterMain_MUA;
    }
}

