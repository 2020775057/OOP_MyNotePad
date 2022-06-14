namespace MyNotePad
{
    partial class Form2
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
            this.TextFind = new System.Windows.Forms.TextBox();
            this.uplow = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdown = new System.Windows.Forms.RadioButton();
            this.rup = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을내용(&N): ";
            // 
            // TextFind
            // 
            this.TextFind.Location = new System.Drawing.Point(102, 22);
            this.TextFind.Name = "TextFind";
            this.TextFind.Size = new System.Drawing.Size(220, 21);
            this.TextFind.TabIndex = 1;
            this.TextFind.TextChanged += new System.EventHandler(this.Find_TextChanged);
            // 
            // uplow
            // 
            this.uplow.AutoSize = true;
            this.uplow.Location = new System.Drawing.Point(8, 81);
            this.uplow.Name = "uplow";
            this.uplow.Size = new System.Drawing.Size(125, 16);
            this.uplow.TabIndex = 2;
            this.uplow.Text = "대/소문자 구분(&C)";
            this.uplow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdown);
            this.groupBox1.Controls.Add(this.rup);
            this.groupBox1.Location = new System.Drawing.Point(139, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // rdown
            // 
            this.rdown.AutoSize = true;
            this.rdown.Location = new System.Drawing.Point(102, 23);
            this.rdown.Name = "rdown";
            this.rdown.Size = new System.Drawing.Size(77, 16);
            this.rdown.TabIndex = 1;
            this.rdown.TabStop = true;
            this.rdown.Text = "아래로(&D)";
            this.rdown.UseVisualStyleBackColor = true;
            // 
            // rup
            // 
            this.rup.AutoSize = true;
            this.rup.Location = new System.Drawing.Point(21, 24);
            this.rup.Name = "rup";
            this.rup.Size = new System.Drawing.Size(65, 16);
            this.rup.TabIndex = 0;
            this.rup.TabStop = true;
            this.rup.Text = "위로(&U)";
            this.rup.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(347, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "다음 찾기(&F)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.bfind_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanel.Location = new System.Drawing.Point(347, 51);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(85, 23);
            this.btnCanel.TabIndex = 4;
            this.btnCanel.Text = "취소";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 131);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uplow);
            this.Controls.Add(this.TextFind);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "찾기";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextFind;
        private System.Windows.Forms.CheckBox uplow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdown;
        private System.Windows.Forms.RadioButton rup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCanel;
    }
}