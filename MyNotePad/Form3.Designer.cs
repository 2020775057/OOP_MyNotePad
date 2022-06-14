namespace MyNotePad
{
    partial class Form3
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
            this.lbl_line = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.TextBox();
            this.btnMv = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Location = new System.Drawing.Point(12, 22);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(62, 12);
            this.lbl_line.TabIndex = 3;
            this.lbl_line.Text = "줄 번호(&L)";
            // 
            // lineNum
            // 
            this.lineNum.Location = new System.Drawing.Point(14, 45);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(242, 21);
            this.lineNum.TabIndex = 4;
            // 
            // btnMv
            // 
            this.btnMv.Location = new System.Drawing.Point(116, 88);
            this.btnMv.Name = "btnMv";
            this.btnMv.Size = new System.Drawing.Size(75, 23);
            this.btnMv.TabIndex = 5;
            this.btnMv.Text = "이동";
            this.btnMv.UseVisualStyleBackColor = true;
            this.btnMv.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMv);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.lbl_line);
            this.Name = "Form3";
            this.Text = "줄이동";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.TextBox lineNum;
        private System.Windows.Forms.Button btnMv;
        private System.Windows.Forms.Button btnCancel;
    }
}