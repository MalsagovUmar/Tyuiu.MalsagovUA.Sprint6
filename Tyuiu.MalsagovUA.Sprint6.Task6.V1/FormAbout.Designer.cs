
namespace Tyuiu.MalsagovUA.Sprint6.Task6.V1
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
            this.pictureBoxAbout_MUA = new System.Windows.Forms.PictureBox();
            this.buttonOK_MUA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_MUA
            // 
            this.pictureBoxAbout_MUA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_MUA.Image")));
            this.pictureBoxAbout_MUA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout_MUA.Name = "pictureBoxAbout_MUA";
            this.pictureBoxAbout_MUA.Size = new System.Drawing.Size(263, 348);
            this.pictureBoxAbout_MUA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout_MUA.TabIndex = 0;
            this.pictureBoxAbout_MUA.TabStop = false;
            // 
            // buttonOK_MUA
            // 
            this.buttonOK_MUA.Location = new System.Drawing.Point(687, 394);
            this.buttonOK_MUA.Name = "buttonOK_MUA";
            this.buttonOK_MUA.Size = new System.Drawing.Size(101, 44);
            this.buttonOK_MUA.TabIndex = 2;
            this.buttonOK_MUA.Text = "ОК";
            this.buttonOK_MUA.UseVisualStyleBackColor = true;
            this.buttonOK_MUA.Click += new System.EventHandler(this.buttonOK_MUA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(506, 348);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOK_MUA);
            this.Controls.Add(this.pictureBoxAbout_MUA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_MUA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_MUA;
        private System.Windows.Forms.Button buttonOK_MUA;
        private System.Windows.Forms.TextBox textBox1;
    }
}