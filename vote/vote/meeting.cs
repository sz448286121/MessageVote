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
    public partial class meeting : Form
    {
        public delegate void RefreshParentForm(object sender);
        public RefreshParentForm refreshparentform;
        public meeting()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void meeting_Load(object sender, EventArgs e)
        {
            meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting order by meetingtime");
            meeting_dg.Columns["meetingname"].HeaderText = "会议名称";
            meeting_dg.Columns["meetingtime"].HeaderText = "会议时间";
            meeting_dg.Columns["meetingaddress"].HeaderText = "会议地点";
            meeting_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            meeting_dg.Columns[0].ReadOnly = true;
        }

        private void check_Click(object sender, EventArgs e)
        {
           meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting where meetingname='"+meetingname_tb.Text+"'");
        }

        private void display_Click(object sender, EventArgs e)
        {
            meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting order by meetingtime");
        }
        private void check_by_date_Click(object sender, EventArgs e)
        {
            DateTime start = start_time.Value;
            DateTime end = end_time.Value;
            if (start.Date> end.Date){ MessageBox.Show("起始时间大于结束时间！"); return;}
            meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting where meetingtime>='"+start+"'and meetingtime<='"+end+"'order by meetingtime");
        }

        private void add_meeting_Click(object sender, EventArgs e)
        {
            addmeeting am = new addmeeting();
            am.refreshParent += new addmeeting.RefreshParentForm(am_refreshParent);
            am.StartPosition = FormStartPosition.CenterScreen;
            am.Show();
            //meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting order by meetingtime");
        }
        private void am_refreshParent(object sender)
        {
            meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting order by meetingtime");
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if(meeting_dg.Rows.Count==0) return ;
            int current_index= meeting_dg.CurrentRow.Index;
            object obj = meeting_dg.Rows[current_index].Cells[0].Value;
            string meetingname = Convert.ToString(obj);
            try
            {
                mainform.db.update("delete from dbo.meeting where meetingname='" + meetingname + "'");
                DataTable temp = new DataTable();
                temp =(DataTable) meeting_dg.DataSource;
                DataTable temp2 = new DataTable();
                temp2 = temp.Copy();
                temp2.Clear();
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                   string  tempname=Convert.ToString(temp.Rows[i].ItemArray[0]);
                    if(tempname!=meetingname)
                    {
                        temp2.Rows.Add(temp.Rows[i].ItemArray);
                    }
                }
                meeting_dg.DataSource =temp2;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void delete_all_Click(object sender, EventArgs e)
        {
           // mainform.db.update("truncate dbo.meeting");
            mainform.db.update("delete from dbo.meeting");
            meeting_dg.DataSource = mainform.db.query_dt("select *from dbo.Meeting order by meetingtime");
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < meeting_dg.Rows.Count; i++)
            {
                object obj1 = meeting_dg.Rows[i].Cells[0].Value;
                string meetingname = Convert.ToString(obj1);
                object obj2 = meeting_dg.Rows[i].Cells[1].Value;
                DateTime meetingtime = Convert.ToDateTime(obj2);
                object obj3 = meeting_dg.Rows[i].Cells[2].Value;
                string meetingaddress = Convert.ToString(obj3);
                mainform.db.update("update dbo.meeting set meetingtime='"+meetingtime+"' , meetingaddress='"+meetingaddress+"' where meetingname='"+meetingname+"'");
            }
            if (refreshparentform != null)
            {
                refreshparentform(this);
            }
            this.Close();
        }
    }
}
