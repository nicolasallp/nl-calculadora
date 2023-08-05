using System.Drawing;

namespace BS_Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btn_Igual = new System.Windows.Forms.Button();
            this.btn_Dot = new System.Windows.Forms.Button();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_CleanE = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.txt_Calculo = new System.Windows.Forms.TextBox();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Igual
            // 
            this.btn_Igual.BackColor = System.Drawing.Color.Navy;
            this.btn_Igual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Igual.FlatAppearance.BorderSize = 0;
            this.btn_Igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Igual.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Igual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Igual.Location = new System.Drawing.Point(242, 477);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(70, 70);
            this.btn_Igual.TabIndex = 20;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // btn_Dot
            // 
            this.btn_Dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_Dot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Dot.FlatAppearance.BorderSize = 0;
            this.btn_Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dot.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_Dot.Location = new System.Drawing.Point(166, 477);
            this.btn_Dot.Name = "btn_Dot";
            this.btn_Dot.Size = new System.Drawing.Size(70, 70);
            this.btn_Dot.TabIndex = 21;
            this.btn_Dot.Text = ".";
            this.btn_Dot.UseVisualStyleBackColor = true;
            this.btn_Dot.Click += new System.EventHandler(this.btn_Dot_Click);
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_Convert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Convert.FlatAppearance.BorderSize = 0;
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_Convert.Location = new System.Drawing.Point(13, 477);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(70, 70);
            this.btn_Convert.TabIndex = 22;
            this.btn_Convert.Text = "+/-";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_CleanE
            // 
            this.btn_CleanE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_CleanE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CleanE.FlatAppearance.BorderSize = 0;
            this.btn_CleanE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanE.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CleanE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_CleanE.Location = new System.Drawing.Point(90, 173);
            this.btn_CleanE.Name = "btn_CleanE";
            this.btn_CleanE.Size = new System.Drawing.Size(70, 70);
            this.btn_CleanE.TabIndex = 24;
            this.btn_CleanE.Text = "CE";
            this.btn_CleanE.UseVisualStyleBackColor = true;
            this.btn_CleanE.Click += new System.EventHandler(this.btn_CleanE_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_Clean.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Clean.FlatAppearance.BorderSize = 0;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clean.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_Clean.Location = new System.Drawing.Point(166, 173);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(70, 70);
            this.btn_Clean.TabIndex = 26;
            this.btn_Clean.Text = "C";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // txt_Calculo
            // 
            this.txt_Calculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.txt_Calculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Calculo.Enabled = false;
            this.txt_Calculo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Calculo.ForeColor = System.Drawing.Color.White;
            this.txt_Calculo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Calculo.Location = new System.Drawing.Point(18, 21);
            this.txt_Calculo.Name = "txt_Calculo";
            this.txt_Calculo.ReadOnly = true;
            this.txt_Calculo.Size = new System.Drawing.Size(294, 25);
            this.txt_Calculo.TabIndex = 27;
            this.txt_Calculo.TabStop = false;
            this.txt_Calculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Backspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Backspace.FlatAppearance.BorderSize = 0;
            this.btn_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backspace.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Backspace.Location = new System.Drawing.Point(242, 132);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Backspace.Size = new System.Drawing.Size(70, 35);
            this.btn_Backspace.TabIndex = 28;
            this.btn_Backspace.Text = "←";
            this.btn_Backspace.UseVisualStyleBackColor = true;
            this.btn_Backspace.Click += new System.EventHandler(this.btn_Backspace_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_Square.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Square.FlatAppearance.BorderSize = 0;
            this.btn_Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Square.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Square.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_Square.Location = new System.Drawing.Point(13, 173);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(70, 70);
            this.btn_Square.TabIndex = 25;
            this.btn_Square.Text = "x²";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_0.Location = new System.Drawing.Point(90, 477);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(70, 70);
            this.btn_0.TabIndex = 19;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_1.Location = new System.Drawing.Point(13, 401);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(70, 70);
            this.btn_1.TabIndex = 10;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_9.Location = new System.Drawing.Point(166, 249);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(70, 70);
            this.btn_9.TabIndex = 11;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_8.Location = new System.Drawing.Point(89, 249);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(70, 70);
            this.btn_8.TabIndex = 12;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_6.Location = new System.Drawing.Point(166, 325);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(70, 70);
            this.btn_6.TabIndex = 14;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_5.Location = new System.Drawing.Point(90, 325);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(70, 70);
            this.btn_5.TabIndex = 15;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_4.Location = new System.Drawing.Point(14, 325);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(70, 70);
            this.btn_4.TabIndex = 16;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_3.Location = new System.Drawing.Point(166, 401);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(70, 70);
            this.btn_3.TabIndex = 17;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_2.Location = new System.Drawing.Point(90, 401);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(70, 70);
            this.btn_2.TabIndex = 18;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(253)))));
            this.btn_7.Location = new System.Drawing.Point(14, 249);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(70, 70);
            this.btn_7.TabIndex = 13;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_Divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Divide.FlatAppearance.BorderSize = 0;
            this.btn_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Divide.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Divide.Location = new System.Drawing.Point(242, 173);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(70, 70);
            this.btn_Divide.TabIndex = 29;
            this.btn_Divide.Text = "÷";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_Multiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Multiply.FlatAppearance.BorderSize = 0;
            this.btn_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Multiply.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Multiply.Location = new System.Drawing.Point(242, 249);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(70, 70);
            this.btn_Multiply.TabIndex = 30;
            this.btn_Multiply.Text = "x";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_Sum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sum.FlatAppearance.BorderSize = 0;
            this.btn_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sum.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Sum.Location = new System.Drawing.Point(242, 401);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(70, 70);
            this.btn_Sum.TabIndex = 31;
            this.btn_Sum.Text = "+";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_Subtract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Subtract.FlatAppearance.BorderSize = 0;
            this.btn_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Subtract.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Subtract.Location = new System.Drawing.Point(242, 325);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(70, 70);
            this.btn_Subtract.TabIndex = 32;
            this.btn_Subtract.Text = "-";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            this.btn_Subtract.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.txt_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Resultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Resultado.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.Color.White;
            this.txt_Resultado.Location = new System.Drawing.Point(0, 3);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Resultado.Size = new System.Drawing.Size(294, 57);
            this.txt_Resultado.TabIndex = 23;
            this.txt_Resultado.TabStop = false;
            this.txt_Resultado.Text = "0";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Resultado.WordWrap = false;
            this.txt_Resultado.TextChanged += new System.EventHandler(this.txt_Resultado_TextChanged);
            this.txt_Resultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Resultado_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Resultado);
            this.panel1.Location = new System.Drawing.Point(17, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 60);
            this.panel1.TabIndex = 33;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(324, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Backspace);
            this.Controls.Add(this.txt_Calculo);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.btn_CleanE);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_Dot);
            this.Controls.Add(this.btn_Igual);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Button btn_Dot;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_CleanE;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.TextBox txt_Calculo;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Panel panel1;
    }
}

