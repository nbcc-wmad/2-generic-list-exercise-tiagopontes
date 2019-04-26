namespace GenericListExercise
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
            this.lblScore = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(48, 86);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(113, 160);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(128, 35);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "&Find Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(161, 86);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(150, 30);
            this.txtScore.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 267);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox txtScore;
    }
}

