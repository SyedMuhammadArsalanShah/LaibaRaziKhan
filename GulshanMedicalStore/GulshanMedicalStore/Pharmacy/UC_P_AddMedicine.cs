using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GulshanMedicalStore.Pharmacy
{
    public partial class UC_P_AddMedicine : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text!="" && txtMediName.Text!="" && txtMediNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                string mid = txtMediID.Text;
                string mname = txtMediName.Text;
                string mnumber = txtMediNumber.Text;
                string mDate = txtManufacturingDate.Text;
                string eDate = txtExpiryDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);
                //query for inserting all data into sql server;
                query = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perunit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "','" + quantity + "','" + perunit+ "')";
                fn.setData(query, "Medicine Added to Database");
                
            }
            else
            {
                MessageBox.Show("Enter All Data", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpiryDate.ResetText();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
