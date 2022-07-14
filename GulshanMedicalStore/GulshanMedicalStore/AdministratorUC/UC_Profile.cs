using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GulshanMedicalStore.AdministratorUC
{
    
    public partial class UC_Profile : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { userNameLabel.Text = value; }
        }
        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username ='" + userNameLabel.Text + "'";
            DataSet ds= fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text=ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();



        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string dob = txtDob.Text;
            string mobile = txtMobile.Text;
            string email = txtEmail.Text;
            string username = userNameLabel.Text;
            string pass = txtPassword.Text;
            query="update users set userRole ='"+role+"',name='"+name+"',dob='"+dob+"',mobile='"+mobile+"',email='"+email+"',pass='"+pass+"' where username='"+username+"'";
            fn.setData(query, "Profile Updated !");
        }
    }
}
