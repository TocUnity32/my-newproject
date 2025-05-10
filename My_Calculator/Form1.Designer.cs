namespace My_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnKhon = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnHan = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.btnHan);
            this.panel1.Controls.Add(this.btnEqu);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnKhon);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnPM);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnce);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 584);
            this.panel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisplay.Location = new System.Drawing.Point(53, 110);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(326, 56);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Orange;
            this.btnback.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.ForeColor = System.Drawing.Color.IndianRed;
            this.btnback.Location = new System.Drawing.Point(53, 172);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(77, 76);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "☒";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.Gold;
            this.btnce.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnce.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnce.Location = new System.Drawing.Point(136, 172);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(77, 76);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Pink;
            this.btnC.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnC.Location = new System.Drawing.Point(219, 172);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(77, 76);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPM.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPM.Location = new System.Drawing.Point(302, 172);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(77, 76);
            this.btnPM.TabIndex = 4;
            this.btnPM.Text = "± ";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(302, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 76);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.Location = new System.Drawing.Point(219, 254);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 76);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.Location = new System.Drawing.Point(136, 254);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 76);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.Location = new System.Drawing.Point(53, 254);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(77, 76);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSub.Location = new System.Drawing.Point(302, 336);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(77, 76);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.Location = new System.Drawing.Point(219, 336);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 76);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.Location = new System.Drawing.Point(136, 336);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 76);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(53, 336);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 76);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnKhon
            // 
            this.btnKhon.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKhon.Location = new System.Drawing.Point(302, 418);
            this.btnKhon.Name = "btnKhon";
            this.btnKhon.Size = new System.Drawing.Size(77, 76);
            this.btnKhon.TabIndex = 16;
            this.btnKhon.Text = "*";
            this.btnKhon.UseVisualStyleBackColor = true;
            this.btnKhon.Click += new System.EventHandler(this.btnKhon_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(219, 418);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 76);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(136, 418);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 76);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(53, 418);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 76);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnHan
            // 
            this.btnHan.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHan.Location = new System.Drawing.Point(302, 500);
            this.btnHan.Name = "btnHan";
            this.btnHan.Size = new System.Drawing.Size(77, 76);
            this.btnHan.TabIndex = 20;
            this.btnHan.Text = "/";
            this.btnHan.UseVisualStyleBackColor = true;
            this.btnHan.Click += new System.EventHandler(this.btnHan_Click);
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqu.Location = new System.Drawing.Point(219, 500);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(77, 76);
            this.btnEqu.TabIndex = 19;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpoint.Location = new System.Drawing.Point(136, 500);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(77, 76);
            this.btnpoint.TabIndex = 18;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(53, 500);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 76);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn.Location = new System.Drawing.Point(53, 22);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(326, 67);
            this.btn.TabIndex = 21;
            this.btn.Text = "Calculator";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 602);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnHan;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKhon;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btn;
    }
}

