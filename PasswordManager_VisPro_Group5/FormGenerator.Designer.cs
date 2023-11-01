namespace PasswordManager_VisPro_Group5
{
    partial class FormGenerator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.generatedPassword = new System.Windows.Forms.Label();
            this.generatePassword = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copyPassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.isIncludeNumbers = new System.Windows.Forms.CheckBox();
            this.isIncludeCapital = new System.Windows.Forms.CheckBox();
            this.isIncludeSymbols = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // length
            // 
            this.length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(61)))));
            this.length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.length.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length.Location = new System.Drawing.Point(184, 71);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(58, 25);
            this.length.TabIndex = 5;
            this.length.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.length.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // generatedPassword
            // 
            this.generatedPassword.AutoSize = true;
            this.generatedPassword.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPassword.ForeColor = System.Drawing.Color.White;
            this.generatedPassword.Location = new System.Drawing.Point(171, 19);
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.Size = new System.Drawing.Size(0, 25);
            this.generatedPassword.TabIndex = 7;
            // 
            // generatePassword
            // 
            this.generatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(61)))));
            this.generatePassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassword.Location = new System.Drawing.Point(399, 19);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(74, 25);
            this.generatePassword.TabIndex = 8;
            this.generatePassword.Text = "Generate";
            this.generatePassword.UseVisualStyleBackColor = false;
            this.generatePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(61)))));
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.generatedPassword);
            this.groupBox1.Controls.Add(this.generatePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // copyPassword
            // 
            this.copyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.copyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(61)))));
            this.copyPassword.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPassword.Location = new System.Drawing.Point(276, 387);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(180, 35);
            this.copyPassword.TabIndex = 11;
            this.copyPassword.Text = "Copy password";
            this.copyPassword.UseVisualStyleBackColor = false;
            this.copyPassword.Visible = false;
            this.copyPassword.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // isIncludeNumbers
            // 
            this.isIncludeNumbers.AutoSize = true;
            this.isIncludeNumbers.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isIncludeNumbers.ForeColor = System.Drawing.Color.White;
            this.isIncludeNumbers.Location = new System.Drawing.Point(32, 118);
            this.isIncludeNumbers.Name = "isIncludeNumbers";
            this.isIncludeNumbers.Size = new System.Drawing.Size(113, 29);
            this.isIncludeNumbers.TabIndex = 13;
            this.isIncludeNumbers.Text = "Numbers";
            this.isIncludeNumbers.UseVisualStyleBackColor = true;
            this.isIncludeNumbers.CheckedChanged += new System.EventHandler(this.isIncludeNumbers_CheckedChanged);
            // 
            // isIncludeCapital
            // 
            this.isIncludeCapital.AutoSize = true;
            this.isIncludeCapital.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isIncludeCapital.ForeColor = System.Drawing.Color.White;
            this.isIncludeCapital.Location = new System.Drawing.Point(32, 177);
            this.isIncludeCapital.Name = "isIncludeCapital";
            this.isIncludeCapital.Size = new System.Drawing.Size(152, 29);
            this.isIncludeCapital.TabIndex = 14;
            this.isIncludeCapital.Text = "Capital letters";
            this.isIncludeCapital.UseVisualStyleBackColor = true;
            this.isIncludeCapital.CheckedChanged += new System.EventHandler(this.isIncludeCapital_CheckedChanged);
            // 
            // isIncludeSymbols
            // 
            this.isIncludeSymbols.AutoSize = true;
            this.isIncludeSymbols.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isIncludeSymbols.ForeColor = System.Drawing.Color.White;
            this.isIncludeSymbols.Location = new System.Drawing.Point(32, 230);
            this.isIncludeSymbols.Name = "isIncludeSymbols";
            this.isIncludeSymbols.Size = new System.Drawing.Size(106, 29);
            this.isIncludeSymbols.TabIndex = 15;
            this.isIncludeSymbols.Text = "Symbols";
            this.isIncludeSymbols.UseVisualStyleBackColor = true;
            this.isIncludeSymbols.CheckedChanged += new System.EventHandler(this.isIncludeSymbols_CheckedChanged);
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(536, 465);
            this.ControlBox = false;
            this.Controls.Add(this.isIncludeSymbols);
            this.Controls.Add(this.isIncludeCapital);
            this.Controls.Add(this.isIncludeNumbers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.copyPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.FormGenerator_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGenerator_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label generatedPassword;
        private System.Windows.Forms.Button generatePassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button copyPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox isIncludeNumbers;
        private System.Windows.Forms.CheckBox isIncludeCapital;
        private System.Windows.Forms.CheckBox isIncludeSymbols;
    }
}