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
    public partial class UC_P_Dashboard : UserControl
    {
        Function fn = new Function();
        DataSet ds;
        string query;
        Int64 count;


        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        //fetch the 
        public void loadChart()
        {
            //Validity 
            query = "select count(mname) from medic where eDate >= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chart", count);
            //expiry date
            query = "select count(mname) from medic where eDate <= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", count);

        }
    }
}
