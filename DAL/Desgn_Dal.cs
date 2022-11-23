using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace GridView.DAL
{
    public class Desgn_Dal
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Desgn_Dal()
        {
            //conection string in web.config
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int designationInsert(BAL.Desgn_Bal obj)
        {
            string qry = "insert into tbl_designation values('" + obj.DesignationName + "','" + obj.Departmentid + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable viewDesignation()
        {
            string qry = "select desg.*,dept.* from tbl_designation desg join tbl_department dept  on desg.DepartmentId=dept.department_Id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;

        }

        public int updateDesignation(BAL.Desgn_Bal obj)
        {
            string s = "update tbl_designation set DesignationName = '" + obj.DesignationName + "',DepartmentId='" + obj.Departmentid + "' where DesignationId = '" + obj.Designationtid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int deleteDesignation(BAL.Desgn_Bal obj)
        {
            string s = "Delete from tbl_designation where DesignationId = '" + obj.Designationtid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }



    }
}