
namespace CalculateLetterGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberGrade = new System.Windows.Forms.TextBox();
            this.LetterGrade = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Number grade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter Grade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberGrade
            // 
            this.NumberGrade.Location = new System.Drawing.Point(334, 86);
            this.NumberGrade.Name = "NumberGrade";
            this.NumberGrade.Size = new System.Drawing.Size(119, 20);
            this.NumberGrade.TabIndex = 1;
            this.NumberGrade.TextChanged += new System.EventHandler(this.NumberGrade_TextChanged);
            // 
            // LetterGrade
            // 
            this.LetterGrade.Location = new System.Drawing.Point(334, 150);
            this.LetterGrade.Name = "LetterGrade";
            this.LetterGrade.ReadOnly = true;
            this.LetterGrade.Size = new System.Drawing.Size(118, 20);
            this.LetterGrade.TabIndex = 3;
            this.LetterGrade.TabStop = false;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(138, 226);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(128, 48);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "&Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(312, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(141, 48);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.LetterGrade);
            this.Controls.Add(this.NumberGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberGrade;
        private System.Windows.Forms.TextBox LetterGrade;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Exit;
    }
}

