namespace vote
{
    partial class addpoll
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
            this.label2 = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pollname = new System.Windows.Forms.TextBox();
            this.add_poll = new System.Windows.Forms.Button();
            this.method.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "评审名称";
            // 
            // method
            // 
            this.method.Controls.Add(this.radioButton3);
            this.method.Controls.Add(this.radioButton2);
            this.method.Controls.Add(this.radioButton1);
            this.method.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.method.Location = new System.Drawing.Point(48, 96);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(115, 112);
            this.method.TabIndex = 3;
            this.method.TabStop = false;
            this.method.Text = "评审方式";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "01制";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "十分制";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "百分制";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pollname
            // 
            this.pollname.Location = new System.Drawing.Point(116, 43);
            this.pollname.Name = "pollname";
            this.pollname.Size = new System.Drawing.Size(113, 21);
            this.pollname.TabIndex = 5;
            // 
            // add_poll
            // 
            this.add_poll.Location = new System.Drawing.Point(192, 209);
            this.add_poll.Name = "add_poll";
            this.add_poll.Size = new System.Drawing.Size(75, 23);
            this.add_poll.TabIndex = 6;
            this.add_poll.Text = "添加投票";
            this.add_poll.UseVisualStyleBackColor = true;
            this.add_poll.Click += new System.EventHandler(this.add_poll_Click);
            // 
            // addpoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 244);
            this.Controls.Add(this.add_poll);
            this.Controls.Add(this.pollname);
            this.Controls.Add(this.method);
            this.Controls.Add(this.label2);
            this.Name = "addpoll";
            this.Text = "添加评审";
            this.method.ResumeLayout(false);
            this.method.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox method;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox pollname;
        private System.Windows.Forms.Button add_poll;
    }
}