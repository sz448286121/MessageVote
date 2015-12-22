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
    public partial class addmeeting : Form
    {
        public delegate void RefreshParentForm(object sender);
        public event RefreshParentForm refreshParent;
        public addmeeting()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                mainform.db.update("insert into dbo.Meeting values('" + meetingname.Text + "','" + meetingtime.Value + "','"+meetingaddress.Text+"')");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("不能添加相同名称的会议！");
            }
            finally
            {
                if(this.refreshParent!=null)
                {
                    refreshParent(null);
                }
            }
        }

        private void addmeeting_Load(object sender, EventArgs e)
        {
            this.meetingtime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.meetingtime.Format = DateTimePickerFormat.Custom;
            this.meetingtime.ShowUpDown =true;
        }
    }
}
