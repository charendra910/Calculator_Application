namespace Calculator_Application
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnMulti = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(31, 22);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(508, 84);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(36, 144);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 48);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(138, 144);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 48);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(237, 144);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 48);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(343, 144);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 48);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(443, 144);
            btn5.Name = "btn5";
            btn5.Size = new Size(84, 48);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(343, 225);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 48);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(445, 225);
            btn0.Name = "btn0";
            btn0.Size = new Size(82, 48);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(237, 225);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 48);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(131, 225);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 48);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(36, 225);
            btn6.Name = "btn6";
            btn6.Size = new Size(86, 48);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(343, 303);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(84, 48);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(445, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 48);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.Location = new Point(237, 303);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(80, 48);
            btnMulti.TabIndex = 13;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(138, 303);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(82, 48);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(36, 303);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(86, 48);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(31, 388);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(496, 57);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 477);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btnMulti);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn9;
        private Button btn0;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnDiv;
        private Button btnClear;
        private Button btnMulti;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnEqual;
    }
}