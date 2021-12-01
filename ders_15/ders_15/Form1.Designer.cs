
namespace ders_15
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
            this.RBA = new System.Windows.Forms.RadioButton();
            this.RBB = new System.Windows.Forms.RadioButton();
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBA
            // 
            this.RBA.AutoSize = true;
            this.RBA.Location = new System.Drawing.Point(6, 34);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(38, 21);
            this.RBA.TabIndex = 0;
            this.RBA.TabStop = true;
            this.RBA.Text = "A";
            this.RBA.UseVisualStyleBackColor = true;
            this.RBA.CheckedChanged += new System.EventHandler(this.RBA_CheckedChanged);
            // 
            // RBB
            // 
            this.RBB.AutoSize = true;
            this.RBB.Location = new System.Drawing.Point(6, 58);
            this.RBB.Name = "RBB";
            this.RBB.Size = new System.Drawing.Size(38, 21);
            this.RBB.TabIndex = 1;
            this.RBB.TabStop = true;
            this.RBB.Text = "B";
            this.RBB.UseVisualStyleBackColor = true;
            // 
            // RBC
            // 
            this.RBC.AutoSize = true;
            this.RBC.Location = new System.Drawing.Point(6, 85);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(38, 21);
            this.RBC.TabIndex = 2;
            this.RBC.TabStop = true;
            this.RBC.Text = "C";
            this.RBC.UseVisualStyleBackColor = true;
            // 
            // RBD
            // 
            this.RBD.AutoSize = true;
            this.RBD.Location = new System.Drawing.Point(6, 112);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(39, 21);
            this.RBD.TabIndex = 3;
            this.RBD.TabStop = true;
            this.RBD.Text = "D";
            this.RBD.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(162, 224);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(134, 74);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Cevabı Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBA);
            this.groupBox1.Controls.Add(this.RBB);
            this.groupBox1.Controls.Add(this.RBD);
            this.groupBox1.Controls.Add(this.RBC);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RBA;
        private System.Windows.Forms.RadioButton RBB;
        private System.Windows.Forms.RadioButton RBC;
        private System.Windows.Forms.RadioButton RBD;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

