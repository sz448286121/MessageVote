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
    public partial class poll : Form
    {
        public poll()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void poll_Load(object sender, EventArgs e)
        {
            meeting_select.DataSource = mainform.db.query_dt("select meetingname from dbo.meeting order by meetingtime");
            meeting_select.DisplayMember = "meetingname";
            meeting_select.SelectedIndexChanged += new EventHandler(meeting_select_SelectedIndexChanged);
            poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "'");
            poll_dg.Columns["pollnum"].HeaderText = "评审序号";
            poll_dg.Columns["pollname"].HeaderText = "评审名称";
            poll_dg.Columns["method"].HeaderText = "评审方式";
            poll_dg.Columns["finish"].HeaderText = "评审状态";
            poll_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void meeting_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "'");
        }
        private void check_Click(object sender, EventArgs e)
        {
            if (pollnum.Text != "")
            {
                poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "' and pollnum=" + pollnum.Text);
            }
            else
            {
                poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "' and pollname='" + pollname.Text+"'");
            }
            pollname.Text = "";
            pollnum.Text = "";
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            mainform.db.update("delete from dbo.poll where meetingname='"+meeting_select.Text+"'");
            poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='"+meeting_select.Text+"'");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int current_index = poll_dg.CurrentRow.Index;
            object obj = poll_dg.Rows[current_index].Cells[0].Value;
            int pollnum = Convert.ToInt32(obj);
            mainform.db.update("delete from dbo.poll where pollnum=" + pollnum + "and meetingname='" + meeting_select.Text + "'");
            this.meeting_select_SelectedIndexChanged(sender, e);
        }

        private void add_poll_Click(object sender, EventArgs e)
        {
            addpoll ap = new addpoll(meeting_select.Text);
            ap.refreshParent += new addpoll.RefreshParentForm(ap_refreshParent);
            ap.StartPosition = FormStartPosition.CenterScreen;
            ap.Show();
        }
        private void ap_refreshParent(object sender)
        {
            poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "'");
        }
        private void display_Click(object sender, EventArgs e)
        {
            poll_dg.DataSource = mainform.db.query_dt("select pollnum,pollname,method,finish from dbo.poll where meetingname='" + meeting_select.Text + "'");
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poll_dg.Rows.Count; i++)
            {
                object obj=poll_dg.Rows[i].Cells[0].Value;
                string  pollnum = Convert.ToString(obj);
                object obj2 = poll_dg.Rows[i].Cells[1].Value;
                string pollname = Convert.ToString(obj2);
                object obj3 = poll_dg.Rows[i].Cells[2].Value;
                string method = Convert.ToString(obj3);
                object obj4 = poll_dg.Rows[i].Cells[3].Value;
                string  finish = Convert.ToString(obj4);
                if (finish == "False") finish = "0";
                else finish = "1";
                try
                {
                    mainform.db.update("update dbo.poll set pollname='" + pollname + "',method=" + method + ",finish=" + finish + " where meetingname='" + meeting_select.Text + "' and pollnum=" + pollnum);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }
            this.Close();
        }
    }
}
