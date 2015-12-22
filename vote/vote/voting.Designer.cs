namespace vote
{
    partial class voting
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
            this.pollnum_select = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voting_dg = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.check_result = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pollname = new System.Windows.Forms.Label();
            this.pollmethod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calmethod = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.voting_dg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "评审序号:";
            // 
            // pollnum_select
            // 
            this.pollnum_select.FormattingEnabled = true;
            this.pollnum_select.Location = new System.Drawing.Point(84, 9);
            this.pollnum_select.Name = "pollnum_select";
            this.pollnum_select.Size = new System.Drawing.Size(75, 20);
            this.pollnum_select.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目信息";
            // 
            // voting_dg
            // 
            this.voting_dg.AllowUserToAddRows = false;
            this.voting_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voting_dg.Location = new System.Drawing.Point(27, 65);
            this.voting_dg.Name = "voting_dg";
            this.voting_dg.RowTemplate.Height = 23;
            this.voting_dg.Size = new System.Drawing.Size(443, 312);
            this.voting_dg.TabIndex = 3;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(314, 36);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "开始评审";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(395, 36);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 5;
            this.finish.Text = "结束评审";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // check_result
            // 
            this.check_result.Location = new System.Drawing.Point(397, 454);
            this.check_result.Name = "check_result";
            this.check_result.Size = new System.Drawing.Size(75, 23);
            this.check_result.TabIndex = 6;
            this.check_result.Text = "计算结果";
            this.check_result.UseVisualStyleBackColor = true;
            this.check_result.Click += new System.EventHandler(this.check_result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "评审名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(312, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "评审方式:";
            // 
            // pollname
            // 
            this.pollname.AutoSize = true;
            this.pollname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollname.Location = new System.Drawing.Point(244, 9);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(46, 17);
            this.pollname.TabIndex = 9;
            this.pollname.Text = "animal";
            // 
            // pollmethod
            // 
            this.pollmethod.AutoSize = true;
            this.pollmethod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollmethod.Location = new System.Drawing.Point(374, 9);
            this.pollmethod.Name = "pollmethod";
            this.pollmethod.Size = new System.Drawing.Size(44, 17);
            this.pollmethod.TabIndex = 10;
            this.pollmethod.Text = "百分制";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "已投/全部";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(101, 463);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(23, 12);
            this.state.TabIndex = 12;
            this.state.Text = "0/0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calmethod);
            this.groupBox1.Location = new System.Drawing.Point(29, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算方法";
            // 
            // calmethod
            // 
            this.calmethod.AutoSize = true;
            this.calmethod.Location = new System.Drawing.Point(37, 20);
            this.calmethod.Name = "calmethod";
            this.calmethod.Size = new System.Drawing.Size(132, 16);
            this.calmethod.TabIndex = 0;
            this.calmethod.Text = "去除最高分和最低分";
            this.calmethod.UseVisualStyleBackColor = true;
            // 
            // voting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(498, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pollmethod);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_result);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.voting_dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pollnum_select);
            this.Controls.Add(this.label1);
            this.Name = "voting";
            this.Text = "开始评审";
            this.Load += new System.EventHandler(this.voting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voting_dg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pollnum_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView voting_dg;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button check_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pollname;
        private System.Windows.Forms.Label pollmethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox calmethod;
    }
}