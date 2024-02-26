namespace AdvanceCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResult = new TextBox();
            backBtn = new Button();
            btnCE = new Button();
            btnC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnplus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn2 = new Button();
            btnsub = new Button();
            btn3 = new Button();
            btnmultpily = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnequals = new Button();
            btndivide = new Button();
            PMSButton = new Button();
            Pi_Button = new Button();
            Sqrtbtn = new Button();
            SquareBtn = new Button();
            Sinhbtn = new Button();
            Sinbtn = new Button();
            DecBtn = new Button();
            CubeBtn = new Button();
            CoshBtn = new Button();
            CosBtn = new Button();
            Tanhbtn = new Button();
            BinBtn = new Button();
            TanBtn = new Button();
            divbyxBtn = new Button();
            HexaBtn = new Button();
            lnXbtn = new Button();
            ExponentBtn = new Button();
            ModBtn = new Button();
            OctaBtn = new Button();
            PercentangeBtn = new Button();
            Log_button = new Button();
            MaximizeButton = new Button();
            MinimizeButton = new Button();
            panel1 = new Panel();
            ExitBtn = new Button();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            MenuTitle = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            Historybutton = new Button();
            LightAndDarkbtn = new Button();
            FactorialBtn = new Button();
            powxy = new Button();
            MPlusButton = new Button();
            MMinusButton = new Button();
            MRButton = new Button();
            MCButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(50, 50, 50);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Gadugi", 22F, FontStyle.Bold);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(34, 249);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(1568, 100);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(40, 40, 40);
            backBtn.FlatAppearance.BorderColor = Color.Gray;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Arial", 14.1F);
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(627, 400);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(174, 138);
            backBtn.TabIndex = 1;
            backBtn.Text = "⇐";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(40, 40, 40);
            btnCE.FlatAppearance.BorderColor = Color.Gray;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Arial", 14.1F);
            btnCE.ForeColor = Color.White;
            btnCE.Location = new Point(233, 400);
            btnCE.Margin = new Padding(0);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(174, 138);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(40, 40, 40);
            btnC.FlatAppearance.BorderColor = Color.Gray;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Arial", 14.1F);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(426, 400);
            btnC.Margin = new Padding(0);
            btnC.Name = "btnC";
            btnC.Size = new Size(174, 138);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += HandleClear;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(59, 59, 59);
            btn7.FlatAppearance.BorderColor = Color.Gray;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Arial", 14.1F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(34, 722);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(174, 138);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += NumbersEntry;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(59, 59, 59);
            btn8.FlatAppearance.BorderColor = Color.Gray;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Arial", 14.1F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(233, 720);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(174, 138);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += NumbersEntry;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(59, 59, 59);
            btn9.FlatAppearance.BorderColor = Color.Gray;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Arial", 14.1F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(426, 720);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(174, 138);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += NumbersEntry;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.FromArgb(40, 40, 40);
            btnplus.FlatAppearance.BorderColor = Color.Gray;
            btnplus.FlatStyle = FlatStyle.Flat;
            btnplus.Font = new Font("Arial", 14.1F);
            btnplus.ForeColor = Color.White;
            btnplus.Location = new Point(627, 1042);
            btnplus.Margin = new Padding(0);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(174, 138);
            btnplus.TabIndex = 1;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += HandleOperations;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(59, 59, 59);
            btn4.FlatAppearance.BorderColor = Color.Gray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial", 14.1F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(34, 883);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(174, 138);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += NumbersEntry;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(59, 59, 59);
            btn5.FlatAppearance.BorderColor = Color.Gray;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Arial", 14.1F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(233, 881);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(174, 138);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += NumbersEntry;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(59, 59, 59);
            btn1.FlatAppearance.BorderColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial", 14.1F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(34, 1046);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(174, 138);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += NumbersEntry;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(59, 59, 59);
            btn6.FlatAppearance.BorderColor = Color.Gray;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Arial", 14.1F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(426, 881);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(174, 138);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += NumbersEntry;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(59, 59, 59);
            btn2.FlatAppearance.BorderColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial", 14.1F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(233, 1044);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(174, 138);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += NumbersEntry;
            // 
            // btnsub
            // 
            btnsub.BackColor = Color.FromArgb(40, 40, 40);
            btnsub.FlatAppearance.BorderColor = Color.Gray;
            btnsub.FlatStyle = FlatStyle.Flat;
            btnsub.Font = new Font("Arial", 14.1F);
            btnsub.ForeColor = Color.White;
            btnsub.Location = new Point(627, 881);
            btnsub.Margin = new Padding(0);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(174, 138);
            btnsub.TabIndex = 1;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += HandleOperations;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(59, 59, 59);
            btn3.FlatAppearance.BorderColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial", 14.1F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(426, 1044);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(174, 138);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += NumbersEntry;
            // 
            // btnmultpily
            // 
            btnmultpily.BackColor = Color.FromArgb(40, 40, 40);
            btnmultpily.FlatAppearance.BorderColor = Color.Gray;
            btnmultpily.FlatStyle = FlatStyle.Flat;
            btnmultpily.Font = new Font("Arial", 10F);
            btnmultpily.ForeColor = Color.White;
            btnmultpily.Location = new Point(627, 720);
            btnmultpily.Margin = new Padding(0);
            btnmultpily.Name = "btnmultpily";
            btnmultpily.Size = new Size(174, 138);
            btnmultpily.TabIndex = 1;
            btnmultpily.Text = "X";
            btnmultpily.UseVisualStyleBackColor = false;
            btnmultpily.Click += HandleOperations;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(59, 59, 59);
            btn0.FlatAppearance.BorderColor = Color.Gray;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Arial", 14.1F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(233, 1205);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new Size(174, 138);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NumbersEntry;
            // 
            // btndot
            // 
            btndot.BackColor = Color.FromArgb(50, 50, 50);
            btndot.FlatAppearance.BorderColor = Color.Gray;
            btndot.FlatStyle = FlatStyle.Flat;
            btndot.Font = new Font("Arial", 14.1F);
            btndot.ForeColor = Color.White;
            btndot.Location = new Point(426, 1205);
            btndot.Margin = new Padding(0);
            btndot.Name = "btndot";
            btndot.Size = new Size(174, 138);
            btndot.TabIndex = 1;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += NumbersEntry;
            // 
            // btnequals
            // 
            btnequals.BackColor = Color.FromArgb(243, 128, 100);
            btnequals.FlatAppearance.BorderColor = Color.Gray;
            btnequals.FlatStyle = FlatStyle.Flat;
            btnequals.Font = new Font("Arial Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnequals.ForeColor = Color.White;
            btnequals.Location = new Point(627, 1207);
            btnequals.Margin = new Padding(0);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(174, 138);
            btnequals.TabIndex = 1;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = false;
            btnequals.Click += HandleEquals;
            // 
            // btndivide
            // 
            btndivide.BackColor = Color.FromArgb(40, 40, 40);
            btndivide.FlatAppearance.BorderColor = Color.Gray;
            btndivide.FlatStyle = FlatStyle.Flat;
            btndivide.Font = new Font("Arial", 14.1F);
            btndivide.ForeColor = Color.White;
            btndivide.Location = new Point(627, 565);
            btndivide.Margin = new Padding(0);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(174, 138);
            btndivide.TabIndex = 1;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += HandleOperations;
            // 
            // PMSButton
            // 
            PMSButton.BackColor = Color.FromArgb(50, 50, 50);
            PMSButton.FlatAppearance.BorderColor = Color.Gray;
            PMSButton.FlatStyle = FlatStyle.Flat;
            PMSButton.Font = new Font("Arial", 14.1F);
            PMSButton.ForeColor = Color.White;
            PMSButton.Location = new Point(34, 1209);
            PMSButton.Margin = new Padding(0);
            PMSButton.Name = "PMSButton";
            PMSButton.Size = new Size(174, 138);
            PMSButton.TabIndex = 1;
            PMSButton.Text = "±";
            PMSButton.UseVisualStyleBackColor = false;
            PMSButton.Click += handlePms;
            // 
            // Pi_Button
            // 
            Pi_Button.BackColor = Color.FromArgb(40, 40, 40);
            Pi_Button.FlatAppearance.BorderColor = Color.Gray;
            Pi_Button.FlatStyle = FlatStyle.Flat;
            Pi_Button.Font = new Font("Arial", 14.1F);
            Pi_Button.ForeColor = Color.White;
            Pi_Button.Location = new Point(837, 402);
            Pi_Button.Margin = new Padding(0);
            Pi_Button.Name = "Pi_Button";
            Pi_Button.Size = new Size(174, 138);
            Pi_Button.TabIndex = 1;
            Pi_Button.Text = "π";
            Pi_Button.UseVisualStyleBackColor = false;
            Pi_Button.Click += HandlePi;
            // 
            // Sqrtbtn
            // 
            Sqrtbtn.BackColor = Color.FromArgb(40, 40, 40);
            Sqrtbtn.FlatAppearance.BorderColor = Color.Gray;
            Sqrtbtn.FlatStyle = FlatStyle.Flat;
            Sqrtbtn.Font = new Font("Arial", 14.1F);
            Sqrtbtn.ForeColor = Color.White;
            Sqrtbtn.Location = new Point(426, 561);
            Sqrtbtn.Margin = new Padding(0);
            Sqrtbtn.Name = "Sqrtbtn";
            Sqrtbtn.Size = new Size(174, 138);
            Sqrtbtn.TabIndex = 1;
            Sqrtbtn.Text = "√";
            Sqrtbtn.UseVisualStyleBackColor = false;
            Sqrtbtn.Click += HandleSqrt;
            // 
            // SquareBtn
            // 
            SquareBtn.BackColor = Color.FromArgb(40, 40, 40);
            SquareBtn.FlatAppearance.BorderColor = Color.Gray;
            SquareBtn.FlatStyle = FlatStyle.Flat;
            SquareBtn.Font = new Font("Arial", 14.1F);
            SquareBtn.ForeColor = Color.White;
            SquareBtn.Location = new Point(233, 561);
            SquareBtn.Margin = new Padding(0);
            SquareBtn.Name = "SquareBtn";
            SquareBtn.Size = new Size(174, 138);
            SquareBtn.TabIndex = 1;
            SquareBtn.Text = "x²";
            SquareBtn.UseVisualStyleBackColor = false;
            SquareBtn.Click += HandleSquare;
            // 
            // Sinhbtn
            // 
            Sinhbtn.BackColor = Color.FromArgb(60, 60, 60);
            Sinhbtn.FlatAppearance.BorderColor = Color.Gray;
            Sinhbtn.FlatStyle = FlatStyle.Flat;
            Sinhbtn.Font = new Font("Arial", 14.1F);
            Sinhbtn.ForeColor = Color.White;
            Sinhbtn.Location = new Point(837, 724);
            Sinhbtn.Margin = new Padding(0);
            Sinhbtn.Name = "Sinhbtn";
            Sinhbtn.Size = new Size(174, 138);
            Sinhbtn.TabIndex = 1;
            Sinhbtn.Text = "sinh";
            Sinhbtn.UseVisualStyleBackColor = false;
            Sinhbtn.Click += HandleSinh;
            // 
            // Sinbtn
            // 
            Sinbtn.BackColor = Color.FromArgb(60, 60, 60);
            Sinbtn.FlatAppearance.BorderColor = Color.Gray;
            Sinbtn.FlatStyle = FlatStyle.Flat;
            Sinbtn.Font = new Font("Arial", 14.1F);
            Sinbtn.ForeColor = Color.White;
            Sinbtn.Location = new Point(1030, 722);
            Sinbtn.Margin = new Padding(0);
            Sinbtn.Name = "Sinbtn";
            Sinbtn.Size = new Size(174, 138);
            Sinbtn.TabIndex = 1;
            Sinbtn.Text = "sin";
            Sinbtn.UseVisualStyleBackColor = false;
            Sinbtn.Click += HandleSin;
            // 
            // DecBtn
            // 
            DecBtn.BackColor = Color.FromArgb(60, 60, 60);
            DecBtn.FlatAppearance.BorderColor = Color.Gray;
            DecBtn.FlatStyle = FlatStyle.Flat;
            DecBtn.Font = new Font("Arial", 14.1F);
            DecBtn.ForeColor = Color.White;
            DecBtn.Location = new Point(837, 565);
            DecBtn.Margin = new Padding(0);
            DecBtn.Name = "DecBtn";
            DecBtn.Size = new Size(174, 138);
            DecBtn.TabIndex = 1;
            DecBtn.Text = "Dec";
            DecBtn.UseVisualStyleBackColor = false;
            DecBtn.Click += HandleDec;
            // 
            // CubeBtn
            // 
            CubeBtn.BackColor = Color.FromArgb(40, 40, 40);
            CubeBtn.FlatAppearance.BorderColor = Color.Gray;
            CubeBtn.FlatStyle = FlatStyle.Flat;
            CubeBtn.Font = new Font("Arial", 14.1F);
            CubeBtn.ForeColor = Color.White;
            CubeBtn.Location = new Point(1230, 404);
            CubeBtn.Margin = new Padding(0);
            CubeBtn.Name = "CubeBtn";
            CubeBtn.Size = new Size(174, 138);
            CubeBtn.TabIndex = 1;
            CubeBtn.Text = "x³";
            CubeBtn.UseVisualStyleBackColor = false;
            CubeBtn.Click += HandleCube;
            // 
            // CoshBtn
            // 
            CoshBtn.BackColor = Color.FromArgb(60, 60, 60);
            CoshBtn.FlatAppearance.BorderColor = Color.Gray;
            CoshBtn.FlatStyle = FlatStyle.Flat;
            CoshBtn.Font = new Font("Arial", 14.1F);
            CoshBtn.ForeColor = Color.White;
            CoshBtn.Location = new Point(837, 885);
            CoshBtn.Margin = new Padding(0);
            CoshBtn.Name = "CoshBtn";
            CoshBtn.Size = new Size(174, 138);
            CoshBtn.TabIndex = 1;
            CoshBtn.Text = "cosh";
            CoshBtn.UseVisualStyleBackColor = false;
            CoshBtn.Click += HandleCosh;
            // 
            // CosBtn
            // 
            CosBtn.BackColor = Color.FromArgb(60, 60, 60);
            CosBtn.FlatAppearance.BorderColor = Color.Gray;
            CosBtn.FlatStyle = FlatStyle.Flat;
            CosBtn.Font = new Font("Arial", 14.1F);
            CosBtn.ForeColor = Color.White;
            CosBtn.Location = new Point(1030, 883);
            CosBtn.Margin = new Padding(0);
            CosBtn.Name = "CosBtn";
            CosBtn.Size = new Size(174, 138);
            CosBtn.TabIndex = 1;
            CosBtn.Text = "cos";
            CosBtn.UseVisualStyleBackColor = false;
            CosBtn.Click += HandleCos;
            // 
            // Tanhbtn
            // 
            Tanhbtn.BackColor = Color.FromArgb(60, 60, 60);
            Tanhbtn.FlatAppearance.BorderColor = Color.Gray;
            Tanhbtn.FlatStyle = FlatStyle.Flat;
            Tanhbtn.Font = new Font("Arial", 14.1F);
            Tanhbtn.ForeColor = Color.White;
            Tanhbtn.Location = new Point(837, 1044);
            Tanhbtn.Margin = new Padding(0);
            Tanhbtn.Name = "Tanhbtn";
            Tanhbtn.Size = new Size(174, 138);
            Tanhbtn.TabIndex = 1;
            Tanhbtn.Text = "tanh";
            Tanhbtn.UseVisualStyleBackColor = false;
            Tanhbtn.Click += HandleTanh;
            // 
            // BinBtn
            // 
            BinBtn.BackColor = Color.FromArgb(60, 60, 60);
            BinBtn.FlatAppearance.BorderColor = Color.Gray;
            BinBtn.FlatStyle = FlatStyle.Flat;
            BinBtn.Font = new Font("Arial", 14.1F);
            BinBtn.ForeColor = Color.White;
            BinBtn.Location = new Point(1030, 565);
            BinBtn.Margin = new Padding(0);
            BinBtn.Name = "BinBtn";
            BinBtn.Size = new Size(174, 138);
            BinBtn.TabIndex = 1;
            BinBtn.Text = "Bin";
            BinBtn.UseVisualStyleBackColor = false;
            BinBtn.Click += HandleBin;
            // 
            // TanBtn
            // 
            TanBtn.BackColor = Color.FromArgb(60, 60, 60);
            TanBtn.FlatAppearance.BorderColor = Color.Gray;
            TanBtn.FlatStyle = FlatStyle.Flat;
            TanBtn.Font = new Font("Arial", 14.1F);
            TanBtn.ForeColor = Color.White;
            TanBtn.Location = new Point(1030, 1042);
            TanBtn.Margin = new Padding(0);
            TanBtn.Name = "TanBtn";
            TanBtn.Size = new Size(174, 138);
            TanBtn.TabIndex = 1;
            TanBtn.Text = "tan";
            TanBtn.UseVisualStyleBackColor = false;
            TanBtn.Click += HandleTan;
            // 
            // divbyxBtn
            // 
            divbyxBtn.BackColor = Color.FromArgb(40, 40, 40);
            divbyxBtn.FlatAppearance.BorderColor = Color.Gray;
            divbyxBtn.FlatStyle = FlatStyle.Flat;
            divbyxBtn.Font = new Font("Arial", 14.1F);
            divbyxBtn.ForeColor = Color.White;
            divbyxBtn.Location = new Point(34, 563);
            divbyxBtn.Margin = new Padding(0);
            divbyxBtn.Name = "divbyxBtn";
            divbyxBtn.Size = new Size(174, 138);
            divbyxBtn.TabIndex = 1;
            divbyxBtn.Text = "1/x";
            divbyxBtn.UseVisualStyleBackColor = false;
            divbyxBtn.Click += HandleOneByX;
            // 
            // HexaBtn
            // 
            HexaBtn.BackColor = Color.FromArgb(60, 60, 60);
            HexaBtn.FlatAppearance.BorderColor = Color.Gray;
            HexaBtn.FlatStyle = FlatStyle.Flat;
            HexaBtn.Font = new Font("Arial", 14.1F);
            HexaBtn.ForeColor = Color.White;
            HexaBtn.Location = new Point(1230, 724);
            HexaBtn.Margin = new Padding(0);
            HexaBtn.Name = "HexaBtn";
            HexaBtn.Size = new Size(174, 138);
            HexaBtn.TabIndex = 1;
            HexaBtn.Text = "Hex";
            HexaBtn.UseVisualStyleBackColor = false;
            HexaBtn.Click += HandleHexa;
            // 
            // lnXbtn
            // 
            lnXbtn.BackColor = Color.FromArgb(40, 40, 40);
            lnXbtn.FlatAppearance.BorderColor = Color.Gray;
            lnXbtn.FlatStyle = FlatStyle.Flat;
            lnXbtn.Font = new Font("Arial", 14.1F);
            lnXbtn.ForeColor = Color.White;
            lnXbtn.Location = new Point(1428, 563);
            lnXbtn.Margin = new Padding(0);
            lnXbtn.Name = "lnXbtn";
            lnXbtn.Size = new Size(174, 138);
            lnXbtn.TabIndex = 1;
            lnXbtn.Text = "ln x";
            lnXbtn.UseVisualStyleBackColor = false;
            lnXbtn.Click += HandleLnX;
            // 
            // ExponentBtn
            // 
            ExponentBtn.BackColor = Color.FromArgb(60, 60, 60);
            ExponentBtn.FlatAppearance.BorderColor = Color.Gray;
            ExponentBtn.FlatStyle = FlatStyle.Flat;
            ExponentBtn.Font = new Font("Arial", 14.1F);
            ExponentBtn.ForeColor = Color.White;
            ExponentBtn.Location = new Point(837, 1209);
            ExponentBtn.Margin = new Padding(0);
            ExponentBtn.Name = "ExponentBtn";
            ExponentBtn.Size = new Size(174, 138);
            ExponentBtn.TabIndex = 1;
            ExponentBtn.Text = "Exp";
            ExponentBtn.UseVisualStyleBackColor = false;
            ExponentBtn.Click += HandleExp;
            // 
            // ModBtn
            // 
            ModBtn.BackColor = Color.FromArgb(60, 60, 60);
            ModBtn.FlatAppearance.BorderColor = Color.Gray;
            ModBtn.FlatStyle = FlatStyle.Flat;
            ModBtn.Font = new Font("Arial", 14.1F);
            ModBtn.ForeColor = Color.White;
            ModBtn.Location = new Point(1030, 1207);
            ModBtn.Margin = new Padding(0);
            ModBtn.Name = "ModBtn";
            ModBtn.Size = new Size(174, 138);
            ModBtn.TabIndex = 1;
            ModBtn.Text = "Mod";
            ModBtn.UseVisualStyleBackColor = false;
            ModBtn.Click += HandleMod;
            // 
            // OctaBtn
            // 
            OctaBtn.BackColor = Color.FromArgb(60, 60, 60);
            OctaBtn.FlatAppearance.BorderColor = Color.Gray;
            OctaBtn.FlatStyle = FlatStyle.Flat;
            OctaBtn.Font = new Font("Arial", 14.1F);
            OctaBtn.ForeColor = Color.White;
            OctaBtn.Location = new Point(1230, 567);
            OctaBtn.Margin = new Padding(0);
            OctaBtn.Name = "OctaBtn";
            OctaBtn.Size = new Size(174, 138);
            OctaBtn.TabIndex = 1;
            OctaBtn.Text = "Oct";
            OctaBtn.UseVisualStyleBackColor = false;
            OctaBtn.Click += HandleOcta;
            // 
            // PercentangeBtn
            // 
            PercentangeBtn.BackColor = Color.FromArgb(40, 40, 40);
            PercentangeBtn.FlatAppearance.BorderColor = Color.Gray;
            PercentangeBtn.FlatStyle = FlatStyle.Flat;
            PercentangeBtn.Font = new Font("Arial", 14.1F);
            PercentangeBtn.ForeColor = Color.White;
            PercentangeBtn.Location = new Point(34, 402);
            PercentangeBtn.Margin = new Padding(0);
            PercentangeBtn.Name = "PercentangeBtn";
            PercentangeBtn.Size = new Size(174, 138);
            PercentangeBtn.TabIndex = 1;
            PercentangeBtn.Text = "%";
            PercentangeBtn.UseVisualStyleBackColor = false;
            PercentangeBtn.Click += HandlePercentage;
            // 
            // Log_button
            // 
            Log_button.BackColor = Color.FromArgb(40, 40, 40);
            Log_button.FlatAppearance.BorderColor = Color.Gray;
            Log_button.FlatStyle = FlatStyle.Flat;
            Log_button.Font = new Font("Arial", 14.1F);
            Log_button.ForeColor = Color.White;
            Log_button.Location = new Point(1428, 722);
            Log_button.Margin = new Padding(0);
            Log_button.Name = "Log_button";
            Log_button.Size = new Size(174, 138);
            Log_button.TabIndex = 1;
            Log_button.Text = "LOG";
            Log_button.UseVisualStyleBackColor = false;
            Log_button.Click += handleLog;
            // 
            // MaximizeButton
            // 
            MaximizeButton.BackColor = Color.FromArgb(42, 42, 42);
            MaximizeButton.FlatAppearance.BorderSize = 0;
            MaximizeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            MaximizeButton.FlatStyle = FlatStyle.Flat;
            MaximizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MaximizeButton.ForeColor = SystemColors.Window;
            MaximizeButton.Location = new Point(1379, 28);
            MaximizeButton.Margin = new Padding(0);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(116, 58);
            MaximizeButton.TabIndex = 3;
            MaximizeButton.Text = "🗖";
            MaximizeButton.UseVisualStyleBackColor = false;
            MaximizeButton.Click += MaximizeButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(42, 42, 42);
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MinimizeButton.ForeColor = SystemColors.Window;
            MinimizeButton.Location = new Point(1263, 28);
            MinimizeButton.Margin = new Padding(0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(116, 58);
            MinimizeButton.TabIndex = 3;
            MinimizeButton.Text = "🗕";
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 42, 42);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(MaximizeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1643, 102);
            panel1.TabIndex = 4;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(42, 42, 42);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ExitBtn.ForeColor = SystemColors.Window;
            ExitBtn.Location = new Point(1486, 28);
            ExitBtn.Margin = new Padding(0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(116, 58);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += exitToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 33, 33);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(Historybutton);
            panel2.Controls.Add(LightAndDarkbtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1643, 108);
            panel2.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuTitle });
            menuStrip1.Location = new Point(34, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(91, 62);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuTitle
            // 
            MenuTitle.BackColor = Color.Transparent;
            MenuTitle.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, exitToolStripMenuItem });
            MenuTitle.Font = new Font("Segoe UI", 12F);
            MenuTitle.ForeColor = Color.White;
            MenuTitle.Name = "MenuTitle";
            MenuTitle.Size = new Size(83, 58);
            MenuTitle.Text = "☰";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.BackColor = Color.FromArgb(33, 33, 33);
            standardToolStripMenuItem.Font = new Font("Segoe UI", 8F);
            standardToolStripMenuItem.ForeColor = Color.White;
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(294, 54);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.BackColor = Color.FromArgb(33, 33, 33);
            scientificToolStripMenuItem.Font = new Font("Segoe UI", 8F);
            scientificToolStripMenuItem.ForeColor = Color.White;
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(294, 54);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(33, 33, 33);
            exitToolStripMenuItem.Font = new Font("Segoe UI", 8F);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(294, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Historybutton
            // 
            Historybutton.BackgroundImage = (Image)resources.GetObject("Historybutton.BackgroundImage");
            Historybutton.BackgroundImageLayout = ImageLayout.Stretch;
            Historybutton.FlatAppearance.BorderSize = 0;
            Historybutton.FlatStyle = FlatStyle.Flat;
            Historybutton.Font = new Font("Arial", 14.1F);
            Historybutton.ForeColor = Color.White;
            Historybutton.Location = new Point(1516, 23);
            Historybutton.Name = "Historybutton";
            Historybutton.Size = new Size(66, 62);
            Historybutton.TabIndex = 1;
            Historybutton.UseVisualStyleBackColor = false;
            Historybutton.Click += HandleHistory;
            // 
            // LightAndDarkbtn
            // 
            LightAndDarkbtn.BackgroundImage = (Image)resources.GetObject("LightAndDarkbtn.BackgroundImage");
            LightAndDarkbtn.BackgroundImageLayout = ImageLayout.Stretch;
            LightAndDarkbtn.FlatAppearance.BorderSize = 0;
            LightAndDarkbtn.FlatStyle = FlatStyle.Flat;
            LightAndDarkbtn.Font = new Font("Arial", 14.1F);
            LightAndDarkbtn.ForeColor = Color.White;
            LightAndDarkbtn.Location = new Point(147, 32);
            LightAndDarkbtn.Name = "LightAndDarkbtn";
            LightAndDarkbtn.Size = new Size(48, 53);
            LightAndDarkbtn.TabIndex = 1;
            LightAndDarkbtn.UseVisualStyleBackColor = false;
            LightAndDarkbtn.Click += ChangeTheme;
            // 
            // FactorialBtn
            // 
            FactorialBtn.BackColor = Color.FromArgb(40, 40, 40);
            FactorialBtn.FlatAppearance.BorderColor = Color.Gray;
            FactorialBtn.FlatStyle = FlatStyle.Flat;
            FactorialBtn.Font = new Font("Arial", 14.1F);
            FactorialBtn.ForeColor = Color.White;
            FactorialBtn.Location = new Point(1030, 402);
            FactorialBtn.Margin = new Padding(0);
            FactorialBtn.Name = "FactorialBtn";
            FactorialBtn.Size = new Size(174, 138);
            FactorialBtn.TabIndex = 1;
            FactorialBtn.Text = "n!";
            FactorialBtn.UseVisualStyleBackColor = false;
            FactorialBtn.Click += FactBtn;
            // 
            // powxy
            // 
            powxy.BackColor = Color.FromArgb(40, 40, 40);
            powxy.FlatAppearance.BorderColor = Color.Gray;
            powxy.FlatStyle = FlatStyle.Flat;
            powxy.Font = new Font("Arial", 14.1F);
            powxy.ForeColor = Color.White;
            powxy.Location = new Point(1428, 404);
            powxy.Margin = new Padding(0);
            powxy.Name = "powxy";
            powxy.Size = new Size(174, 138);
            powxy.TabIndex = 1;
            powxy.Text = "^";
            powxy.UseVisualStyleBackColor = false;
            powxy.Click += HandleOperations;
            // 
            // MPlusButton
            // 
            MPlusButton.BackColor = Color.FromArgb(60, 60, 60);
            MPlusButton.FlatAppearance.BorderColor = Color.Gray;
            MPlusButton.FlatStyle = FlatStyle.Flat;
            MPlusButton.Font = new Font("Arial", 14.1F);
            MPlusButton.ForeColor = Color.White;
            MPlusButton.Location = new Point(1230, 885);
            MPlusButton.Margin = new Padding(0);
            MPlusButton.Name = "MPlusButton";
            MPlusButton.Size = new Size(174, 206);
            MPlusButton.TabIndex = 1;
            MPlusButton.Text = "M+";
            MPlusButton.UseVisualStyleBackColor = false;
            MPlusButton.Click += HandleMPlusButton;
            // 
            // MMinusButton
            // 
            MMinusButton.BackColor = Color.FromArgb(60, 60, 60);
            MMinusButton.FlatAppearance.BorderColor = Color.Gray;
            MMinusButton.FlatStyle = FlatStyle.Flat;
            MMinusButton.Font = new Font("Arial", 14.1F);
            MMinusButton.ForeColor = Color.White;
            MMinusButton.Location = new Point(1428, 883);
            MMinusButton.Margin = new Padding(0);
            MMinusButton.Name = "MMinusButton";
            MMinusButton.Size = new Size(174, 206);
            MMinusButton.TabIndex = 1;
            MMinusButton.Text = "M-";
            MMinusButton.UseVisualStyleBackColor = false;
            MMinusButton.Click += HandleMMinusButton;
            // 
            // MRButton
            // 
            MRButton.BackColor = Color.FromArgb(60, 60, 60);
            MRButton.FlatAppearance.BorderColor = Color.Gray;
            MRButton.FlatStyle = FlatStyle.Flat;
            MRButton.Font = new Font("Arial", 14.1F);
            MRButton.ForeColor = Color.White;
            MRButton.Location = new Point(1230, 1123);
            MRButton.Margin = new Padding(0);
            MRButton.Name = "MRButton";
            MRButton.Size = new Size(174, 222);
            MRButton.TabIndex = 1;
            MRButton.Text = "MR";
            MRButton.UseVisualStyleBackColor = false;
            MRButton.Click += HandleMRButton;
            // 
            // MCButton
            // 
            MCButton.BackColor = Color.FromArgb(60, 60, 60);
            MCButton.FlatAppearance.BorderColor = Color.Gray;
            MCButton.FlatStyle = FlatStyle.Flat;
            MCButton.Font = new Font("Arial", 14.1F);
            MCButton.ForeColor = Color.White;
            MCButton.Location = new Point(1428, 1123);
            MCButton.Margin = new Padding(0);
            MCButton.Name = "MCButton";
            MCButton.Size = new Size(174, 222);
            MCButton.TabIndex = 1;
            MCButton.Text = "MC";
            MCButton.UseVisualStyleBackColor = false;
            MCButton.Click += HandleMCButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1643, 1385);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btndivide);
            Controls.Add(btnequals);
            Controls.Add(btnmultpily);
            Controls.Add(btn3);
            Controls.Add(btnplus);
            Controls.Add(btnsub);
            Controls.Add(btndot);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(PercentangeBtn);
            Controls.Add(OctaBtn);
            Controls.Add(lnXbtn);
            Controls.Add(MCButton);
            Controls.Add(MMinusButton);
            Controls.Add(MRButton);
            Controls.Add(MPlusButton);
            Controls.Add(HexaBtn);
            Controls.Add(CubeBtn);
            Controls.Add(divbyxBtn);
            Controls.Add(ModBtn);
            Controls.Add(DecBtn);
            Controls.Add(TanBtn);
            Controls.Add(SquareBtn);
            Controls.Add(BinBtn);
            Controls.Add(ExponentBtn);
            Controls.Add(Sinbtn);
            Controls.Add(Tanhbtn);
            Controls.Add(Sqrtbtn);
            Controls.Add(CosBtn);
            Controls.Add(Sinhbtn);
            Controls.Add(CoshBtn);
            Controls.Add(Log_button);
            Controls.Add(Pi_Button);
            Controls.Add(PMSButton);
            Controls.Add(btnC);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btnCE);
            Controls.Add(powxy);
            Controls.Add(FactorialBtn);
            Controls.Add(backBtn);
            Controls.Add(txtResult);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button backBtn;
        private Button btnCE;
        private Button btnC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnplus;
        private Button btn4;
        private Button btn5;
        private Button btn1;
        private Button btn6;
        private Button btn2;
        private Button btnsub;
        private Button btn3;
        private Button btnmultpily;
        private Button btn0;
        private Button btndot;
        private Button btnequals;
        private Button btndivide;
        private Button PMSButton;
        private Button Pi_Button;
        private Button Sqrtbtn;
        private Button SquareBtn;
        private Button Sinhbtn;
        private Button Sinbtn;
        private Button DecBtn;
        private Button CubeBtn;
        private Button CoshBtn;
        private Button CosBtn;
        private Button Tanhbtn;
        private Button BinBtn;
        private Button TanBtn;
        private Button divbyxBtn;
        private Button HexaBtn;
        private Button lnXbtn;
        private Button ExponentBtn;
        private Button ModBtn;
        private Button OctaBtn;
        private Button PercentangeBtn;
        private Button Log_button;
        private Button MaximizeButton;
        private Button MinimizeButton;
        private Panel panel1;
        private Panel panel2;
        private Button ExitBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuTitle;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button FactorialBtn;
        private Button powxy;
        private Button MPlusButton;
        private Button MMinusButton;
        private Button MRButton;
        private Button MCButton;
        private Button LightAndDarkbtn;
        private Button Historybutton;
    }
}
