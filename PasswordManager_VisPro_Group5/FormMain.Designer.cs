namespace PasswordManager_VisPro_Group5
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabel_item = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_item)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabel_item
            // 
            this.tabel_item.AllowUserToAddRows = false;
            this.tabel_item.AllowUserToDeleteRows = false;
            this.tabel_item.AllowUserToOrderColumns = true;
            this.tabel_item.AllowUserToResizeColumns = false;
            this.tabel_item.AllowUserToResizeRows = false;
            this.tabel_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabel_item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabel_item.BackgroundColor = System.Drawing.Color.White;
            this.tabel_item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabel_item.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabel_item.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabel_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabel_item.EnableHeadersVisualStyles = false;
            this.tabel_item.Location = new System.Drawing.Point(210, 100);
            this.tabel_item.Name = "tabel_item";
            this.tabel_item.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_item.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabel_item.RowHeadersVisible = false;
            this.tabel_item.Size = new System.Drawing.Size(963, 644);
            this.tabel_item.TabIndex = 9;
            this.tabel_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnCreatePassword);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 744);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 673);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 71);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 71);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(0, 256);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(210, 71);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.btnCreatePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreatePassword.FlatAppearance.BorderSize = 0;
            this.btnCreatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePassword.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePassword.ForeColor = System.Drawing.Color.White;
            this.btnCreatePassword.Location = new System.Drawing.Point(0, 194);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(210, 62);
            this.btnCreatePassword.TabIndex = 9;
            this.btnCreatePassword.Text = "Create Password";
            this.btnCreatePassword.UseVisualStyleBackColor = false;
            this.btnCreatePassword.Click += new System.EventHandler(this.button1_Click_1);
            this.btnCreatePassword.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnCreatePassword.MouseLeave += new System.EventHandler(this.btnCreatePassword_MouseLeave);
            this.btnCreatePassword.MouseHover += new System.EventHandler(this.btnCreatePassword_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 194);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(50, 145);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(101, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 100);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 744);
            this.Controls.Add(this.tabel_item);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabel_item)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tabel_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}