
namespace ders_16_login_project
{
    partial class FrmForgotPassword
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenewPassword = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(55, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gizli Soru:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(201, 99);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(190, 22);
            this.txtAnswer.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cevap:";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(177, 95);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(190, 22);
            this.txtRepassword.TabIndex = 21;
            this.txtRepassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yeni Şifre:";
            // 
            // btnRenewPassword
            // 
            this.btnRenewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenewPassword.Location = new System.Drawing.Point(130, 153);
            this.btnRenewPassword.Name = "btnRenewPassword";
            this.btnRenewPassword.Size = new System.Drawing.Size(160, 49);
            this.btnRenewPassword.TabIndex = 22;
            this.btnRenewPassword.Text = "Şifreyi Yenile";
            this.btnRenewPassword.UseVisualStyleBackColor = true;
            this.btnRenewPassword.Click += new System.EventHandler(this.btnRenewPassword_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.txtPassword);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.txtRepassword);
            this.grpBox.Controls.Add(this.btnRenewPassword);
            this.grpBox.Location = new System.Drawing.Point(33, 236);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(402, 235);
            this.grpBox.TabIndex = 25;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Şifre Yenile";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(161, 163);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(160, 47);
            this.btnCheckAnswer.TabIndex = 26;
            this.btnCheckAnswer.Text = "Kontrol Et";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion.Location = new System.Drawing.Point(205, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 27;
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 541);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label4);
            this.Name = "FrmForgotPassword";
            this.ShowIcon = false;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.FrmForgotPassword_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenewPassword;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblQuestion;
    }
}