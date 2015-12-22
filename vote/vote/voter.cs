using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vote
{
    public partial class voter : Form
    {
        public delegate void RefreshParentForm(object sender);
        public event RefreshParentForm refreshParent;
        public voter()
        {
            InitializeComponent();
        }

        private void voter_Load(object sender, EventArgs e)
        {
            department_select.DataSource = mainform.db.query_dt("select '' as department union select distinct department from dbo.judges"); ;
            department_select.DisplayMember = "department";
            department_select.SelectedIndexChanged += new EventHandler(department_select_SelectIndexChanged);

            meeting_select.DataSource = mainform.db.query_dt("select meetingname from dbo.meeting order by meetingtime");
            meeting_select.DisplayMember = "meetingname";
            meeting_select.SelectedIndexChanged += new EventHandler(meeting_select_SelectedIndexChanged);

            judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from dbo.judges ");
            judges_dg.Columns["department"].HeaderText = "部门";
            judges_dg.Columns["judgename"].HeaderText = "姓名";
            judges_dg.Columns["title"].HeaderText = "职称";
            judges_dg.Columns["phone"].HeaderText = "手机";
            judges_dg.Columns["sex"].HeaderText = "性别";
            judges_dg.Columns["age"].HeaderText = "年龄";
            judges_dg.Columns[3].ReadOnly = true;
            judges_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            judges_dg.CellClick += new DataGridViewCellEventHandler(judges_dg_CellClick);
            judges_dg.DataSourceChanged += new EventHandler(judges_dg_DataSourceChanged);
            judges_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
            voter_dg.Columns["department"].HeaderText = "部门";
            voter_dg.Columns["judgename"].HeaderText = "姓名";
            voter_dg.Columns["title"].HeaderText = "职称";
            voter_dg.Columns["phone"].HeaderText = "手机";
            voter_dg.Columns["sex"].HeaderText = "性别";
            voter_dg.Columns["age"].HeaderText = "年龄";
            voter_dg.ReadOnly = true;
            voter_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            voter_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            voter_dg.DataSourceChanged += new EventHandler(voter_dg_DataSourceChanged);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(voter_FormClosing);
        }
        private void voter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refreshParent != null)
                refreshParent(null);
        }
        private void judges_dg_DataSourceChanged(object sender, EventArgs e)
        {
            int currentindex = judges_dg.CurrentRow.Index;
            string phone = Convert.ToString(judges_dg.Rows[currentindex].Cells[3].Value);
            DataTable dt = mainform.db.query_dt("select * from dbo.voter where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            if (dt.Rows.Count != 0)
            {
                select.Enabled = false;
            }
            else
            {
                select.Enabled = true;
            }
        }
        private void voter_dg_DataSourceChanged(object sender, EventArgs e)
        {
            int currentindex = judges_dg.CurrentRow.Index;
            string phone = Convert.ToString(judges_dg.Rows[currentindex].Cells[3].Value);
            DataTable dt = mainform.db.query_dt("select * from dbo.voter where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            if (dt.Rows.Count != 0)
            {
                select.Enabled = false;
            }
            else
            {
                select.Enabled = true;
            }
        }
        private void meeting_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='"+meeting_select.Text+"'");
        }
        private void department_select_SelectIndexChanged(object sender, EventArgs e)
        {
            if (department_select.Text != "")
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from dbo.judges where department='" + department_select.Text + "'");
            else
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from dbo.judges ");
        }
        private void judges_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentindex = judges_dg.CurrentRow.Index;
            string phone = Convert.ToString(judges_dg.Rows[currentindex].Cells[3].Value);
            DataTable dt = mainform.db.query_dt("select * from dbo.voter where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            if (dt.Rows.Count!=0)
            {
                select.Enabled = false;
            }
            else
            {
                select.Enabled = true;
            }
        }
        private void check_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string sql = "select department,judgename,title,phone,sex,age from dbo.judges ";
            if (judgename.Text != "")
            {
                if(!flag)
                {
                    sql+=" where judgename='"+judgename.Text+"'";
                    flag=true;
                }
                else 
                   sql+=" and judgename='"+judgename.Text+"'";
            }
            if (phone.Text != "")
            {
                if(!flag)
                {
                    sql+=" where phone='"+phone.Text+"'";
                    flag=true;
                }
                else 
                   sql+=" and phone='"+phone.Text+"'";
            }
            if (title.Text != "")
            {
                if (!flag)
                {
                    sql += " where title='" + title.Text + "'";
                    flag = true;
                }
                else
                    sql += " and title='" + title.Text + "'";
            }
            judges_dg.DataSource = mainform.db.query_dt(sql);
          }
        private void display_Click(object sender, EventArgs e)
        {
            if(department_select.Text!="")
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from judges where department='" + department_select.Text + "'");
            else
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from judges ");
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            if (judges_dg.Rows.Count == 0) return;
            judges_dg.DataSource = mainform.db.update("delete from judges where department='" + department_select.Text + "'");
            judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from judges where department='" + department_select.Text + "'");
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (judges_dg.Rows.Count == 0) return;
            int current = judges_dg.CurrentRow.Index;
            object obj = judges_dg.Rows[current].Cells[3].Value;
            string phone = Convert.ToString(obj);
            DataTable dt = new DataTable();
            DataTable temp = new DataTable();
            temp = (DataTable)judges_dg.DataSource;
            dt = temp.Copy();
            dt.Clear();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                string tempphone = Convert.ToString(temp.Rows[i].ItemArray[3]);
                if (tempphone != phone)
                {
                    dt.Rows.Add(temp.Rows[i].ItemArray);
                }
            }
            judges_dg.DataSource = dt;
            mainform.db.update("delete from dbo.judges where phone='" + phone + "'");
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void add_judge_Click(object sender, EventArgs e)
        {
            addjudge adj = new addjudge();
            adj.refreshParent += new addjudge.refreshParentForm(adj_refreshParentForm);
            adj.StartPosition = FormStartPosition.CenterScreen;
            adj.Show();
        }
        private void adj_refreshParentForm(object sender)
        {
            department_select.DataSource = mainform.db.query_dt("select '' as department union select distinct department from dbo.judges");
            if (department_select.Text != "")
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from judges where department='" + department_select.Text + "'");
            else
                judges_dg.DataSource = mainform.db.query_dt("select department,judgename,title,phone,sex,age from judges ");
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < judges_dg.Rows.Count; i++)
            {
                object obj = judges_dg.Rows[i].Cells[0].Value;
                string department = Convert.ToString(obj);
                object obj1 = judges_dg.Rows[i].Cells[1].Value;
                string judgename = Convert.ToString(obj1);
                object obj2 = judges_dg.Rows[i].Cells[2].Value;
                string title = Convert.ToString(obj2);
                object obj3 = judges_dg.Rows[i].Cells[3].Value;
                string phone = Convert.ToString(obj3);
                object obj4 = judges_dg.Rows[i].Cells[4].Value;
                string sex = Convert.ToString(obj4);
                object obj5 = judges_dg.Rows[i].Cells[5].Value;
                string age = Convert.ToString(obj5);
                try
                {
                    mainform.db.update("update judges set department='"+department+"',judgename='"+judgename+"',title='"+title+"',sex='"+sex+"',age="+age+" where phone='"+phone+"'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");

        }

        private void select_Click(object sender, EventArgs e)
        {
            try
            {
                int currentindex = judges_dg.CurrentRow.Index;
                string phone = Convert.ToString(judges_dg.Rows[currentindex].Cells[3].Value);
                mainform.db.update("insert into dbo.voter values('" + meeting_select.Text + "','" + phone + "',0)");
                voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            select.Enabled = false;
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            if (voter_dg.Rows.Count == 0) return;
            int currentindex = voter_dg.CurrentRow.Index;
            string phone = Convert.ToString(voter_dg.Rows[currentindex].Cells[3].Value);
            mainform.db.update("delete from voter where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void select_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < judges_dg.Rows.Count; i++)
            {
                string phone = Convert.ToString(judges_dg.Rows[i].Cells[3].Value);
                try
                {
                    mainform.db.update("insert into dbo.voter values('" + meeting_select.Text + "','" + phone + "','False')");
                }
                catch
                {
              
                }
            }
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void delete_all2_Click(object sender, EventArgs e)
        {
            if (voter_dg.Rows.Count == 0) return;
            mainform.db.update("delete from voter where meetingname='" + meeting_select.Text + "'");
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void display2_Click(object sender, EventArgs e)
        {
            voter_dg.DataSource = mainform.db.query_dt("select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void check1_Click(object sender, EventArgs e)
        {
           string temp="select department,judgename,title,judges.phone,sex,age from judges,voter where judges.phone=voter.phone and meetingname='"+meeting_select.Text+"'" ;
           if(department.Text!="")
             temp += " and department='" + department.Text + "'";
            if (name2.Text != "")
               temp += " and judgename='" + name2.Text + "'";
           if (phone2.Text != "")
               temp += " and voter.phone='" + phone2.Text + "'";
           try 
           {
               voter_dg.DataSource = mainform.db.query_dt(temp); 
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           department.Text = "";
           name2.Text = "";
           phone2.Text = "";
        }
    }
}
