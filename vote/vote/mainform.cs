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
    public partial class mainform : Form
    {
        public static DataBase db = new DataBase("server=;database=vote;uid=sa;pwd=");
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public mainform()
        {
            InitializeComponent();
        }
        public void mainform_Load(object sender, EventArgs e)
        {
            meeting_select.DataSource = db.query_dt("select meetingname from dbo.Meeting order by meetingtime");
            meeting_select.DisplayMember = "meetingname";
            meeting_select.SelectedIndexChanged += new EventHandler(meeting_select_SelectedIndexChanged);

            presence_dg.DataSource = db.query_dt("select department,judgename,title,judges.phone,sex,age,present from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
            presence_dg.Columns["department"].HeaderText = "单位";
            presence_dg.Columns["judgename"].HeaderText = "姓名";
            presence_dg.Columns["title"].HeaderText = "职称";
            presence_dg.Columns["phone"].HeaderText = "手机";
            presence_dg.Columns["sex"].HeaderText = "性别";
            presence_dg.Columns["age"].HeaderText = "年龄";
            presence_dg.Columns["present"].HeaderText = "签到";

            presence_dg.Columns["department"].ReadOnly =true;
            presence_dg.Columns["judgename"].ReadOnly = true;
            presence_dg.Columns["title"].ReadOnly = true;
            presence_dg.Columns["phone"].ReadOnly = true;
            presence_dg.Columns["sex"].ReadOnly = true;
            presence_dg.Columns["age"].ReadOnly = true;
            presence_dg.Columns["present"].ReadOnly = false;
       //     presence_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                presence_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          presence_dg.CellValueChanged += new DataGridViewCellEventHandler(presence_dg_CellValueChanged);
          presence_dg.CellMouseUp += new DataGridViewCellMouseEventHandler(presence_dg_CellMouseUp);
            meeting_select_SelectedIndexChanged(this, e);
            department_select.DataSource = mainform.db.query_dt("select '' as department union select distinct department from dbo.judges");
            department_select.DisplayMember = "department";
            asc.controllInitializeSize(this);
            this.SizeChanged += new EventHandler(mainform_SizeChanged);
        }
        private void mainform_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
          //  this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化
        }
        private void meeting_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meeting_select.Text == "") return;
            presence_dg.DataSource = db.query_dt("select department,judgename,title,judges.phone,sex,age,present from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = mainform.db.query_dt("select *from voter where present=1 and meetingname='" + meeting_select.Text + "'");
            dt2 = mainform.db.query_dt("select *from voter where meetingname='" + meeting_select.Text + "'");
            int cnt1 = dt1.Rows.Count;
            int cnt2 = dt2.Rows.Count;
            present_state.Text = cnt1.ToString() + "/" + cnt2.ToString();

            meetingtime.Text = Convert.ToString(mainform.db.query_dt("Select meetingtime from meeting where meetingname='" + meeting_select.Text + "'").Rows[0].ItemArray[0]);
            meetingaddress.Text = Convert.ToString(mainform.db.query_dt("Select meetingaddress from meeting where meetingname='" + meeting_select.Text + "'").Rows[0].ItemArray[0]);

           // department.DataSource=mainform.db.query_dt("select " " union select department from judges"); 
        }
 
        void presence_dg_CellMouseUp(Object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = presence_dg.CurrentCell.RowIndex;
            int column= presence_dg.CurrentCell.ColumnIndex;
            if (column == 6)
            {
                presence_dg.CurrentCell = presence_dg.Rows[0].Cells[0];
            }
        }
        void presence_dg_CellValueChanged(object sender, EventArgs e)
        {
            int row = presence_dg.CurrentCell.RowIndex;
            string phone = Convert.ToString(presence_dg.Rows[row].Cells[3].Value);
            Boolean present = Convert.ToBoolean(presence_dg.Rows[row].Cells[6].Value);
            if (present)
                mainform.db.update("update voter set present=1 where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            else
                mainform.db.update("update voter set present=0 where meetingname='" + meeting_select.Text + "' and phone='" + phone + "'");
            meeting_select_SelectedIndexChanged(this, e);
        }
        private void meeting_Click(object sender, EventArgs e)
        {
            meeting m = new meeting();
            m.refreshparentform += new meeting.RefreshParentForm(meeting_refreshparentform);
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }
        private void meeting_refreshparentform(object sender)
        {
            meeting_select.DataSource = db.query_dt("select meetingname from dbo.Meeting order by meetingtime");
            meeting_select_SelectedIndexChanged(this, null);
        }
        private void poll_Click(object sender, EventArgs e)
        {
            poll p = new poll();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }

        private void project_Click(object sender, EventArgs e)
        {
            project pj = new project();
            pj.StartPosition = FormStartPosition.CenterScreen;
            pj.Show();
        }

        private void voter_Click(object sender, EventArgs e)
        {
            voter vt = new voter();
            vt.StartPosition = FormStartPosition.CenterScreen;
            vt.refreshParent += new voter.RefreshParentForm(vt_refreshparent);
            vt.Show();
        }
        private void vt_refreshparent(object sender)
        {
            meeting_select_SelectedIndexChanged(this, null);
        }
        private void enter_vote_Click(object sender, EventArgs e)
        {
            voting vt = new voting(meeting_select.Text);
            vt.StartPosition = FormStartPosition.CenterScreen;
            vt.Show();
        }

        private void check_Click(object sender, EventArgs e)
        {
            string sql="select department,judgename,title,judges.phone,sex,age,present from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'";
            if (department_select.Text != "")
                sql += " and judges.department='" + department_select.Text + "'";
            if (name.Text != "")
                sql += " and judges.judgename='" + name.Text + "'";
            if (phone.Text != "")
                sql += " and judges.phone='" + phone.Text + "'";
            presence_dg.DataSource = mainform.db.query_dt(sql);
            department_select.Text = "";
            name.Text = "";
            phone.Text = "";
        }

        private void display_Click(object sender, EventArgs e)
        {
            presence_dg.DataSource = db.query_dt("select department,judgename,title,judges.phone,sex,age,present from judges,voter where judges.phone=voter.phone and meetingname='" + meeting_select.Text + "'");
        }

        private void send_message_Click(object sender, EventArgs e)
        {
            GsmModem gm = new GsmModem(GsmModem.FindPort(),9600);
            try
            {
                gm.Open();
            }
            catch { }
            gm.SendAT("AT");
            gm.SendAT("ATE0");
            gm.SendAT("AT+CMGF=0");
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string meetingtime= Convert.ToString(mainform.db.query_dt("select meetingtime from meeting where meetingname='" + meeting_select.Text + "'").Rows[0].ItemArray[0]);
            string meetingaddress = Convert.ToString(mainform.db.query_dt("select meetingaddress from meeting where meetingname='" + meeting_select.Text + "'").Rows[0].ItemArray[0]);
            dt = mainform.db.query_dt("select phone from voter where meetingname='"+meeting_select.Text+"' and present=0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string phone = Convert.ToString(dt.Rows[i].ItemArray[0]);
                dt2 = mainform.db.query_dt("select judgename from judges where phone='" + phone + "'");
                string name =Convert.ToString( dt2.Rows[0].ItemArray[0]);
                gm.SendMsg(phone, name+"老师：\n"+"        请您于"+meetingtime+"准时到" +meetingaddress.Trim()+"参加"+ meeting_select.Text + "!");
            }
            gm.Close();
            MessageBox.Show("发送成功！");
        }

        private void result_Click(object sender, EventArgs e)
        {
            result rs = new result();
            rs.StartPosition = FormStartPosition.CenterScreen;
            rs.Show();
        }

        private void information_Click(object sender, EventArgs e)
        {
            information ifm = new information();
            ifm.StartPosition = FormStartPosition.CenterScreen;
            ifm.Show();
        }
    }
}
