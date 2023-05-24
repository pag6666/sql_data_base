namespace sql_data_base
{
    partial class Mainfile
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SD = new System.Windows.Forms.GroupBox();
            this.select_check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insert_into = new System.Windows.Forms.Button();
            this.select_show = new System.Windows.Forms.Button();
            this.loginG1_text = new System.Windows.Forms.TextBox();
            this.passwordG1_text = new System.Windows.Forms.TextBox();
            this.loginG1 = new System.Windows.Forms.Label();
            this.passwordG1 = new System.Windows.Forms.Label();
            this.passwordG2 = new System.Windows.Forms.Label();
            this.loginG2 = new System.Windows.Forms.Label();
            this.passwordG2_text = new System.Windows.Forms.TextBox();
            this.loginG2_text = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordG3_text = new System.Windows.Forms.TextBox();
            this.loginG3_text = new System.Windows.Forms.TextBox();
            this.delete_bt = new System.Windows.Forms.Button();
            this.SD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SD
            // 
            this.SD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SD.Controls.Add(this.passwordG1);
            this.SD.Controls.Add(this.loginG1);
            this.SD.Controls.Add(this.passwordG1_text);
            this.SD.Controls.Add(this.loginG1_text);
            this.SD.Controls.Add(this.select_check);
            this.SD.Location = new System.Drawing.Point(77, 71);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(250, 204);
            this.SD.TabIndex = 0;
            this.SD.TabStop = false;
            this.SD.Text = "Select check";
            // 
            // select_check
            // 
            this.select_check.Location = new System.Drawing.Point(98, 163);
            this.select_check.Name = "select_check";
            this.select_check.Size = new System.Drawing.Size(80, 30);
            this.select_check.TabIndex = 0;
            this.select_check.Text = "select check";
            this.select_check.UseVisualStyleBackColor = true;
            this.select_check.Click += new System.EventHandler(this.select_check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.passwordG2);
            this.groupBox1.Controls.Add(this.insert_into);
            this.groupBox1.Controls.Add(this.loginG2);
            this.groupBox1.Controls.Add(this.passwordG2_text);
            this.groupBox1.Controls.Add(this.loginG2_text);
            this.groupBox1.Location = new System.Drawing.Point(354, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert into";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.select_show);
            this.groupBox2.Location = new System.Drawing.Point(610, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 327);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select show";
            // 
            // insert_into
            // 
            this.insert_into.Location = new System.Drawing.Point(98, 163);
            this.insert_into.Name = "insert_into";
            this.insert_into.Size = new System.Drawing.Size(80, 30);
            this.insert_into.TabIndex = 1;
            this.insert_into.Text = "insert into";
            this.insert_into.UseVisualStyleBackColor = true;
            this.insert_into.Click += new System.EventHandler(this.insert_into_Click);
            // 
            // select_show
            // 
            this.select_show.Location = new System.Drawing.Point(171, 282);
            this.select_show.Name = "select_show";
            this.select_show.Size = new System.Drawing.Size(80, 30);
            this.select_show.TabIndex = 2;
            this.select_show.Text = "select show";
            this.select_show.UseVisualStyleBackColor = true;
            this.select_show.Click += new System.EventHandler(this.select_show_Click);
            // 
            // loginG1_text
            // 
            this.loginG1_text.Location = new System.Drawing.Point(27, 84);
            this.loginG1_text.Multiline = true;
            this.loginG1_text.Name = "loginG1_text";
            this.loginG1_text.Size = new System.Drawing.Size(77, 30);
            this.loginG1_text.TabIndex = 1;
            // 
            // passwordG1_text
            // 
            this.passwordG1_text.Location = new System.Drawing.Point(156, 84);
            this.passwordG1_text.Multiline = true;
            this.passwordG1_text.Name = "passwordG1_text";
            this.passwordG1_text.Size = new System.Drawing.Size(77, 30);
            this.passwordG1_text.TabIndex = 2;
            // 
            // loginG1
            // 
            this.loginG1.AutoSize = true;
            this.loginG1.Location = new System.Drawing.Point(27, 65);
            this.loginG1.Name = "loginG1";
            this.loginG1.Size = new System.Drawing.Size(29, 13);
            this.loginG1.TabIndex = 3;
            this.loginG1.Text = "login";
            // 
            // passwordG1
            // 
            this.passwordG1.AutoSize = true;
            this.passwordG1.Location = new System.Drawing.Point(153, 65);
            this.passwordG1.Name = "passwordG1";
            this.passwordG1.Size = new System.Drawing.Size(52, 13);
            this.passwordG1.TabIndex = 4;
            this.passwordG1.Text = "password";
            // 
            // passwordG2
            // 
            this.passwordG2.AutoSize = true;
            this.passwordG2.Location = new System.Drawing.Point(151, 65);
            this.passwordG2.Name = "passwordG2";
            this.passwordG2.Size = new System.Drawing.Size(52, 13);
            this.passwordG2.TabIndex = 9;
            this.passwordG2.Text = "password";
            // 
            // loginG2
            // 
            this.loginG2.AutoSize = true;
            this.loginG2.Location = new System.Drawing.Point(16, 65);
            this.loginG2.Name = "loginG2";
            this.loginG2.Size = new System.Drawing.Size(29, 13);
            this.loginG2.TabIndex = 8;
            this.loginG2.Text = "login";
            // 
            // passwordG2_text
            // 
            this.passwordG2_text.Location = new System.Drawing.Point(154, 84);
            this.passwordG2_text.Multiline = true;
            this.passwordG2_text.Name = "passwordG2_text";
            this.passwordG2_text.Size = new System.Drawing.Size(77, 30);
            this.passwordG2_text.TabIndex = 7;
            // 
            // loginG2_text
            // 
            this.loginG2_text.Location = new System.Drawing.Point(19, 84);
            this.loginG2_text.Multiline = true;
            this.loginG2_text.Name = "loginG2_text";
            this.loginG2_text.Size = new System.Drawing.Size(77, 30);
            this.loginG2_text.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 238);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.passwordG3_text);
            this.groupBox3.Controls.Add(this.loginG3_text);
            this.groupBox3.Controls.Add(this.delete_bt);
            this.groupBox3.Location = new System.Drawing.Point(77, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 204);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "delete ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "login";
            // 
            // passwordG3_text
            // 
            this.passwordG3_text.Location = new System.Drawing.Point(156, 84);
            this.passwordG3_text.Multiline = true;
            this.passwordG3_text.Name = "passwordG3_text";
            this.passwordG3_text.Size = new System.Drawing.Size(77, 30);
            this.passwordG3_text.TabIndex = 2;
            // 
            // loginG3_text
            // 
            this.loginG3_text.Location = new System.Drawing.Point(27, 84);
            this.loginG3_text.Multiline = true;
            this.loginG3_text.Name = "loginG3_text";
            this.loginG3_text.Size = new System.Drawing.Size(77, 30);
            this.loginG3_text.TabIndex = 1;
            // 
            // delete_bt
            // 
            this.delete_bt.Location = new System.Drawing.Point(98, 163);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(80, 30);
            this.delete_bt.TabIndex = 0;
            this.delete_bt.Text = "delete";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // Mainfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1080, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SD);
            this.Name = "Mainfile";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfile_FormClosed);
            this.SD.ResumeLayout(false);
            this.SD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SD;
        private System.Windows.Forms.Button select_check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button insert_into;
        private System.Windows.Forms.Button select_show;
        private System.Windows.Forms.Label passwordG1;
        private System.Windows.Forms.Label loginG1;
        private System.Windows.Forms.TextBox passwordG1_text;
        private System.Windows.Forms.TextBox loginG1_text;
        private System.Windows.Forms.Label passwordG2;
        private System.Windows.Forms.Label loginG2;
        private System.Windows.Forms.TextBox passwordG2_text;
        private System.Windows.Forms.TextBox loginG2_text;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordG3_text;
        private System.Windows.Forms.TextBox loginG3_text;
        private System.Windows.Forms.Button delete_bt;
    }
}

