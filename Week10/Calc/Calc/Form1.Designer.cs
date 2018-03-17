namespace Calc
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.sinus = new System.Windows.Forms.Button();
            this.cosinus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tangent = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.cotangent = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.mSave = new System.Windows.Forms.Button();
            this.mRead = new System.Windows.Forms.Button();
            this.mPlus = new System.Windows.Forms.Button();
            this.mMinus = new System.Windows.Forms.Button();
            this.mClear = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.CheckBox();
            this.Arc = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.M_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(104, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ln";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.function_click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.LightSteelBlue;
            this.root.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(530, 125);
            this.root.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(61, 39);
            this.root.TabIndex = 6;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // negative
            // 
            this.negative.BackColor = System.Drawing.Color.LightSteelBlue;
            this.negative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negative.Location = new System.Drawing.Point(459, 125);
            this.negative.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(61, 39);
            this.negative.TabIndex = 7;
            this.negative.Text = "±";
            this.negative.UseVisualStyleBackColor = false;
            this.negative.Click += new System.EventHandler(this.Negativ_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(388, 125);
            this.Clear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(61, 39);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(317, 125);
            this.CE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(61, 39);
            this.CE.TabIndex = 9;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(246, 125);
            this.delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(61, 39);
            this.delete.TabIndex = 10;
            this.delete.Text = "←";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Del_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(104, 125);
            this.button12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 39);
            this.button12.TabIndex = 11;
            this.button12.Text = "log";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.function_click);
            // 
            // sinus
            // 
            this.sinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinus.Location = new System.Drawing.Point(33, 125);
            this.sinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(61, 39);
            this.sinus.TabIndex = 12;
            this.sinus.Text = "sin";
            this.sinus.UseVisualStyleBackColor = false;
            this.sinus.Click += new System.EventHandler(this.function_click);
            // 
            // cosinus
            // 
            this.cosinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cosinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosinus.Location = new System.Drawing.Point(33, 172);
            this.cosinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cosinus.Name = "cosinus";
            this.cosinus.Size = new System.Drawing.Size(61, 39);
            this.cosinus.TabIndex = 20;
            this.cosinus.Text = "cos";
            this.cosinus.UseVisualStyleBackColor = false;
            this.cosinus.Click += new System.EventHandler(this.function_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(104, 219);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "n!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(246, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 39);
            this.button4.TabIndex = 18;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numbers_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(317, 172);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 39);
            this.button5.TabIndex = 17;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numbers_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(388, 172);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numbers_click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(459, 172);
            this.button14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 39);
            this.button14.TabIndex = 15;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(530, 172);
            this.button15.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 39);
            this.button15.TabIndex = 14;
            this.button15.Text = "%";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(104, 266);
            this.button16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(61, 39);
            this.button16.TabIndex = 13;
            this.button16.Text = "10^x";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // tangent
            // 
            this.tangent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tangent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tangent.Location = new System.Drawing.Point(33, 219);
            this.tangent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(61, 39);
            this.tangent.TabIndex = 28;
            this.tangent.Text = "tan";
            this.tangent.UseVisualStyleBackColor = false;
            this.tangent.Click += new System.EventHandler(this.function_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(175, 219);
            this.button18.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(61, 39);
            this.button18.TabIndex = 27;
            this.button18.Text = "x^1/y";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(246, 219);
            this.button19.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 39);
            this.button19.TabIndex = 26;
            this.button19.Text = "4";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.numbers_click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(317, 219);
            this.button20.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 39);
            this.button20.TabIndex = 25;
            this.button20.Text = "5";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.numbers_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(388, 219);
            this.button21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(61, 39);
            this.button21.TabIndex = 24;
            this.button21.Text = "6";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.numbers_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(459, 219);
            this.button22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(61, 39);
            this.button22.TabIndex = 23;
            this.button22.Text = "*";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(530, 219);
            this.button23.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(61, 39);
            this.button23.TabIndex = 22;
            this.button23.Text = "1/x";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(175, 125);
            this.button24.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(61, 39);
            this.button24.TabIndex = 21;
            this.button24.Text = "x^3";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // cotangent
            // 
            this.cotangent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cotangent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cotangent.Location = new System.Drawing.Point(33, 266);
            this.cotangent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cotangent.Name = "cotangent";
            this.cotangent.Size = new System.Drawing.Size(61, 39);
            this.cotangent.TabIndex = 36;
            this.cotangent.Text = "ctg";
            this.cotangent.UseVisualStyleBackColor = false;
            this.cotangent.Click += new System.EventHandler(this.function_click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(175, 266);
            this.button26.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(61, 39);
            this.button26.TabIndex = 35;
            this.button26.Text = "x^1/3";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.LightSteelBlue;
            this.one.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(246, 266);
            this.one.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(61, 39);
            this.one.TabIndex = 34;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.numbers_click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(317, 266);
            this.button28.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(61, 39);
            this.button28.TabIndex = 33;
            this.button28.Text = "2";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.numbers_click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button29.Location = new System.Drawing.Point(388, 266);
            this.button29.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(61, 39);
            this.button29.TabIndex = 32;
            this.button29.Text = "3";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.numbers_click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.Location = new System.Drawing.Point(459, 266);
            this.button30.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(61, 39);
            this.button30.TabIndex = 31;
            this.button30.Text = "-";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button32.Location = new System.Drawing.Point(175, 172);
            this.button32.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(61, 39);
            this.button32.TabIndex = 29;
            this.button32.Text = "x^2";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.Witout_secondNumber);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.Location = new System.Drawing.Point(33, 313);
            this.button33.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(61, 39);
            this.button33.TabIndex = 44;
            this.button33.Text = "e";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button34.Location = new System.Drawing.Point(104, 313);
            this.button34.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(61, 39);
            this.button34.TabIndex = 43;
            this.button34.Text = "PI";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // mSave
            // 
            this.mSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mSave.Location = new System.Drawing.Point(246, 78);
            this.mSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(61, 39);
            this.mSave.TabIndex = 42;
            this.mSave.Text = "MS";
            this.mSave.UseVisualStyleBackColor = false;
            this.mSave.Click += new System.EventHandler(this.MS_Click);
            // 
            // mRead
            // 
            this.mRead.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mRead.Location = new System.Drawing.Point(317, 78);
            this.mRead.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mRead.Name = "mRead";
            this.mRead.Size = new System.Drawing.Size(61, 39);
            this.mRead.TabIndex = 41;
            this.mRead.Text = "MR";
            this.mRead.UseVisualStyleBackColor = false;
            this.mRead.Click += new System.EventHandler(this.memory_read);
            // 
            // mPlus
            // 
            this.mPlus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mPlus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mPlus.Location = new System.Drawing.Point(388, 78);
            this.mPlus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mPlus.Name = "mPlus";
            this.mPlus.Size = new System.Drawing.Size(61, 39);
            this.mPlus.TabIndex = 40;
            this.mPlus.Text = "M+";
            this.mPlus.UseVisualStyleBackColor = false;
            this.mPlus.Click += new System.EventHandler(this.memory_plus);
            // 
            // mMinus
            // 
            this.mMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mMinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mMinus.Location = new System.Drawing.Point(459, 78);
            this.mMinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mMinus.Name = "mMinus";
            this.mMinus.Size = new System.Drawing.Size(61, 39);
            this.mMinus.TabIndex = 39;
            this.mMinus.Text = "M-";
            this.mMinus.UseVisualStyleBackColor = false;
            this.mMinus.Click += new System.EventHandler(this.memory_minus);
            // 
            // mClear
            // 
            this.mClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mClear.Location = new System.Drawing.Point(530, 78);
            this.mClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mClear.Name = "mClear";
            this.mClear.Size = new System.Drawing.Size(61, 39);
            this.mClear.TabIndex = 38;
            this.mClear.Text = "MC";
            this.mClear.UseVisualStyleBackColor = false;
            this.mClear.Click += new System.EventHandler(this.memory_clear);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button40.Location = new System.Drawing.Point(175, 313);
            this.button40.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(61, 39);
            this.button40.TabIndex = 37;
            this.button40.Text = "x^y";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(388, 313);
            this.dot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(61, 39);
            this.dot.TabIndex = 49;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.numbers_click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.LightSteelBlue;
            this.zero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(246, 313);
            this.zero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(132, 39);
            this.zero.TabIndex = 48;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.numbers_click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button44.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button44.Location = new System.Drawing.Point(459, 313);
            this.button44.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(61, 39);
            this.button44.TabIndex = 46;
            this.button44.Text = "+";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.Operation_with_Equal);
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Input.Location = new System.Drawing.Point(33, 51);
            this.Input.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Input.MaximumSize = new System.Drawing.Size(600, 100);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(558, 19);
            this.Input.TabIndex = 54;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(530, 266);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 85);
            this.button7.TabIndex = 55;
            this.button7.Text = "=";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Result_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(175, 78);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 39);
            this.button8.TabIndex = 58;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.BackColor = System.Drawing.Color.Black;
            this.Degree.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Degree.Location = new System.Drawing.Point(33, 78);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(73, 22);
            this.Degree.TabIndex = 59;
            this.Degree.Text = "Radian";
            this.Degree.UseVisualStyleBackColor = false;
            // 
            // Arc
            // 
            this.Arc.AutoSize = true;
            this.Arc.BackColor = System.Drawing.Color.Black;
            this.Arc.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Arc.Location = new System.Drawing.Point(33, 98);
            this.Arc.Name = "Arc";
            this.Arc.Size = new System.Drawing.Size(50, 22);
            this.Arc.TabIndex = 60;
            this.Arc.Text = "Arc";
            this.Arc.UseVisualStyleBackColor = false;
            this.Arc.CheckedChanged += new System.EventHandler(this.Arc_Checked);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(33, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(558, 31);
            this.label.TabIndex = 61;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 18);
            this.label1.TabIndex = 62;
            // 
            // M_label
            // 
            this.M_label.AutoSize = true;
            this.M_label.BackColor = System.Drawing.Color.LightSteelBlue;
            this.M_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_label.Location = new System.Drawing.Point(33, 51);
            this.M_label.Name = "M_label";
            this.M_label.Size = new System.Drawing.Size(0, 15);
            this.M_label.TabIndex = 63;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.M_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arc);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.mSave);
            this.Controls.Add(this.mRead);
            this.Controls.Add(this.mPlus);
            this.Controls.Add(this.mMinus);
            this.Controls.Add(this.mClear);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.cotangent);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.one);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.cosinus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.root);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button sinus;
        private System.Windows.Forms.Button cosinus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button tangent;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button cotangent;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button mSave;
        private System.Windows.Forms.Button mRead;
        private System.Windows.Forms.Button mPlus;
        private System.Windows.Forms.Button mMinus;
        private System.Windows.Forms.Button mClear;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox Degree;
        private System.Windows.Forms.CheckBox Arc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label M_label;
    }
}

