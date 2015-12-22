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
    public partial class addproject : Form
    {
        public delegate void RefreshParentForm(object sender);
        public event RefreshParentForm refreshParent;
        string meetingname, pollnum;
        public addproject(string meetingname,string pollnum)
        {
            InitializeComponent();
            this.meetingname = meetingname;
            this.pollnum = pollnum;
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string projectnum;
                DataTable dt = mainform.db.query_dt("select max(projectnum) from dbo.project where meetingname='" + meetingname + "' and pollnum='" + pollnum + "'");
                if (dt.Rows.Count == 0)
                    projectnum = "1";
                else
                    projectnum = Convert.ToString(Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString()) + 1);
                mainform.db.update("insert into dbo.project values('" +meetingname+"','"+pollnum+"','"+projectnum+"','"+projectname.Text+"','"+department.Text+"','"+principal.Text+"','"+information.Text+ "')");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.refreshParent != null)
                {
                    refreshParent(null);
                }
            }
        }
        
    }
}
