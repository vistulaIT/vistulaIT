namespace KalkulatorMK
{
    partial class Kalkulator
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
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnParenthesesOne = new System.Windows.Forms.Button();
            this.btnParenthesesTwo = new System.Windows.Forms.Button();
            this.btnNWW = new System.Windows.Forms.Button();
            this.btnNWD = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperation
            // 
            this.txtOperation.Enabled = false;
            this.txtOperation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOperation.Location = new System.Drawing.Point(10, 10);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(440, 36);
            this.txtOperation.TabIndex = 3;
            this.txtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnC
            // 
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(10, 50);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(125, 50);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // btnCE
            // 
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCE.Location = new System.Drawing.Point(145, 50);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(125, 50);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // btnParenthesesOne
            // 
            this.btnParenthesesOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnParenthesesOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParenthesesOne.Location = new System.Drawing.Point(280, 50);
            this.btnParenthesesOne.Name = "btnParenthesesOne";
            this.btnParenthesesOne.Size = new System.Drawing.Size(80, 50);
            this.btnParenthesesOne.TabIndex = 6;
            this.btnParenthesesOne.Text = "(";
            this.btnParenthesesOne.UseVisualStyleBackColor = true;
            this.btnParenthesesOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnParenthesesTwo
            // 
            this.btnParenthesesTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnParenthesesTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParenthesesTwo.Location = new System.Drawing.Point(370, 50);
            this.btnParenthesesTwo.Name = "btnParenthesesTwo";
            this.btnParenthesesTwo.Size = new System.Drawing.Size(80, 50);
            this.btnParenthesesTwo.TabIndex = 7;
            this.btnParenthesesTwo.Text = ")";
            this.btnParenthesesTwo.UseVisualStyleBackColor = true;
            this.btnParenthesesTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNWW
            // 
            this.btnNWW.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNWW.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNWW.Location = new System.Drawing.Point(370, 110);
            this.btnNWW.Name = "btnNWW";
            this.btnNWW.Size = new System.Drawing.Size(80, 50);
            this.btnNWW.TabIndex = 9;
            this.btnNWW.Text = "NWW";
            this.btnNWW.UseVisualStyleBackColor = true;
            this.btnNWW.Click += new System.EventHandler(this.buttonNWW_Click);
            // 
            // btnNWD
            // 
            this.btnNWD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNWD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNWD.Location = new System.Drawing.Point(280, 110);
            this.btnNWD.Name = "btnNWD";
            this.btnNWD.Size = new System.Drawing.Size(80, 50);
            this.btnNWD.TabIndex = 8;
            this.btnNWD.Text = "NWD";
            this.btnNWD.UseVisualStyleBackColor = true;
            this.btnNWD.Click += new System.EventHandler(this.buttonNWD_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(370, 170);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 50);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(280, 170);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 50);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btnDeduct
            // 
            this.btnDeduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeduct.Location = new System.Drawing.Point(370, 230);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(80, 50);
            this.btnDeduct.TabIndex = 13;
            this.btnDeduct.Text = "-";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(280, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEight.Location = new System.Drawing.Point(100, 110);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 50);
            this.btnEight.TabIndex = 15;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.Location = new System.Drawing.Point(10, 110);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 50);
            this.btnSeven.TabIndex = 14;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNine.Location = new System.Drawing.Point(190, 110);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 50);
            this.btnNine.TabIndex = 16;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSix.Location = new System.Drawing.Point(190, 170);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 50);
            this.btnSix.TabIndex = 19;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFive.Location = new System.Drawing.Point(100, 170);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 50);
            this.btnFive.TabIndex = 18;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFour.Location = new System.Drawing.Point(10, 170);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 50);
            this.btnFour.TabIndex = 17;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThree.Location = new System.Drawing.Point(190, 230);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 50);
            this.btnThree.TabIndex = 22;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.Location = new System.Drawing.Point(100, 230);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 50);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(10, 230);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 50);
            this.btnOne.TabIndex = 20;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(10, 290);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(170, 50);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.Location = new System.Drawing.Point(190, 290);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(80, 50);
            this.btnPoint.TabIndex = 24;
            this.btnPoint.Text = ",";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(280, 290);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(170, 50);
            this.btnEqual.TabIndex = 25;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 356);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNWW);
            this.Controls.Add(this.btnNWD);
            this.Controls.Add(this.btnParenthesesTwo);
            this.Controls.Add(this.btnParenthesesOne);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtOperation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kalkulator";
            this.Text = "Project 3 - Kalkulator";
            this.Load += new System.EventHandler(this.Kalkulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtOperation;
        private Button btnC;
        private Button btnCE;
        private Button btnParenthesesOne;
        private Button btnParenthesesTwo;
        private Button btnNWW;
        private Button btnNWD;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnDeduct;
        private Button btnAdd;
        private Button btnEight;
        private Button btnSeven;
        private Button btnNine;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnZero;
        private Button btnPoint;
        private Button btnEqual;
    }
}
