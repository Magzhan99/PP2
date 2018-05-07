namespace Paint_start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.Button();
            this.Pencil = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Colorr = new System.Windows.Forms.Button();
            this.Romb = new System.Windows.Forms.Button();
            this.BesBurysh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cube = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.Color1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Color2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Line
            // 
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.Location = new System.Drawing.Point(6, 93);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(25, 25);
            this.Line.TabIndex = 5;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Pencil
            // 
            this.Pencil.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.Location = new System.Drawing.Point(6, 31);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(25, 25);
            this.Pencil.TabIndex = 6;
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Eraser
            // 
            this.Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.Location = new System.Drawing.Point(34, 31);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(25, 25);
            this.Eraser.TabIndex = 7;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Triangle
            // 
            this.Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.Location = new System.Drawing.Point(34, 124);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(25, 25);
            this.Triangle.TabIndex = 8;
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Circle
            // 
            this.Circle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.Location = new System.Drawing.Point(6, 124);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(25, 25);
            this.Circle.TabIndex = 9;
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.HelpRequest += new System.EventHandler(this.Color_Click);
            // 
            // Colorr
            // 
            this.Colorr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Colorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Colorr.Image = ((System.Drawing.Image)(resources.GetObject("Colorr.Image")));
            this.Colorr.Location = new System.Drawing.Point(180, 549);
            this.Colorr.Name = "Colorr";
            this.Colorr.Size = new System.Drawing.Size(20, 20);
            this.Colorr.TabIndex = 11;
            this.Colorr.UseVisualStyleBackColor = false;
            this.Colorr.Click += new System.EventHandler(this.Color_Click);
            // 
            // Romb
            // 
            this.Romb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Romb.Image = ((System.Drawing.Image)(resources.GetObject("Romb.Image")));
            this.Romb.Location = new System.Drawing.Point(6, 155);
            this.Romb.Name = "Romb";
            this.Romb.Size = new System.Drawing.Size(25, 25);
            this.Romb.TabIndex = 12;
            this.Romb.UseVisualStyleBackColor = true;
            this.Romb.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // BesBurysh
            // 
            this.BesBurysh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BesBurysh.Image = ((System.Drawing.Image)(resources.GetObject("BesBurysh.Image")));
            this.BesBurysh.Location = new System.Drawing.Point(6, 186);
            this.BesBurysh.Name = "BesBurysh";
            this.BesBurysh.Size = new System.Drawing.Size(25, 25);
            this.BesBurysh.TabIndex = 13;
            this.BesBurysh.UseVisualStyleBackColor = true;
            this.BesBurysh.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.AutoSize = false;
            this.fIleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fIleToolStripMenuItem.Image")));
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Cube
            // 
            this.Cube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube.Image = ((System.Drawing.Image)(resources.GetObject("Cube.Image")));
            this.Cube.Location = new System.Drawing.Point(34, 155);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(25, 25);
            this.Cube.TabIndex = 18;
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Location = new System.Drawing.Point(34, 93);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(25, 25);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Fill
            // 
            this.Fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.Location = new System.Drawing.Point(6, 62);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(25, 25);
            this.Fill.TabIndex = 19;
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(155, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(130, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(105, 549);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(80, 549);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(55, 549);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 20);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Colorss_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(30, 549);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 20);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Colorss_click);
            // 
            // Choose
            // 
            this.Choose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Choose.Image = ((System.Drawing.Image)(resources.GetObject("Choose.Image")));
            this.Choose.Location = new System.Drawing.Point(34, 62);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(25, 25);
            this.Choose.TabIndex = 28;
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.Black;
            this.Color1.Enabled = false;
            this.Color1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Color1.Location = new System.Drawing.Point(-1, -1);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(25, 25);
            this.Color1.TabIndex = 30;
            this.Color1.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(244, 549);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb2);
            this.splitContainer1.Size = new System.Drawing.Size(222, 20);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 34;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(2, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(184, 20);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(3, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(186, 20);
            this.tb2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 298);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Color1);
            this.panel1.Location = new System.Drawing.Point(6, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 57);
            this.panel1.TabIndex = 36;
            this.panel1.Click += new System.EventHandler(this.panels_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "1st";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Color2);
            this.panel2.Location = new System.Drawing.Point(37, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 57);
            this.panel2.TabIndex = 37;
            this.panel2.Click += new System.EventHandler(this.panels_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "2nd";
            // 
            // Color2
            // 
            this.Color2.Enabled = false;
            this.Color2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Color2.Location = new System.Drawing.Point(-1, -1);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(25, 25);
            this.Color2.TabIndex = 30;
            this.Color2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.BesBurysh);
            this.Controls.Add(this.Romb);
            this.Controls.Add(this.Colorr);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Colorr;
        private System.Windows.Forms.Button Romb;
        private System.Windows.Forms.Button BesBurysh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Color2;
        private System.Windows.Forms.Label label2;
    }
}

