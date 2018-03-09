namespace StartUpCalc
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
            this.Input = new System.Windows.Forms.TextBox();
            this.MS = new System.Windows.Forms.Button();
            this.sinus = new System.Windows.Forms.Button();
            this.cosinus = new System.Windows.Forms.Button();
            this.tangens = new System.Windows.Forms.Button();
            this.negativ = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.mplus = new System.Windows.Forms.Button();
            this.mminus = new System.Windows.Forms.Button();
            this.mclear = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.loge = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.DecLog = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.PowRoot = new System.Windows.Forms.Button();
            this.ThirdDegree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(22, 27);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(342, 20);
            this.Input.TabIndex = 0;
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(22, 64);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(44, 36);
            this.MS.TabIndex = 1;
            this.MS.Text = "ms";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // sinus
            // 
            this.sinus.Location = new System.Drawing.Point(72, 233);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(44, 36);
            this.sinus.TabIndex = 2;
            this.sinus.Text = "sin";
            this.sinus.UseVisualStyleBackColor = true;
            this.sinus.Click += new System.EventHandler(this.operation_click);
            // 
            // cosinus
            // 
            this.cosinus.Location = new System.Drawing.Point(122, 232);
            this.cosinus.Name = "cosinus";
            this.cosinus.Size = new System.Drawing.Size(44, 36);
            this.cosinus.TabIndex = 3;
            this.cosinus.Text = "cos";
            this.cosinus.UseVisualStyleBackColor = true;
            this.cosinus.Click += new System.EventHandler(this.operation_click);
            // 
            // tangens
            // 
            this.tangens.Location = new System.Drawing.Point(171, 232);
            this.tangens.Name = "tangens";
            this.tangens.Size = new System.Drawing.Size(44, 36);
            this.tangens.TabIndex = 4;
            this.tangens.Text = "tan";
            this.tangens.UseVisualStyleBackColor = true;
            this.tangens.Click += new System.EventHandler(this.operation_click);
            // 
            // negativ
            // 
            this.negativ.Location = new System.Drawing.Point(271, 64);
            this.negativ.Name = "negativ";
            this.negativ.Size = new System.Drawing.Size(44, 36);
            this.negativ.TabIndex = 5;
            this.negativ.Text = "+/-";
            this.negativ.UseVisualStyleBackColor = true;
            this.negativ.Click += new System.EventHandler(this.negativ_Click);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(321, 64);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(43, 36);
            this.devide.TabIndex = 6;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.operation_click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(171, 64);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(44, 36);
            this.clear.TabIndex = 7;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(221, 64);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(44, 36);
            this.del.TabIndex = 8;
            this.del.Text = "<---";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(22, 106);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(44, 36);
            this.MR.TabIndex = 9;
            this.MR.Text = "mr";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.memory_read);
            // 
            // mplus
            // 
            this.mplus.Location = new System.Drawing.Point(22, 148);
            this.mplus.Name = "mplus";
            this.mplus.Size = new System.Drawing.Size(44, 36);
            this.mplus.TabIndex = 10;
            this.mplus.Text = "m+";
            this.mplus.UseVisualStyleBackColor = true;
            this.mplus.Click += new System.EventHandler(this.memory_plus);
            // 
            // mminus
            // 
            this.mminus.Location = new System.Drawing.Point(22, 190);
            this.mminus.Name = "mminus";
            this.mminus.Size = new System.Drawing.Size(44, 36);
            this.mminus.TabIndex = 11;
            this.mminus.Text = "m-";
            this.mminus.UseVisualStyleBackColor = true;
            this.mminus.Click += new System.EventHandler(this.memory_minus);
            // 
            // mclear
            // 
            this.mclear.Location = new System.Drawing.Point(22, 233);
            this.mclear.Name = "mclear";
            this.mclear.Size = new System.Drawing.Size(44, 36);
            this.mclear.TabIndex = 12;
            this.mclear.Text = "mc";
            this.mclear.UseVisualStyleBackColor = true;
            this.mclear.Click += new System.EventHandler(this.memory_clear);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(122, 106);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(44, 36);
            this.factorial.TabIndex = 13;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.operation_click);
            // 
            // loge
            // 
            this.loge.Location = new System.Drawing.Point(72, 65);
            this.loge.Name = "loge";
            this.loge.Size = new System.Drawing.Size(44, 36);
            this.loge.TabIndex = 14;
            this.loge.Text = "ln";
            this.loge.UseVisualStyleBackColor = true;
            this.loge.Click += new System.EventHandler(this.operation_click);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(122, 148);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(44, 36);
            this.root.TabIndex = 17;
            this.root.Text = "--/```";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.operation_click);
            // 
            // DecLog
            // 
            this.DecLog.Location = new System.Drawing.Point(121, 65);
            this.DecLog.Name = "DecLog";
            this.DecLog.Size = new System.Drawing.Size(44, 36);
            this.DecLog.TabIndex = 18;
            this.DecLog.Text = "log";
            this.DecLog.UseVisualStyleBackColor = true;
            this.DecLog.Click += new System.EventHandler(this.operation_click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(71, 107);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(44, 36);
            this.percent.TabIndex = 21;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.operation_click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(72, 149);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(44, 36);
            this.power.TabIndex = 22;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.operation_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(171, 106);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(44, 36);
            this.seven.TabIndex = 25;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.numbers_click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(171, 148);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(44, 36);
            this.four.TabIndex = 26;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.numbers_click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(171, 190);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(44, 36);
            this.one.TabIndex = 27;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.numbers_click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(221, 190);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(44, 36);
            this.two.TabIndex = 28;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.numbers_click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(221, 148);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(44, 36);
            this.five.TabIndex = 29;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.numbers_click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(221, 106);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(44, 36);
            this.eight.TabIndex = 30;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.numbers_click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(270, 106);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(44, 36);
            this.nine.TabIndex = 31;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.numbers_click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(321, 106);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(44, 36);
            this.multiply.TabIndex = 32;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(320, 148);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(44, 36);
            this.minus.TabIndex = 33;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operation_click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(270, 148);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(44, 36);
            this.six.TabIndex = 34;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.numbers_click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(270, 190);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(44, 36);
            this.three.TabIndex = 35;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.numbers_click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(320, 190);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(44, 36);
            this.plus.TabIndex = 36;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operation_click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(270, 232);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(44, 36);
            this.dot.TabIndex = 37;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.numbers_click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(321, 232);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(44, 36);
            this.equal.TabIndex = 38;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.result_click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.zero.Location = new System.Drawing.Point(221, 232);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(43, 36);
            this.zero.TabIndex = 39;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numbers_click);
            // 
            // PowRoot
            // 
            this.PowRoot.Location = new System.Drawing.Point(122, 190);
            this.PowRoot.Name = "PowRoot";
            this.PowRoot.Size = new System.Drawing.Size(43, 36);
            this.PowRoot.TabIndex = 40;
            this.PowRoot.Text = "x^1/y";
            this.PowRoot.UseVisualStyleBackColor = true;
            this.PowRoot.Click += new System.EventHandler(this.operation_click);
            // 
            // ThirdDegree
            // 
            this.ThirdDegree.Location = new System.Drawing.Point(72, 191);
            this.ThirdDegree.Name = "ThirdDegree";
            this.ThirdDegree.Size = new System.Drawing.Size(43, 36);
            this.ThirdDegree.TabIndex = 41;
            this.ThirdDegree.Text = "x^1/3";
            this.ThirdDegree.UseVisualStyleBackColor = true;
            this.ThirdDegree.Click += new System.EventHandler(this.operation_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.ThirdDegree);
            this.Controls.Add(this.PowRoot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.power);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.DecLog);
            this.Controls.Add(this.root);
            this.Controls.Add(this.loge);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.mclear);
            this.Controls.Add(this.mminus);
            this.Controls.Add(this.mplus);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.del);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.negativ);
            this.Controls.Add(this.tangens);
            this.Controls.Add(this.cosinus);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.numbers_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.Button sinus;
        private System.Windows.Forms.Button cosinus;
        private System.Windows.Forms.Button tangens;
        private System.Windows.Forms.Button negativ;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button mplus;
        private System.Windows.Forms.Button mminus;
        private System.Windows.Forms.Button mclear;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button loge;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button DecLog;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button PowRoot;
        private System.Windows.Forms.Button ThirdDegree;
    }
}

