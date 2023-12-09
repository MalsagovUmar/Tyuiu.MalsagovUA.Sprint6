
namespace Tyuiu.MalsagovUA.Sprint6.Task7.V16
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
            this.panelTop_MUA = new System.Windows.Forms.Panel();
            this.groupBoxTask_MUA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MUA = new System.Windows.Forms.TextBox();
            this.buttonDone_MUA = new System.Windows.Forms.Button();
            this.buttonHelp_MUA = new System.Windows.Forms.Button();
            this.buttonSave_MUA = new System.Windows.Forms.Button();
            this.buttonOpenFile_MUA = new System.Windows.Forms.Button();
            this.panelLeft_MUA = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_MUA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_MUA = new System.Windows.Forms.DataGridView();
            this.panelRight_MUA = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_MUA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_MUA = new System.Windows.Forms.DataGridView();
            this.splitterLeft_MUA = new System.Windows.Forms.Splitter();
            this.toolTip_MUA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_MUA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_MUA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MUA.SuspendLayout();
            this.groupBoxTask_MUA.SuspendLayout();
            this.panelLeft_MUA.SuspendLayout();
            this.groupBoxInPutData_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_MUA)).BeginInit();
            this.panelRight_MUA.SuspendLayout();
            this.groupBoxOutPutData_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MUA
            // 
            this.panelTop_MUA.Controls.Add(this.groupBoxTask_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonDone_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonHelp_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonSave_MUA);
            this.panelTop_MUA.Controls.Add(this.buttonOpenFile_MUA);
            this.panelTop_MUA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MUA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MUA.Name = "panelTop_MUA";
            this.panelTop_MUA.Size = new System.Drawing.Size(957, 233);
            this.panelTop_MUA.TabIndex = 0;
            // 
            // groupBoxTask_MUA
            // 
            this.groupBoxTask_MUA.Controls.Add(this.textBoxTask_MUA);
            this.groupBoxTask_MUA.Location = new System.Drawing.Point(13, 82);
            this.groupBoxTask_MUA.Name = "groupBoxTask_MUA";
            this.groupBoxTask_MUA.Size = new System.Drawing.Size(847, 151);
            this.groupBoxTask_MUA.TabIndex = 5;
            this.groupBoxTask_MUA.TabStop = false;
            this.groupBoxTask_MUA.Text = "Условие:";
            // 
            // textBoxTask_MUA
            // 
            this.textBoxTask_MUA.Location = new System.Drawing.Point(16, 26);
            this.textBoxTask_MUA.Multiline = true;
            this.textBoxTask_MUA.Name = "textBoxTask_MUA";
            this.textBoxTask_MUA.ReadOnly = true;
            this.textBoxTask_MUA.Size = new System.Drawing.Size(825, 119);
            this.textBoxTask_MUA.TabIndex = 0;
            this.textBoxTask_MUA.Text = resources.GetString("textBoxTask_MUA.Text");
            // 
            // buttonDone_MUA
            // 
            this.buttonDone_MUA.Enabled = false;
            this.buttonDone_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MUA.Image")));
            this.buttonDone_MUA.Location = new System.Drawing.Point(94, 12);
            this.buttonDone_MUA.Name = "buttonDone_MUA";
            this.buttonDone_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonDone_MUA.TabIndex = 4;
            this.buttonDone_MUA.UseVisualStyleBackColor = true;
            this.buttonDone_MUA.Click += new System.EventHandler(this.buttonDone_MUA_Click);
            this.buttonDone_MUA.MouseEnter += new System.EventHandler(this.buttonDone_MUA_MouseEnter);
            // 
            // buttonHelp_MUA
            // 
            this.buttonHelp_MUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MUA.Image")));
            this.buttonHelp_MUA.Location = new System.Drawing.Point(870, 12);
            this.buttonHelp_MUA.Name = "buttonHelp_MUA";
            this.buttonHelp_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonHelp_MUA.TabIndex = 3;
            this.buttonHelp_MUA.UseVisualStyleBackColor = true;
            this.buttonHelp_MUA.Click += new System.EventHandler(this.buttonHelp_MUA_Click);
            this.buttonHelp_MUA.MouseEnter += new System.EventHandler(this.buttonHelp_MUA_MouseEnter);
            // 
            // buttonSave_MUA
            // 
            this.buttonSave_MUA.Enabled = false;
            this.buttonSave_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MUA.Image")));
            this.buttonSave_MUA.Location = new System.Drawing.Point(175, 12);
            this.buttonSave_MUA.Name = "buttonSave_MUA";
            this.buttonSave_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonSave_MUA.TabIndex = 2;
            this.buttonSave_MUA.UseVisualStyleBackColor = true;
            this.buttonSave_MUA.Click += new System.EventHandler(this.buttonSave_MUA_Click);
            this.buttonSave_MUA.MouseEnter += new System.EventHandler(this.buttonSave_MUA_MouseEnter);
            // 
            // buttonOpenFile_MUA
            // 
            this.buttonOpenFile_MUA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MUA.Image")));
            this.buttonOpenFile_MUA.Location = new System.Drawing.Point(13, 12);
            this.buttonOpenFile_MUA.Name = "buttonOpenFile_MUA";
            this.buttonOpenFile_MUA.Size = new System.Drawing.Size(75, 63);
            this.buttonOpenFile_MUA.TabIndex = 1;
            this.buttonOpenFile_MUA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MUA.Click += new System.EventHandler(this.buttonOpenFile_MUA_Click);
            this.buttonOpenFile_MUA.MouseEnter += new System.EventHandler(this.buttonOpenFile_MUA_MouseEnter);
            // 
            // panelLeft_MUA
            // 
            this.panelLeft_MUA.Controls.Add(this.groupBoxInPutData_MUA);
            this.panelLeft_MUA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MUA.Location = new System.Drawing.Point(0, 233);
            this.panelLeft_MUA.Name = "panelLeft_MUA";
            this.panelLeft_MUA.Size = new System.Drawing.Size(496, 547);
            this.panelLeft_MUA.TabIndex = 0;
            // 
            // groupBoxInPutData_MUA
            // 
            this.groupBoxInPutData_MUA.Controls.Add(this.dataGridViewInPutData_MUA);
            this.groupBoxInPutData_MUA.Location = new System.Drawing.Point(12, 18);
            this.groupBoxInPutData_MUA.Name = "groupBoxInPutData_MUA";
            this.groupBoxInPutData_MUA.Size = new System.Drawing.Size(481, 526);
            this.groupBoxInPutData_MUA.TabIndex = 0;
            this.groupBoxInPutData_MUA.TabStop = false;
            this.groupBoxInPutData_MUA.Text = "Ввод:";
            // 
            // dataGridViewInPutData_MUA
            // 
            this.dataGridViewInPutData_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_MUA.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewInPutData_MUA.Name = "dataGridViewInPutData_MUA";
            this.dataGridViewInPutData_MUA.RowHeadersVisible = false;
            this.dataGridViewInPutData_MUA.RowHeadersWidth = 62;
            this.dataGridViewInPutData_MUA.RowTemplate.Height = 28;
            this.dataGridViewInPutData_MUA.Size = new System.Drawing.Size(468, 491);
            this.dataGridViewInPutData_MUA.TabIndex = 0;
            // 
            // panelRight_MUA
            // 
            this.panelRight_MUA.Controls.Add(this.groupBoxOutPutData_MUA);
            this.panelRight_MUA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_MUA.Location = new System.Drawing.Point(496, 233);
            this.panelRight_MUA.Name = "panelRight_MUA";
            this.panelRight_MUA.Size = new System.Drawing.Size(461, 547);
            this.panelRight_MUA.TabIndex = 0;
            // 
            // groupBoxOutPutData_MUA
            // 
            this.groupBoxOutPutData_MUA.Controls.Add(this.dataGridViewOutPutData_MUA);
            this.groupBoxOutPutData_MUA.Location = new System.Drawing.Point(9, 18);
            this.groupBoxOutPutData_MUA.Name = "groupBoxOutPutData_MUA";
            this.groupBoxOutPutData_MUA.Size = new System.Drawing.Size(449, 526);
            this.groupBoxOutPutData_MUA.TabIndex = 0;
            this.groupBoxOutPutData_MUA.TabStop = false;
            this.groupBoxOutPutData_MUA.Text = "Вывод:";
            // 
            // dataGridViewOutPutData_MUA
            // 
            this.dataGridViewOutPutData_MUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_MUA.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewOutPutData_MUA.Name = "dataGridViewOutPutData_MUA";
            this.dataGridViewOutPutData_MUA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_MUA.RowHeadersWidth = 62;
            this.dataGridViewOutPutData_MUA.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_MUA.Size = new System.Drawing.Size(442, 500);
            this.dataGridViewOutPutData_MUA.TabIndex = 0;
            // 
            // splitterLeft_MUA
            // 
            this.splitterLeft_MUA.Location = new System.Drawing.Point(496, 233);
            this.splitterLeft_MUA.Name = "splitterLeft_MUA";
            this.splitterLeft_MUA.Size = new System.Drawing.Size(3, 547);
            this.splitterLeft_MUA.TabIndex = 1;
            this.splitterLeft_MUA.TabStop = false;
            // 
            // toolTip_MUA
            // 
            this.toolTip_MUA.IsBalloon = true;
            this.toolTip_MUA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MUA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_MUA
            // 
            this.openFileDialog_MUA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 780);
            this.Controls.Add(this.splitterLeft_MUA);
            this.Controls.Add(this.panelRight_MUA);
            this.Controls.Add(this.panelLeft_MUA);
            this.Controls.Add(this.panelTop_MUA);
            this.MinimumSize = new System.Drawing.Size(900, 784);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Мальсагов У.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.ResumeLayout(false);
            this.groupBoxTask_MUA.PerformLayout();
            this.panelLeft_MUA.ResumeLayout(false);
            this.groupBoxInPutData_MUA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_MUA)).EndInit();
            this.panelRight_MUA.ResumeLayout(false);
            this.groupBoxOutPutData_MUA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_MUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MUA;
        private System.Windows.Forms.Panel panelLeft_MUA;
        private System.Windows.Forms.Panel panelRight_MUA;
        private System.Windows.Forms.Splitter splitterLeft_MUA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MUA;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_MUA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_MUA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_MUA;
        private System.Windows.Forms.Button buttonOpenFile_MUA;
        private System.Windows.Forms.Button buttonHelp_MUA;
        private System.Windows.Forms.Button buttonSave_MUA;
        private System.Windows.Forms.Button buttonDone_MUA;
        private System.Windows.Forms.GroupBox groupBoxTask_MUA;
        private System.Windows.Forms.TextBox textBoxTask_MUA;
        private System.Windows.Forms.ToolTip toolTip_MUA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MUA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MUA;
    }
}

