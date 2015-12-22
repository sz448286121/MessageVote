namespace vote
{
    partial class addmeeting
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
            this.meetingname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingtime = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.meetingaddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议名称";
            // 
            // meetingname
            // 
            this.meetingname.Location = new System.Drawing.Point(97, 22);
            this.meetingname.Name = "meetingname";
            this.meetingname.Size = new System.Drawing.Size(147, 21);
            this.meetingname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "会议时间";
            // 
            // meetingtime
            // 
            this.meetingtime.Location = new System.Drawing.Point(97, 54);
            this.meetingtime.Name = "meetingtime";
            this.meetingtime.Size = new System.Drawing.Size(147, 21);
            this.meetingtime.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(111, 133);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "会议地点";
            // 
            // meetingaddress
            // 
            this.meetingaddress.Location = new System.Drawing.Point(98, 88);
            this.meetingaddress.Name = "meetingaddress";
            this.meetingaddress.Size = new System.Drawing.Size(146, 21);
            this.meetingaddress.TabIndex = 6;
            // 
            // addmeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 182);
            this.Controls.Add(this.meetingaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.meetingtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meetingname);
            this.Controls.Add(this.label1);
            this.Name = "addmeeting";
            this.Text = "添加会议";
            this.Load += new System.EventHandler(this.addmeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox meetingname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker meetingtime;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meetingaddress;
    }
}