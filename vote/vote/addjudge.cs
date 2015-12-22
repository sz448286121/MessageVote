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
    public partial class addjudge : Form
    {
        public delegate void refreshParentForm(object sender);
        public event refreshParentForm refreshParent;
        public addjudge()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                mainform.db.update("insert into judges(judgename,department,title,phone,sex,age) values('" + judgename.Text + "','" + department.Text + "','" + title.Text + "','" + phone.Text + "','" + sex.Text + "'," + age.Text + ")");
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
