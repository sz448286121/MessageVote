namespace vote
{
    partial class meeting
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
            this.meeting_dg = new System.Windows.Forms.DataGridView();
            this.meetingname_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.start_time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.DateTimePicker();
            this.check_by_date = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add_meeting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议";
            // 
            // meeting_dg
            // 
            this.meeting_dg.AllowUserToAddRows = false;
            this.meeting_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meeting_dg.Location = new System.Drawing.Point(36, 31);
            this.meeting_dg.Name = "meeting_dg";
            this.meeting_dg.RowTemplate.Height = 23;
            this.meeting_dg.Size = new System.Drawing.Size(391, 337);
            this.meeting_dg.TabIndex = 1;
            // 
            // meetingname_tb
            // 
            this.meetingname_tb.Location = new System.Drawing.Point(99, 374);
            this.meetingname_tb.Name = "meetingname_tb";
            this.meetingname_tb.Size = new System.Drawing.Size(100, 21);
            this.meetingname_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "会议名称";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(215, 374);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 27);
            this.check.TabIndex = 4;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(126, 440);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 27);
            this.display.TabIndex = 5;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(99, 407);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(112, 21);
            this.start_time.TabIndex = 7;
            this.start_time.Value = new System.DateTime(2014, 8, 14, 0, 0, 1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "至";
            // 
            // end_time
            // 
            this.end_time.Location = new System.Drawing.Point(240, 407);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(118, 21);
            this.end_time.TabIndex = 9;
            this.end_time.Value = new System.DateTime(2014, 8, 14, 23, 59, 59, 0);
            // 
            // check_by_date
            // 
            this.check_by_date.Location = new System.Drawing.Point(379, 405);
            this.check_by_date.Name = "check_by_date";
            this.check_by_date.Size = new System.Drawing.Size(75, 27);
            this.check_by_date.TabIndex = 10;
            this.check_by_date.Text = "查询";
            this.check_by_date.UseVisualStyleBackColor = true;
            this.check_by_date.Click += new System.EventHandler(this.check_by_date_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(38, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "会议时间";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(296, 440);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 17;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // delete_all
            // 
            this.delete_all.Location = new System.Drawing.Point(211, 440);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(75, 27);
            this.delete_all.TabIndex = 18;
            this.delete_all.Text = "删除全部";
            this.delete_all.UseVisualStyleBackColor = true;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(381, 440);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 27);
            this.save.TabIndex = 19;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add_meeting
            // 
            this.add_meeting.Location = new System.Drawing.Point(41, 440);
            this.add_meeting.Name = "add_meeting";
            this.add_meeting.Size = new System.Drawing.Size(75, 27);
            this.add_meeting.TabIndex = 20;
            this.add_meeting.Text = "添加会议";
            this.add_meeting.UseVisualStyleBackColor = true;
            this.add_meeting.Click += new System.EventHandler(this.add_meeting_Click);
            // 
            // meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 482);
            this.Controls.Add(this.add_meeting);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.check_by_date);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.display);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meetingname_tb);
            this.Controls.Add(this.meeting_dg);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "meeting";
            this.Text = "会议设置";
            this.Load += new System.EventHandler(this.meeting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meeting_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView meeting_dg;
        private System.Windows.Forms.TextBox meetingname_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.DateTimePicker start_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker end_time;
        private System.Windows.Forms.Button check_by_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button delete_all;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add_meeting;
    }
}