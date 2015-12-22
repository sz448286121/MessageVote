namespace vote
{
    partial class information
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
            this.meeting_select = new System.Windows.Forms.ComboBox();
            this.pollnum_select = new System.Windows.Forms.ComboBox();
            this.information_dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.pollname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.information_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "评审序号";
            // 
            // meeting_select
            // 
            this.meeting_select.ForeColor = System.Drawing.SystemColors.WindowText;
            this.meeting_select.FormattingEnabled = true;
            this.meeting_select.Location = new System.Drawing.Point(64, 30);
            this.meeting_select.Name = "meeting_select";
            this.meeting_select.Size = new System.Drawing.Size(147, 20);
            this.meeting_select.TabIndex = 2;
            // 
            // pollnum_select
            // 
            this.pollnum_select.FormattingEnabled = true;
            this.pollnum_select.Location = new System.Drawing.Point(284, 30);
            this.pollnum_select.Name = "pollnum_select";
            this.pollnum_select.Size = new System.Drawing.Size(76, 20);
            this.pollnum_select.TabIndex = 3;
            // 
            // information_dg
            // 
            this.information_dg.AllowUserToAddRows = false;
            this.information_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.information_dg.Location = new System.Drawing.Point(29, 77);
            this.information_dg.Name = "information_dg";
            this.information_dg.RowTemplate.Height = 23;
            this.information_dg.Size = new System.Drawing.Size(440, 347);
            this.information_dg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "评审信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "单位";
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(65, 431);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(65, 21);
            this.department.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(168, 431);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 21);
            this.name.TabIndex = 10;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(277, 431);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 21);
            this.phone.TabIndex = 11;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(394, 430);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 12;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(394, 457);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 13;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // pollname
            // 
            this.pollname.AutoSize = true;
            this.pollname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollname.Location = new System.Drawing.Point(367, 34);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(56, 17);
            this.pollname.TabIndex = 14;
            this.pollname.Text = "评审名称";
            // 
            // information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 482);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.information_dg);
            this.Controls.Add(this.pollnum_select);
            this.Controls.Add(this.meeting_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "information";
            this.Text = "评审信息";
            this.Load += new System.EventHandler(this.information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.information_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox meeting_select;
        private System.Windows.Forms.ComboBox pollnum_select;
        private System.Windows.Forms.DataGridView information_dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label pollname;
    }
}