
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
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.pictureBoxPinClip = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinClip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(162, 22);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(14, 205);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWord.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWord.Location = new System.Drawing.Point(24, 28);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(100, 28);
            this.textBoxWord.TabIndex = 2;
            this.textBoxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWord_KeyDown);
            // 
            // pictureBoxPinClip
            // 
            this.pictureBoxPinClip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxPinClip.Image = global::OsseticCorpus.Properties.Resources.PinClipBlack;
            this.pictureBoxPinClip.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxPinClip.Name = "pictureBoxPinClip";
            this.pictureBoxPinClip.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxPinClip.TabIndex = 3;
            this.pictureBoxPinClip.TabStop = false;
            this.pictureBoxPinClip.Click += new System.EventHandler(this.pictureBoxPinClip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OsseticCorpus.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(153, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(176, 249);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPinClip);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.vScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWord_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinClip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.PictureBox pictureBoxPinClip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

