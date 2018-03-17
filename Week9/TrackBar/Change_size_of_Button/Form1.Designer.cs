namespace Change_size_of_Button
{
    partial class Form1
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
            this.tbar = new System.Windows.Forms.TrackBar();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbar
            // 
            this.tbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbar.Location = new System.Drawing.Point(12, 12);
            this.tbar.Name = "tbar";
            this.tbar.Size = new System.Drawing.Size(151, 45);
            this.tbar.TabIndex = 0;
            this.tbar.Value = 2;
            this.tbar.Scroll += new System.EventHandler(this.Scroll);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(463, 196);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(63, 52);
            this.btn.TabIndex = 1;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 517);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tbar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbar;
        private System.Windows.Forms.Button btn;
    }
}

