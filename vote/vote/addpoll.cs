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
    public partial class addpoll : Form
    {
        string meetingname;
        public delegate void RefreshParentForm(object sender);
        public event RefreshParentForm refreshParent;
        public addpoll(string meetingname)
        {
            InitializeComponent();
            this.meetingname = meetingname;
        }
        public void addpoll_Load()
        {
            pollname.Text = "";
           
        }
        private string SearchCheckedRadioButton(Control.ControlCollection controlcolletion)
        {
            foreach (var item in controlcolletion)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = item as RadioButton;
                    if (radioButton.Checked)
                    {
                        return radioButton.Text.Trim();
                    }
                }
            }
            return null;
        }
        private void add_poll_Click(object sender, EventArgs e)
        {
            int methodnum = 1;
            string value = SearchCheckedRadioButton(method.Controls);
            switch (value)
            {
                case "百分制":
                    methodnum = 100;
                    break;
                case "十分制":
                    methodnum = 10;
                    break;
                case "01制":
                    methodnum = 1;
                    break;
            }
            try
            {
                DataTable dt = mainform.db.query_dt("select max(pollnum) from dbo.poll where meetingname='" + meetingname + "'");
                string pollnum;
                if (dt.Rows.Count == 0)
                    pollnum = "1";
                else
                    pollnum = Convert.ToString(Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString()) + 1);
                mainform.db.update("insert into dbo.poll values('" + meetingname + "'," + pollnum + ",'" + pollname.Text + "'," + methodnum.ToString() + ",0)");
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
