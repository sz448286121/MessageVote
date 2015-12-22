namespace vote
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meeting = new System.Windows.Forms.ToolStripMenuItem();
            this.poll = new System.Windows.Forms.ToolStripMenuItem();
            this.project = new System.Windows.Forms.ToolStripMenuItem();
            this.voter = new System.Windows.Forms.ToolStripMenuItem();
            this.result = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.meeting_select = new System.Windows.Forms.ComboBox();
            this.presence_dg = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.department_select = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.send_message = new System.Windows.Forms.Button();
            this.enter_vote = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.present_state = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.meetingtime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.meetingaddress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presence_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meeting,
            this.poll,
            this.project,
            this.voter,
            this.result,
            this.information});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meeting
            // 
            this.meeting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meeting.Name = "meeting";
            this.meeting.Size = new System.Drawing.Size(77, 24);
            this.meeting.Text = "会议设置";
            this.meeting.Click += new System.EventHandler(this.meeting_Click);
            // 
            // poll
            // 
            this.poll.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.poll.Name = "poll";
            this.poll.Size = new System.Drawing.Size(77, 24);
            this.poll.Text = "评审设置";
            this.poll.Click += new System.EventHandler(this.poll_Click);
            // 
            // project
            // 
            this.project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(77, 24);
            this.project.Text = "项目设置";
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // voter
            // 
            this.voter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.voter.Name = "voter";
            this.voter.Size = new System.Drawing.Size(77, 24);
            this.voter.Text = "评委设置";
            this.voter.Click += new System.EventHandler(this.voter_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(77, 24);
            this.result.Text = "评审结果";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(77, 24);
            this.information.Text = "评审信息";
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "会议:";
            // 
            // meeting_select
            // 
            this.meeting_select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meeting_select.FormattingEnabled = true;
            this.meeting_select.Location = new System.Drawing.Point(67, 35);
            this.meeting_select.Name = "meeting_select";
            this.meeting_select.Size = new System.Drawing.Size(164, 25);
            this.meeting_select.TabIndex = 2;
            // 
            // presence_dg
            // 
            this.presence_dg.AllowUserToAddRows = false;
            this.presence_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presence_dg.Location = new System.Drawing.Point(26, 80);
            this.presence_dg.Name = "presence_dg";
            this.presence_dg.RowTemplate.Height = 23;
            this.presence_dg.Size = new System.Drawing.Size(842, 308);
            this.presence_dg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "签到";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(173, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(289, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "手机";
            // 
            // department_select
            // 
            this.department_select.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.department_select.FormattingEnabled = true;
            this.department_select.Location = new System.Drawing.Point(61, 401);
            this.department_select.Name = "department_select";
            this.department_select.Size = new System.Drawing.Size(111, 28);
            this.department_select.TabIndex = 9;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(208, 401);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 26);
            this.name.TabIndex = 10;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(326, 401);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(109, 26);
            this.phone.TabIndex = 11;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check.Location = new System.Drawing.Point(441, 400);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(94, 27);
            this.check.TabIndex = 12;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // send_message
            // 
            this.send_message.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_message.Location = new System.Drawing.Point(639, 400);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(132, 27);
            this.send_message.TabIndex = 15;
            this.send_message.Text = "通知评委";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // enter_vote
            // 
            this.enter_vote.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enter_vote.Location = new System.Drawing.Point(773, 400);
            this.enter_vote.Name = "enter_vote";
            this.enter_vote.Size = new System.Drawing.Size(97, 27);
            this.enter_vote.TabIndex = 16;
            this.enter_vote.Text = "进入评审";
            this.enter_vote.UseVisualStyleBackColor = true;
            this.enter_vote.Click += new System.EventHandler(this.enter_vote_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.display.Location = new System.Drawing.Point(538, 400);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(97, 27);
            this.display.TabIndex = 13;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(22, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "已到/全部";
            // 
            // present_state
            // 
            this.present_state.AutoSize = true;
            this.present_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.present_state.Location = new System.Drawing.Point(80, 455);
            this.present_state.Name = "present_state";
            this.present_state.Size = new System.Drawing.Size(27, 17);
            this.present_state.TabIndex = 18;
            this.present_state.Text = "0/0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(237, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "会议时间:";
            // 
            // meetingtime
            // 
            this.meetingtime.AutoSize = true;
            this.meetingtime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meetingtime.Location = new System.Drawing.Point(305, 37);
            this.meetingtime.Name = "meetingtime";
            this.meetingtime.Size = new System.Drawing.Size(50, 20);
            this.meetingtime.TabIndex = 20;
            this.meetingtime.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(453, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "会议地点：";
            // 
            // meetingaddress
            // 
            this.meetingaddress.AutoSize = true;
            this.meetingaddress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meetingaddress.Location = new System.Drawing.Point(531, 36);
            this.meetingaddress.Name = "meetingaddress";
            this.meetingaddress.Size = new System.Drawing.Size(50, 20);
            this.meetingaddress.TabIndex = 22;
            this.meetingaddress.Text = "label9";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 482);
            this.Controls.Add(this.meetingaddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.meetingtime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.present_state);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enter_vote);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.department_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.presence_dg);
            this.Controls.Add(this.meeting_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目投票表决系统";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presence_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meeting;
        private System.Windows.Forms.ToolStripMenuItem poll;
        private System.Windows.Forms.ToolStripMenuItem project;
        private System.Windows.Forms.ToolStripMenuItem voter;
        private System.Windows.Forms.ToolStripMenuItem result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox meeting_select;
        private System.Windows.Forms.DataGridView presence_dg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox department_select;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.Button enter_vote;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label present_state;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label meetingtime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label meetingaddress;
    }
}

