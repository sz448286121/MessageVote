namespace vote
{
    partial class voter
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
            this.department_select = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.judges_dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.judgename = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.add_judge = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.select_all = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.meeting_select = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.voter_dg = new System.Windows.Forms.DataGridView();
            this.delete_all2 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.display2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.TextBox();
            this.phone2 = new System.Windows.Forms.TextBox();
            this.check1 = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.judges_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voter_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门";
            // 
            // department_select
            // 
            this.department_select.FormattingEnabled = true;
            this.department_select.Location = new System.Drawing.Point(66, 30);
            this.department_select.Name = "department_select";
            this.department_select.Size = new System.Drawing.Size(162, 20);
            this.department_select.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "候选评委";
            // 
            // judges_dg
            // 
            this.judges_dg.AllowUserToAddRows = false;
            this.judges_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.judges_dg.Location = new System.Drawing.Point(31, 74);
            this.judges_dg.Name = "judges_dg";
            this.judges_dg.RowTemplate.Height = 23;
            this.judges_dg.Size = new System.Drawing.Size(505, 125);
            this.judges_dg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(131, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "手机号码";
            // 
            // judgename
            // 
            this.judgename.Location = new System.Drawing.Point(59, 205);
            this.judgename.Name = "judgename";
            this.judgename.Size = new System.Drawing.Size(66, 21);
            this.judgename.TabIndex = 6;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(184, 205);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 21);
            this.phone.TabIndex = 7;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(409, 204);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(64, 23);
            this.check.TabIndex = 8;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(261, 234);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 9;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // delete_all
            // 
            this.delete_all.Location = new System.Drawing.Point(342, 234);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(61, 23);
            this.delete_all.TabIndex = 10;
            this.delete_all.Text = "删除全部";
            this.delete_all.UseVisualStyleBackColor = true;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // add_judge
            // 
            this.add_judge.Location = new System.Drawing.Point(462, 45);
            this.add_judge.Name = "add_judge";
            this.add_judge.Size = new System.Drawing.Size(75, 23);
            this.add_judge.TabIndex = 11;
            this.add_judge.Text = "添加评委";
            this.add_judge.UseVisualStyleBackColor = true;
            this.add_judge.Click += new System.EventHandler(this.add_judge_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(409, 234);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(64, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(475, 204);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(64, 23);
            this.select.TabIndex = 13;
            this.select.Text = "选择";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // select_all
            // 
            this.select_all.Location = new System.Drawing.Point(479, 234);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(61, 23);
            this.select_all.TabIndex = 14;
            this.select_all.Text = "选择全部";
            this.select_all.UseVisualStyleBackColor = true;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(30, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "会议";
            // 
            // meeting_select
            // 
            this.meeting_select.FormattingEnabled = true;
            this.meeting_select.Location = new System.Drawing.Point(68, 6);
            this.meeting_select.Name = "meeting_select";
            this.meeting_select.Size = new System.Drawing.Size(160, 20);
            this.meeting_select.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(29, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "已选评委";
            // 
            // voter_dg
            // 
            this.voter_dg.AllowUserToAddRows = false;
            this.voter_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voter_dg.Location = new System.Drawing.Point(28, 263);
            this.voter_dg.Name = "voter_dg";
            this.voter_dg.RowTemplate.Height = 23;
            this.voter_dg.Size = new System.Drawing.Size(508, 151);
            this.voter_dg.TabIndex = 21;
            // 
            // delete_all2
            // 
            this.delete_all2.Location = new System.Drawing.Point(380, 452);
            this.delete_all2.Name = "delete_all2";
            this.delete_all2.Size = new System.Drawing.Size(75, 23);
            this.delete_all2.TabIndex = 22;
            this.delete_all2.Text = "删除全部";
            this.delete_all2.UseVisualStyleBackColor = true;
            this.delete_all2.Click += new System.EventHandler(this.delete_all2_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(464, 423);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(75, 23);
            this.delete2.TabIndex = 23;
            this.delete2.Text = "删除";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // display2
            // 
            this.display2.Location = new System.Drawing.Point(465, 452);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(75, 23);
            this.display2.TabIndex = 25;
            this.display2.Text = "显示全部";
            this.display2.UseVisualStyleBackColor = true;
            this.display2.Click += new System.EventHandler(this.display2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(121, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "姓名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(222, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "手机号码";
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(157, 423);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(59, 21);
            this.name2.TabIndex = 28;
            // 
            // phone2
            // 
            this.phone2.Location = new System.Drawing.Point(278, 423);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(97, 21);
            this.phone2.TabIndex = 29;
            // 
            // check1
            // 
            this.check1.Location = new System.Drawing.Point(380, 423);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(75, 23);
            this.check1.TabIndex = 30;
            this.check1.Text = "查询";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.Click += new System.EventHandler(this.check1_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(288, 207);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(29, 12);
            this.label_title.TabIndex = 32;
            this.label_title.Text = "职称";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(321, 205);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 21);
            this.title.TabIndex = 33;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(184, 234);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 23);
            this.save.TabIndex = 34;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "单位";
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(55, 421);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(66, 21);
            this.department.TabIndex = 36;
            // 
            // voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 479);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.delete_all2);
            this.Controls.Add(this.voter_dg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.meeting_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.select_all);
            this.Controls.Add(this.select);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add_judge);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.judgename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.judges_dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.department_select);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "voter";
            this.Text = "评委设置";
            this.Load += new System.EventHandler(this.voter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.judges_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voter_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox department_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView judges_dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox judgename;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button delete_all;
        private System.Windows.Forms.Button add_judge;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button select_all;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox meeting_select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView voter_dg;
        private System.Windows.Forms.Button delete_all2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button display2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox phone2;
        private System.Windows.Forms.Button check1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox department;
    }
}