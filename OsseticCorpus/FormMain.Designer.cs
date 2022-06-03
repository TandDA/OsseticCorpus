
namespace OsseticCorpus
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPinClip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinClip)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWord.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWord.Location = new System.Drawing.Point(32, 34);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(133, 34);
            this.textBoxWord.TabIndex = 2;
            this.textBoxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWord_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OsseticCorpus.Properties.Resources.CrossRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(204, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPinClip
            // 
            this.pictureBoxPinClip.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPinClip.Image = global::OsseticCorpus.Properties.Resources.PinClipBlack;
            this.pictureBoxPinClip.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxPinClip.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPinClip.Name = "pictureBoxPinClip";
            this.pictureBoxPinClip.Size = new System.Drawing.Size(31, 26);
            this.pictureBoxPinClip.TabIndex = 3;
            this.pictureBoxPinClip.TabStop = false;
            this.pictureBoxPinClip.Click += new System.EventHandler(this.pictureBoxPinClip_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(235, 306);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPinClip);
            this.Controls.Add(this.textBoxWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWord_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinClip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.PictureBox pictureBoxPinClip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

