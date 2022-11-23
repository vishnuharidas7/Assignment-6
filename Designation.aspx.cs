using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class Designation : System.Web.UI.Page
    {
        BAL.Desgn_Bal desgnbal = new BAL.Desgn_Bal();
        BAL.Dept_Bal deptbal = new BAL.Dept_Bal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = deptbal.viewDept();
                DropDownList1.DataTextField = "department_name";
                DropDownList1.DataValueField = "department_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--select--", "0"));


                GridView1.DataSource = desgnbal.viewDesgn();
                GridView1.DataBind();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            desgnbal.DesignationName = TextBox3.Text;
            desgnbal.Departmentid = Convert.ToInt32(DropDownList1.SelectedValue);
            int i = desgnbal.insertDesignation();
            GridView1.DataSource = desgnbal.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = desgnbal.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int desgn_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            desgnbal.Designationtid = desgn_id;
            int i = desgnbal.deleteDesgn();
            GridView1.DataSource = desgnbal.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = desgnbal.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int desgn_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox designation = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            string deptment = (GridView1.Rows[e.RowIndex].FindControl("dropdown2") as DropDownList).SelectedItem.Value;

            /*DropDownList dropDown;


            dropDown.DataSource = deptbal.viewDept();
            dropDown.DataTextField= "department_name";
            dropDown.DataValueField = "department_Id";
            dropDown.DataBind();*/

            desgnbal.DesignationName = designation.Text;
            desgnbal.Departmentid = Convert.ToInt32(deptment);
            desgnbal.Designationtid = desgn_id;
            //desgnbal.Departmentid=Convert.ToInt32(dropDown.SelectedValue);

            int i = desgnbal.updateDesgn();
            GridView1.EditIndex = -1;
            GridView1.DataSource = desgnbal.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                DropDownList dropDown = new DropDownList();
                dropDown = (DropDownList)e.Row.FindControl("dropdown2");
                if (dropDown != null)
                {
                    dropDown.DataSource = deptbal.viewDept();
                    dropDown.DataTextField = "department_name";
                    dropDown.DataValueField = "department_id";
                    dropDown.DataBind();

                    ((DropDownList)e.Row.FindControl("dropdown2")).SelectedValue = DataBinder.Eval(e.Row.DataItem, "DesignationId").ToString();
                }
            }


        }
    }
}