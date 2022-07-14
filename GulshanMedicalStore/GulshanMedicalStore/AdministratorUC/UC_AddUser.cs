using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GulshanMedicalStore.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string dob = txtDob.Text;
            string mobile = Convert.ToString(txtMobile.Text);
            string email = txtEmail.Text;
            string username = TxtUsername.Text;
            string pass = TxtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values('"+role+"','"+name+"','"+dob+"','"+mobile+ "','"+ email + "','"+username+"','"+pass+"')";
                fn.setData(query, "Sign Up Successful.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username Allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            txtUserRole.SelectedIndex = 1;
            

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + TxtUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"D:\Source\repo\Project\Pharmacy Management System in C#\yes.png";

            }
            else
            {
                pictureBox1.ImageLocation = @"D:\Source\repo\Project\Pharmacy Management System in C#\no.png";

            }
        }
    }
}
