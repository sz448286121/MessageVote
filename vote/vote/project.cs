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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void project_Load(object sender, EventArgs e)
        {
            try
            {
                meeting_select.DataSource = mainform.db.query_dt("select meetingname from dbo.Meeting order by meetingtime");
                meeting_select.DisplayMember = "meetingname";
                this.meeting_select.SelectedIndexChanged += new System.EventHandler(meeting_select_SelectedIndexChanged);

                pollnum_select.DataSource = mainform.db.query_dt("select pollnum from dbo.poll where meetingname='" + meeting_select.Text + "'");
                pollnum_select.DisplayMember = "pollnum";
                pollnum_select.SelectedIndexChanged += new EventHandler(pollnum_select_SelectedIndexChanged);

                pollnum_select_SelectedIndexChanged(this, e);

                project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text+"'");
                project_dg.Columns["projectnum"].HeaderText = "项目序号";
                project_dg.Columns["projectname"].HeaderText = "项目名称";
                project_dg.Columns["department"].HeaderText = "部门";
                project_dg.Columns["principal"].HeaderText = "负责人";
                project_dg.Columns["information"].HeaderText = "项目信息";
                project_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void meeting_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from dbo.poll where meetingname='" + meeting_select.Text + "'");
            pollnum_select.DisplayMember = "pollnum";

            project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'");
        }
        private void pollnum_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'");
            pollname.Text = Convert.ToString(mainform.db.query_dt("select pollname from dbo.poll where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'").Rows[0].ItemArray[0]);
        }
        private void display_Click(object sender, EventArgs e)
        {
            project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'");
        }
        private void delete_all_Click(object sender, EventArgs e)
        {
            mainform.db.update("delete from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum=" + pollnum_select.Text);
            project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'");
        }

        private void check_Click(object sender, EventArgs e)
        {
            string sql="select projectnum,projectname,principal,information from dbo.project ";
            bool flag = false;
            if (projectnum.Text != "")
            {
                if (!flag)
                    sql += " where projectnum='" + projectnum.Text + "'";
                else
                {
                    sql += " and projectnum='" + projectnum.Text + "'";
                    flag = true;
                }
            }
            if (projectname.Text != "")
            {
                if (!flag)
                    sql += " where projectname='" + projectname.Text + "'";
                else
                {
                    sql += " and projectname='" + projectname.Text + "'";
                    flag = true;
                }
            }
            if (principal.Text != "")
            {
                if (!flag)
                    sql += " where principal='" + principal.Text + "'";
                else
                {
                    sql += " and principal='" + principal.Text + "'";
                    flag = true;
                }
            }
            project_dg.DataSource = mainform.db.query_dt(sql);
            projectnum.Text = "";
            projectname.Text = "";
            principal.Text = "";
        }
        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < project_dg.Rows.Count; i++)
            {
                object obj = project_dg.Rows[i].Cells[0].Value;
                string projectnum = Convert.ToString(obj);
                object obj2 = project_dg.Rows[i].Cells[1].Value;
                string projectname = Convert.ToString(obj2);
                object obj3 = project_dg.Rows[i].Cells[2].Value;
                string department = Convert.ToString(obj3);
                object obj4 = project_dg.Rows[i].Cells[3].Value;
                string principal = Convert.ToString(obj4);
                object obj5 = project_dg.Rows[i].Cells[4].Value;
                string information = Convert.ToString(obj5);
                try
                {
                    mainform.db.update("update dbo.project set projectname='" + projectname +"',department='"+department+ "',principal='" + principal + "',information='" + information + "' where meetingname='" + meeting_select.Text + "' and pollnum='" + pollnum_select.Text + "' and projectnum=" + projectnum); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int current_index = project_dg.CurrentRow.Index;
            object obj = project_dg.Rows[current_index].Cells[0].Value;
            int projectnum = Convert.ToInt32(obj);
            mainform.db.update("delete from dbo.project where projectnum=" + projectnum + "and meetingname='" + meeting_select.Text + "'and pollnum='"+pollnum_select.Text+"'");
            this.pollnum_select_SelectedIndexChanged(sender, e);
        }

        private void addproject_Click(object sender, EventArgs e)
        {
            addproject apj = new addproject(meeting_select.Text, pollnum_select.Text);
            apj.refreshParent += new addproject.RefreshParentForm(apj_refreshParent);
            apj.StartPosition = FormStartPosition.CenterScreen;
            apj.Show();
        }
        private void apj_refreshParent(object sender)
        {
            project_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,department,principal,information from dbo.project where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'");
        }
    }
}
