namespace vote
{
    partial class result
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
            this.meetingname_select = new System.Windows.Forms.ComboBox();
            this.pollnum_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result_dg = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projectnum = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.principal = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.pollname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.result_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // meetingname_select
            // 
            this.meetingname_select.FormattingEnabled = true;
            this.meetingname_select.Location = new System.Drawing.Point(67, 21);
            this.meetingname_select.Name = "meetingname_select";
            this.meetingname_select.Size = new System.Drawing.Size(137, 20);
            this.meetingname_select.TabIndex = 0;
            // 
            // pollnum_select
            // 
            this.pollnum_select.FormattingEnabled = true;
            this.pollnum_select.Location = new System.Drawing.Point(263, 21);
            this.pollnum_select.Name = "pollnum_select";
            this.pollnum_select.Size = new System.Drawing.Size(91, 20);
            this.pollnum_select.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "会议";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(210, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "评审序号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "评审结果";
            // 
            // result_dg
            // 
            this.result_dg.AllowUserToAddRows = false;
            this.result_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dg.Location = new System.Drawing.Point(32, 64);
            this.result_dg.Name = "result_dg";
            this.result_dg.RowTemplate.Height = 23;
            this.result_dg.Size = new System.Drawing.Size(430, 336);
            this.result_dg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "项目序号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(149, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "单位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(273, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "负责人";
            // 
            // projectnum
            // 
            this.projectnum.Location = new System.Drawing.Point(85, 415);
            this.projectnum.Name = "projectnum";
            this.projectnum.Size = new System.Drawing.Size(53, 21);
            this.projectnum.TabIndex = 9;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(183, 415);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(83, 21);
            this.department.TabIndex = 10;
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(320, 415);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(62, 21);
            this.principal.TabIndex = 11;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(387, 413);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 27);
            this.check.TabIndex = 12;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(387, 447);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 27);
            this.display.TabIndex = 13;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // pollname
            // 
            this.pollname.AutoSize = true;
            this.pollname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollname.Location = new System.Drawing.Point(365, 21);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(56, 17);
            this.pollname.TabIndex = 14;
            this.pollname.Text = "评审名称";
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 482);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.department);
            this.Controls.Add(this.projectnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_dg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pollnum_select);
            this.Controls.Add(this.meetingname_select);
            this.MaximizeBox = false;
            this.Name = "result";
            this.Text = "评审结果";
            this.Load += new System.EventHandler(this.result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox meetingname_select;
        private System.Windows.Forms.ComboBox pollnum_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView result_dg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox projectnum;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label pollname;
    }
}