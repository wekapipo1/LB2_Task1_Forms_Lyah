namespace LB2_Task1_Forms
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
            label1 = new Label();
            tbxA = new TextBox();
            tbxB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCalc = new Button();
            label4 = new Label();
            label5 = new Label();
            lblNSD = new Label();
            lblNSK = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 0;
            label1.Text = "Введіть натуральні числа:";
            // 
            // tbxA
            // 
            tbxA.Location = new Point(65, 69);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(104, 34);
            tbxA.TabIndex = 1;
            // 
            // tbxB
            // 
            tbxB.Location = new Point(65, 131);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(104, 34);
            tbxB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 3;
            label2.Text = "а = ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 134);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 4;
            label3.Text = "b = ";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(15, 203);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(172, 49);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Обчислити ";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 72);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 7;
            label4.Text = "НСД = ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 134);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 8;
            label5.Text = "НСК = ";
            // 
            // lblNSD
            // 
            lblNSD.AutoSize = true;
            lblNSD.Location = new Point(278, 73);
            lblNSD.Name = "lblNSD";
            lblNSD.Size = new Size(20, 28);
            lblNSD.TabIndex = 9;
            lblNSD.Text = "_";
            // 
            // lblNSK
            // 
            lblNSK.AutoSize = true;
            lblNSK.Location = new Point(278, 134);
            lblNSK.Name = "lblNSK";
            lblNSK.Size = new Size(20, 28);
            lblNSK.TabIndex = 10;
            lblNSK.Text = "_";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(206, 203);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(172, 49);
            btnExit.TabIndex = 11;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 281);
            Controls.Add(btnExit);
            Controls.Add(lblNSK);
            Controls.Add(lblNSD);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCalc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxB);
            Controls.Add(tbxA);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "НСД і НСК";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxA;
        private TextBox tbxB;
        private Label label2;
        private Label label3;
        private Button btnCalc;
        private Label label4;
        private Label label5;
        private Label lblNSD;
        private Label lblNSK;
        private Button btnExit;
    }
}