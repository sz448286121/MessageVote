namespace vote
{
    partial class project
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
            this.project_dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projectnum = new System.Windows.Forms.TextBox();
            this.projectname = new System.Windows.Forms.TextBox();
            this.principal = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.addproject = new System.Windows.Forms.Button();
            this.pollname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(190, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "评审序号";
            // 
            // meeting_select
            // 
            this.meeting_select.FormattingEnabled = true;
            this.meeting_select.Location = new System.Drawing.Point(63, 11);
            this.meeting_select.Name = "meeting_select";
            this.meeting_select.Size = new System.Drawing.Size(121, 20);
            this.meeting_select.TabIndex = 2;
            // 
            // pollnum_select
            // 
            this.pollnum_select.FormattingEnabled = true;
            this.pollnum_select.Location = new System.Drawing.Point(252, 11);
            this.pollnum_select.Name = "pollnum_select";
            this.pollnum_select.Size = new System.Drawing.Size(80, 20);
            this.pollnum_select.TabIndex = 3;
            // 
            // project_dg
            // 
            this.project_dg.AllowUserToAddRows = false;
            this.project_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.project_dg.Location = new System.Drawing.Point(27, 58);
            this.project_dg.Name = "project_dg";
            this.project_dg.RowTemplate.Height = 23;
            this.project_dg.Size = new System.Drawing.Size(427, 344);
            this.project_dg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "项目";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(28, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "项目序号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(144, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "项目名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(271, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "负责人";
            // 
            // projectnum
            // 
            this.projectnum.Location = new System.Drawing.Point(84, 411);
            this.projectnum.Name = "projectnum";
            this.projectnum.Size = new System.Drawing.Size(59, 21);
            this.projectnum.TabIndex = 9;
            // 
            // projectname
            // 
            this.projectname.Location = new System.Drawing.Point(184, 412);
            this.projectname.Name = "projectname";
            this.projectname.Size = new System.Drawing.Size(81, 21);
            this.projectname.TabIndex = 10;
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(322, 412);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(54, 21);
            this.principal.TabIndex = 11;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(383, 407);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(72, 27);
            this.check.TabIndex = 12;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(209, 443);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 27);
            this.display.TabIndex = 13;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // delete_all
            // 
            this.delete_all.Location = new System.Drawing.Point(122, 443);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(75, 27);
            this.delete_all.TabIndex = 14;
            this.delete_all.Text = "删除全部";
            this.delete_all.UseVisualStyleBackColor = true;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(383, 443);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(71, 27);
            this.save.TabIndex = 15;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(302, 442);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 16;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addproject
            // 
            this.addproject.Location = new System.Drawing.Point(31, 442);
            this.addproject.Name = "addproject";
            this.addproject.Size = new System.Drawing.Size(79, 27);
            this.addproject.TabIndex = 17;
            this.addproject.Text = "添加项目";
            this.addproject.UseVisualStyleBackColor = true;
            this.addproject.Click += new System.EventHandler(this.addproject_Click);
            // 
            // pollname
            // 
            this.pollname.AutoSize = true;
            this.pollname.Location = new System.Drawing.Point(340, 15);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(53, 12);
            this.pollname.TabIndex = 18;
            this.pollname.Text = "评审名称";
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 482);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.addproject);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.projectname);
            this.Controls.Add(this.projectnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.project_dg);
            this.Controls.Add(this.pollnum_select);
            this.Controls.Add(this.meeting_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "project";
            this.Text = "项目设置";
            this.Load += new System.EventHandler(this.project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox meeting_select;
        private System.Windows.Forms.ComboBox pollnum_select;
        private System.Windows.Forms.DataGridView project_dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox projectnum;
        private System.Windows.Forms.TextBox projectname;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button delete_all;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addproject;
        private System.Windows.Forms.Label pollname;
    }
}