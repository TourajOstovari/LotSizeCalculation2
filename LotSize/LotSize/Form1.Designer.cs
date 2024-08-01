namespace LotSize
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
            button1 = new Button();
            label1 = new Label();
            n_equity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ICS_FIXRISK = new NumericUpDown();
            label4 = new Label();
            Pipamount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ICS_FLOATRISK = new TextBox();
            label8 = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ICS_FIXRISK).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 0;
            button1.Text = "Calculate...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Money Amount:";
            // 
            // n_equity
            // 
            n_equity.Location = new Point(12, 37);
            n_equity.Name = "n_equity";
            n_equity.Size = new Size(238, 23);
            n_equity.TabIndex = 2;
            n_equity.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Float Risk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Fix Risk:";
            // 
            // ICS_FIXRISK
            // 
            ICS_FIXRISK.Location = new Point(12, 148);
            ICS_FIXRISK.Name = "ICS_FIXRISK";
            ICS_FIXRISK.Size = new Size(238, 23);
            ICS_FIXRISK.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 7;
            label4.Text = "Pip Amount:";
            // 
            // Pipamount
            // 
            Pipamount.Location = new Point(12, 202);
            Pipamount.Name = "Pipamount";
            Pipamount.Size = new Size(183, 23);
            Pipamount.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(12, 297);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Lot:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(26, 329);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(2, 372);
            label7.Name = "label7";
            label7.Size = new Size(333, 69);
            label7.TabIndex = 11;
            label7.Text = "Math Formulation designed and developed by Mr. Touraj Ostovari";
            // 
            // ICS_FLOATRISK
            // 
            ICS_FLOATRISK.Location = new Point(12, 96);
            ICS_FLOATRISK.Name = "ICS_FLOATRISK";
            ICS_FLOATRISK.Size = new Size(238, 23);
            ICS_FLOATRISK.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 246);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 13;
            label8.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 264);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(138, 23);
            txtPrice.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 450);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(ICS_FLOATRISK);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Pipamount);
            Controls.Add(label4);
            Controls.Add(ICS_FIXRISK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(n_equity);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Lot Size";
            ((System.ComponentModel.ISupportInitialize)ICS_FIXRISK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox n_equity;
        private Label label2;
        private Label label3;
        private NumericUpDown ICS_FIXRISK;
        private Label label4;
        private TextBox Pipamount;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ICS_FLOATRISK;
        private Label label8;
        private TextBox txtPrice;
    }
}
