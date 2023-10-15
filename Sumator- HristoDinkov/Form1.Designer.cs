namespace Sumator__HristoDinkov
{
    partial class FormCalculate
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
            number1 = new System.Windows.Forms.TextBox();
            number2 = new System.Windows.Forms.TextBox();
            Sum = new System.Windows.Forms.TextBox();
            plus = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SumButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // number1
            // 
            number1.Location = new System.Drawing.Point(28, 43);
            number1.Name = "number1";
            number1.Size = new System.Drawing.Size(126, 23);
            number1.TabIndex = 0;
            // 
            // number2
            // 
            number2.Location = new System.Drawing.Point(202, 43);
            number2.Name = "number2";
            number2.Size = new System.Drawing.Size(126, 23);
            number2.TabIndex = 1;
            // 
            // Sum
            // 
            Sum.Location = new System.Drawing.Point(393, 43);
            Sum.Name = "Sum";
            Sum.Size = new System.Drawing.Size(126, 23);
            Sum.TabIndex = 2;
            // 
            // plus
            // 
            plus.AutoSize = true;
            plus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            plus.Location = new System.Drawing.Point(166, 34);
            plus.Name = "plus";
            plus.Size = new System.Drawing.Size(30, 32);
            plus.TabIndex = 3;
            plus.Text = "+";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(347, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 32);
            label1.TabIndex = 4;
            label1.Text = "=";
            // 
            // SumButton
            // 
            SumButton.BackColor = System.Drawing.Color.LightSteelBlue;
            SumButton.Location = new System.Drawing.Point(182, 101);
            SumButton.Name = "SumButton";
            SumButton.Size = new System.Drawing.Size(185, 45);
            SumButton.TabIndex = 5;
            SumButton.Text = "Calculate";
            SumButton.UseVisualStyleBackColor = false;
            SumButton.Click += SumButton_Click;
            // 
            // FormCalculate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightCyan;
            ClientSize = new System.Drawing.Size(554, 203);
            Controls.Add(SumButton);
            Controls.Add(label1);
            Controls.Add(plus);
            Controls.Add(Sum);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "FormCalculate";
            Text = "Sumator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SumButton;
    }
}
