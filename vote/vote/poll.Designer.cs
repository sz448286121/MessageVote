namespace vote
{
    partial class poll
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
            this.meeting_select = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poll_dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pollnum = new System.Windows.Forms.TextBox();
            this.pollname = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add_poll = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poll_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议";
            // 
            // meeting_select
            // 
            this.meeting_select.FormattingEnabled = true;
            this.meeting_select.Location = new System.Drawing.Point(65, 12);
            this.meeting_select.Name = "meeting_select";
            this.meeting_select.Size = new System.Drawing.Size(145, 25);
            this.meeting_select.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "评审";
            // 
            // poll_dg
            // 
            this.poll_dg.AllowUserToAddRows = false;
            this.poll_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poll_dg.Location = new System.Drawing.Point(30, 59);
            this.poll_dg.Name = "poll_dg";
            this.poll_dg.RowTemplate.Height = 23;
            this.poll_dg.Size = new System.Drawing.Size(396, 337);
            this.poll_dg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "评审序号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(163, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "评审名称";
            // 
            // pollnum
            // 
            this.pollnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollnum.Location = new System.Drawing.Point(90, 407);
            this.pollnum.Name = "pollnum";
            this.pollnum.Size = new System.Drawing.Size(72, 23);
            this.pollnum.TabIndex = 7;
            // 
            // pollname
            // 
            this.pollname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pollname.Location = new System.Drawing.Point(225, 407);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(112, 23);
            this.pollname.TabIndex = 8;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check.Location = new System.Drawing.Point(354, 405);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 27);
            this.check.TabIndex = 9;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Location = new System.Drawing.Point(277, 443);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(73, 27);
            this.delete.TabIndex = 10;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add_poll
            // 
            this.add_poll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_poll.Location = new System.Drawing.Point(31, 443);
            this.add_poll.Name = "add_poll";
            this.add_poll.Size = new System.Drawing.Size(78, 27);
            this.add_poll.TabIndex = 11;
            this.add_poll.Text = "添加评审";
            this.add_poll.UseVisualStyleBackColor = true;
            this.add_poll.Click += new System.EventHandler(this.add_poll_Click);
            // 
            // delete_all
            // 
            this.delete_all.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_all.Location = new System.Drawing.Point(113, 443);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(83, 27);
            this.delete_all.TabIndex = 12;
            this.delete_all.Text = "删除全部";
            this.delete_all.UseVisualStyleBackColor = true;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.display.Location = new System.Drawing.Point(198, 443);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(77, 27);
            this.display.TabIndex = 13;
            this.display.Text = "显示全部";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(356, 443);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 27);
            this.save.TabIndex = 14;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // poll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 482);
            this.Controls.Add(this.save);
            this.Controls.Add(this.display);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.add_poll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.check);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.pollnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poll_dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meeting_select);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "poll";
            this.Text = "评审设置";
            this.Load += new System.EventHandler(this.poll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poll_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox meeting_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView poll_dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pollnum;
        private System.Windows.Forms.TextBox pollname;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add_poll;
        private System.Windows.Forms.Button delete_all;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button save;
    }
}