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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            meetingname_select.DataSource = mainform.db.query_dt("select meetingname from meeting order by meetingtime");
            meetingname_select.DisplayMember = "meetingname";
            meetingname_select.SelectedIndexChanged += new EventHandler(meetingname_select_SelectedIndexChanged);

            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from poll where meetingname='" + meetingname_select.Text + "'");
            pollnum_select.DisplayMember = "pollnum";
            pollnum_select.SelectedIndexChanged += new EventHandler(pollnum_select_SelectedIndexChanged);

            meetingname_select_SelectedIndexChanged(this, e);
            pollnum_select_SelectedIndexChanged(this, e);
        }
        private void meetingname_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from poll where meetingname='" + meetingname_select.Text + "'");
            pollnum_select.DisplayMember = "pollnum";
            result_dg.DataSource = mainform.db.query_dt("select project.projectnum,project.projectname,project.department,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname_select.Text + "' and result.pollnum='" + pollnum_select.Text + "'order by result.sum");
            result_dg.Columns[0].HeaderText = "项目编号";
            result_dg.Columns[1].HeaderText = "项目名称";
            result_dg.Columns[2].HeaderText = "单位";
            result_dg.Columns[3].HeaderText = "负责人";
            result_dg.Columns[4].HeaderText = "得分";
            result_dg.ReadOnly = true;
            result_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            result_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void pollnum_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            result_dg.DataSource = mainform.db.query_dt("select project.projectnum,project.projectname,project.department,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname_select.Text + "' and result.pollnum='" + pollnum_select.Text + "'order by result.sum  DESC");
            result_dg.Columns[0].HeaderText = "项目编号";
            result_dg.Columns[1].HeaderText = "项目名称";
            result_dg.Columns[2].HeaderText = "单位";
            result_dg.Columns[3].HeaderText = "负责人";
            result_dg.Columns[4].HeaderText = "得分";
            result_dg.ReadOnly = true;
            result_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            result_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pollname.Text = Convert.ToString(mainform.db.query_dt("select pollname from dbo.poll where meetingname='" + meetingname_select.Text + "' and  pollnum='" + pollnum_select.Text + "'").Rows[0].ItemArray[0]);

        }

        private void check_Click(object sender, EventArgs e)
        {
            string sql = "select project.projectnum,project.projectname,project.department,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname_select.Text + "' and result.pollnum='" + pollnum_select.Text + "'";
            if (projectnum.Text != "")
            {
                sql += " and project.projectnum='" + projectnum.Text + "'";
            }
            if (department.Text != "")
            {
                sql += " and project.department='" + department.Text + "'";
            }
            if (principal.Text != "")
            {
                sql += " and project.principal='" + principal.Text + "'";
            }
            sql +="  order by result.sum";
            result_dg.DataSource = mainform.db.query_dt(sql);
            projectnum.Text = "";
            department.Text = "";
            principal.Text = "";
        }

        private void display_Click(object sender, EventArgs e)
        {
            result_dg.DataSource = mainform.db.query_dt("select project.projectnum,project.projectname,project.department,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname_select.Text + "' and result.pollnum='" + pollnum_select.Text + "'order by result.sum");
        }
    }
}
