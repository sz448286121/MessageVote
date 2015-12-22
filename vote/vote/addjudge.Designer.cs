namespace vote
{
    partial class addjudge
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.judgename = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(66, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "手机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(66, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(66, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "年龄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(66, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "职称";
            // 
            // judgename
            // 
            this.judgename.Location = new System.Drawing.Point(104, 28);
            this.judgename.Name = "judgename";
            this.judgename.Size = new System.Drawing.Size(100, 21);
            this.judgename.TabIndex = 6;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(104, 61);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(100, 21);
            this.department.TabIndex = 7;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(104, 91);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 21);
            this.title.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(104, 123);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 21);
            this.phone.TabIndex = 9;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(104, 157);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 21);
            this.sex.TabIndex = 10;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(104, 190);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 21);
            this.age.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(129, 223);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // add_judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.add);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.title);
            this.Controls.Add(this.department);
            this.Controls.Add(this.judgename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_judge";
            this.Text = "添加评委";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox judgename;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button add;
    }
}