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
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
        {
            meeting_select.DataSource = mainform.db.query_dt("select meetingname from meeting order by meetingtime");
            meeting_select.DisplayMember = "meetingname";
            meeting_select.SelectedIndexChanged += new EventHandler(meeting_select_SelectedIndexChanged);
            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from poll where meetingname='" + meeting_select.Text + "'");
            pollnum_select.DisplayMember = "pollnum";
            pollnum_select.SelectedIndexChanged += new EventHandler(pollnum_select_SelectedIndexChanged);

            pollnum_select_SelectedIndexChanged(this, e);
            information_dg.DataSource = mainform.db.query_dt("select judges.department,judges.judgename,judges.phone,voted,information from votestate,judges where votestate.phone=judges.phone and meetingname='"+meeting_select.Text+"' and pollnum='"+pollnum_select.Text+"'");
            information_dg.Columns[0].HeaderText = "单位";
            information_dg.Columns[1].HeaderText = "姓名";
            information_dg.Columns[2].HeaderText = "手机";
            information_dg.Columns[3].HeaderText = "已投";
            information_dg.Columns[4].HeaderText = "评审内容";
            information_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       
            
            information_dg.Columns[0].ReadOnly = true;

            information_dg.Columns[1].ReadOnly = true;
            information_dg.Columns[2].ReadOnly = true;
            information_dg.Columns[3].ReadOnly = true;
            information_dg.Columns[4].ReadOnly = false;

        }
        private void meeting_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from poll where meetingname='" + meeting_select.Text + "'");
            information_dg.DataSource = mainform.db.query_dt("select judges.department,judges.judgename,judges.phone,voted,information from votestate,judges where votestate.phone=judges.phone and meetingname='" + meeting_select.Text + "' and pollnum='" + pollnum_select.Text + "'");
        }
        private void pollnum_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            information_dg.DataSource = mainform.db.query_dt("select judges.department,judges.judgename,judges.phone,voted,information from votestate,judges where votestate.phone=judges.phone and meetingname='" + meeting_select.Text + "' and pollnum='" + pollnum_select.Text + "'");
            pollname.Text = Convert.ToString(mainform.db.query_dt("select pollname from dbo.poll where meetingname='" + meeting_select.Text + "' and  pollnum='" + pollnum_select.Text + "'").Rows[0].ItemArray[0]);

        }

        private void display_Click(object sender, EventArgs e)
        {
            information_dg.DataSource = mainform.db.query_dt("select judges.department,judges.judgename,judges.phone,voted,information from votestate,judges where votestate.phone=judges.phone and meetingname='" + meeting_select.Text + "' and pollnum='" + pollnum_select.Text + "'");

        }

        private void check_Click(object sender, EventArgs e)
        {
            string sql="select judges.department,judges.judgename,judges.phone,voted,information from votestate,judges where votestate.phone=judges.phone and meetingname='" + meeting_select.Text + "' and pollnum='" + pollnum_select.Text + "'";
            if (department.Text != "")
                sql += " and department='" + department.Text + "'";
            if (name.Text != "")
                sql += " and judgename='" + name.Text + "'";
            if (phone.Text != "")
                sql += " and votestate.phone='" + phone.Text + "'";
            information_dg.DataSource = mainform.db.query_dt(sql);
            department.Text = "";
            name.Text = "";
            phone.Text = "";
        }

    }
}
