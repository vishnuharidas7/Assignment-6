using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.Dept_Bal ob = new BAL.Dept_Bal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob.DepartName = TextBox3.Text;
            int i = ob.insertDepartment();
            if (i == 1)
            {
                TextBox3.Text = null;
                Label2.Text = "Inserted Successfully";
            }
        }
    }
}